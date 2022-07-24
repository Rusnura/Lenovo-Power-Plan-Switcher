using LenovoPlanSwitcher.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenovoPlanSwitcher.Services
{
    public class PowerPlanSwitchService
    {
        private readonly PowerModeFeature _powerModeFeature = new PowerModeFeature();
        private readonly PowerPlanFeature _powerPlanFeature = new PowerPlanFeature();

        public List<PowerPlan> PowerPlans { get { return _powerPlanFeature.powerPlans; } }
        private PowerModeState PreviousLenovoState { get; set; }
        public PowerModeState CurrentLenovoState { get { return _powerModeFeature.GetState(); } private set { _powerModeFeature.SetState(value); } }
        public PowerPlan CurrentWindowsPlan { get { return _powerPlanFeature.GetState(); } private set { _powerPlanFeature.SetState(value); } }
        public PowerPlan QuietModePowerPlan { get; set; }
        public PowerPlan BalanceModePowerPlan { get; set; }
        public PowerPlan PerformanceModePowerPlan { get; set; }

        public void UpdateWindowsPlanByLenovoPowerState(PowerModeState lenovoState)
        {
            if (PreviousLenovoState == lenovoState)
                return;

            PreviousLenovoState = lenovoState;

            switch (PreviousLenovoState)
            {
                case PowerModeState.Quiet:
                    if (QuietModePowerPlan.PowerPlanId != Guid.Empty)
                        CurrentWindowsPlan = QuietModePowerPlan;
                break;

                case PowerModeState.Balance:
                    if (BalanceModePowerPlan.PowerPlanId != Guid.Empty)
                        CurrentWindowsPlan = BalanceModePowerPlan;
                break;

                case PowerModeState.Performance:
                    if (PerformanceModePowerPlan.PowerPlanId != Guid.Empty)
                        CurrentWindowsPlan = PerformanceModePowerPlan;
                break;

                default:
                    // NOP
                break;
            }

        }
    }
}
