using LenovoPlanSwitcher.Features;
using LenovoPlanSwitcher.Features.Models;
using LenovoPlanSwitcher.Native;
using LenovoPlanSwitcher.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenovoPlanSwitcher
{
    public partial class mainForm : Form
    {
        private PowerPlanSwitchService service = new PowerPlanSwitchService();
        public string CurrentLenovoPowerStateName { get { return service.CurrentLenovoState.ToString(); } }
        public string CurrentWindowsPlanName { get { return service.CurrentWindowsPlan.ToString(); } }

        public PowerPlan[] getWindowsPowerPlans(bool addSelectHint = true)
        {
            List<PowerPlan> powerPlans = new List<PowerPlan>();
            if (addSelectHint)
                powerPlans.Add(new PowerPlan(Guid.Empty, "- Выберите план питания -"));

            powerPlans.AddRange(service.PowerPlans);

            return powerPlans.ToArray();
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            lenovoPowerPlanWatch_tmr.Enabled = true;

            quietMode_cmbBox.Items.AddRange(getWindowsPowerPlans());
            balancedMode_cmbBox.Items.AddRange(getWindowsPowerPlans());
            performanceMode_cmbBox.Items.AddRange(getWindowsPowerPlans());

            quietMode_cmbBox.SelectedIndex = 0;
            balancedMode_cmbBox.SelectedIndex = 0;
            performanceMode_cmbBox.SelectedIndex = 0;
        }

        private void lenovoPowerPlanWatch_tmr_Tick(object sender, EventArgs e)
        {
            currentLenovoPlan_lbl.Text = CurrentLenovoPowerStateName;
            currentWindowsPlan_lbl.Text = CurrentWindowsPlanName;

            service.UpdateWindowsPlanByLenovoPowerState(service.CurrentLenovoState);
        }

        private void quietMode_cmbBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            service.QuietModePowerPlan = (PowerPlan)quietMode_cmbBox.SelectedItem;
        }

        private void balancedMode_cmbBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            service.BalanceModePowerPlan = (PowerPlan)balancedMode_cmbBox.SelectedItem;
        }

        private void performanceMode_cmbBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            service.PerformanceModePowerPlan = (PowerPlan)performanceMode_cmbBox.SelectedItem;
        }
    }
}
