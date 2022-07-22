using LenovoPlanSwitcher.Features.Models;
using LenovoPlanSwitcher.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenovoPlanSwitcher.Features
{
    public class PowerPlanFeature : IFeature<PowerPlan>
    {
        public readonly List<PowerPlan> powerPlans;

        public PowerPlanFeature()
        {
            powerPlans = PowerPlanNative.GetAll()
                .Select(plan => new PowerPlan(plan, PowerPlanNative.GetName(plan)))
                .ToList();
        }

        public PowerPlan GetState()
        {
            try
            {
                Guid currentPowerPlan = PowerPlanNative.getCurrentPowerPlan();
                return powerPlans.First(plan => plan.powerPlanId.Equals(currentPowerPlan));
            }
            catch
            {
                MessageBox.Show("Не удалось получить текущий план производительности Windows!" +
                    "Проверьте, есть ли у Вас права администратора!");
                return null;
            }
        }

        public void SetState(PowerPlan plan)
        {
            if (plan.powerPlanId == Guid.Empty)
            {
                return;
            }

            PowerPlanNative.SetPowerPlan(plan.powerPlanId);
        }
    }
}
