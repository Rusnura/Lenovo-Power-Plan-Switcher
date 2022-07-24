using LenovoPlanSwitcher.Features;
using LenovoPlanSwitcher.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenovoPlanSwitcher.Features
{
    public class PowerPlan
    {
        public Guid PowerPlanId { get; }
        public string Name { get; }

        public PowerPlan(Guid powerPlanId, string name)
        {
            PowerPlanId = powerPlanId;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class PowerPlanFeature : IFeature<PowerPlan>
    {
        public readonly List<PowerPlan> powerPlans;
        public readonly PowerPlan emptyPowerPlan = new PowerPlan(Guid.Empty, "-");

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
                return powerPlans.First(plan => plan.PowerPlanId.Equals(currentPowerPlan));
            }
            catch
            {
                MessageBox.Show("Не удалось получить текущий план производительности Windows!" +
                    "Проверьте, есть ли у Вас права администратора!");
                return emptyPowerPlan;
            }
        }

        public void SetState(PowerPlan plan)
        {
            if (plan.PowerPlanId == Guid.Empty)
            {
                return;
            }

            PowerPlanNative.SetPowerPlan(plan.PowerPlanId);
        }
    }
}
