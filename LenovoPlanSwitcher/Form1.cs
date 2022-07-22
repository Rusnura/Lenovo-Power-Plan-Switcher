using LenovoPlanSwitcher.Features;
using LenovoPlanSwitcher.Features.Models;
using LenovoPlanSwitcher.Native;
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
        private readonly PowerModeFeature _powerModeFeature = new PowerModeFeature();
        private readonly PowerPlanFeature _powerPlanFeature = new PowerPlanFeature();
        private PowerModeState currentLenovoPowerMode;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //currentLenovoPlan_lbl.Text = _powerModeFeature.GetState().ToString();
            //currentWindowsPlan_lbl.Text = _powerPlanFeature.GetState().ToString();

            List<PowerPlan> powerPlans = new List<PowerPlan>();
            powerPlans.Add(new PowerPlan(Guid.Empty, "- Выберите план питания -"));
            powerPlans.AddRange(_powerPlanFeature.powerPlans.ToArray());

            slientMode_cmbBox.Items.AddRange(powerPlans.ToArray());
            balancedMode_cmbBox.Items.AddRange(powerPlans.ToArray());
            performanceMode_cmbBox.Items.AddRange(powerPlans.ToArray());

            slientMode_cmbBox.SelectedIndex = 0;
            balancedMode_cmbBox.SelectedIndex = 0;
            performanceMode_cmbBox.SelectedIndex = 0;

            //MessageBox.Show(_powerPlanFeature.GetState().ToString());
            // MessageBox.Show(_powerModeFeature.GetState().ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*foreach (PowerPlan plan in _powerPlanFeature.powerPlans)
            {
                MessageBox.Show(plan.ToString(), "Plans", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/


            //            Guid plan = PowerPlanNative.GetAll().ToList()[1];
            //            MessageBox.Show(PowerPlanNative.GetName(plan), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            PowerPlanNative.SetPowerPlan(plan);

            lenovoPowerPlanWatch_tmr.Enabled = true;
        }

        private void lenovoPowerPlanWatch_tmr_Tick(object sender, EventArgs e)
        {
            currentLenovoPlan_lbl.Text = _powerModeFeature.GetState().ToString();
            currentWindowsPlan_lbl.Text = _powerPlanFeature.GetState().ToString();

            if (_powerModeFeature.GetState() == currentLenovoPowerMode)
                return;

            currentLenovoPowerMode = _powerModeFeature.GetState();
            
            switch (currentLenovoPowerMode)
            {
                case PowerModeState.Quiet:
                    _powerPlanFeature.SetState((PowerPlan)slientMode_cmbBox.SelectedItem);
                break;

                case PowerModeState.Balance:
                    _powerPlanFeature.SetState((PowerPlan)balancedMode_cmbBox.SelectedItem);
                break;

                case PowerModeState.Performance:
                    _powerPlanFeature.SetState((PowerPlan)performanceMode_cmbBox.SelectedItem);
                break;
                
                default:
                    // NOP
                break;
            }
        }
    }
}
