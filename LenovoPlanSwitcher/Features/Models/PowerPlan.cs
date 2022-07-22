using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenovoPlanSwitcher.Features.Models
{
    public class PowerPlan
    {
        public Guid powerPlanId { get; }
        public string name { get; }

        public PowerPlan(Guid powerPlanId, string name)
        {
            this.powerPlanId = powerPlanId;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
