using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenovoPlanSwitcher.Features
{
    public enum PowerModeState
    {
        Quiet,
        Balance,
        Performance
    }

    public class PowerModeFeature : AbstractWMIFeature<PowerModeState>
    {
        public PowerModeFeature() : base("SmartFanMode", 1)
        {

        }
    }
}
