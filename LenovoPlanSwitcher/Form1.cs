using LenovoPlanSwitcher.Features;
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

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_powerModeFeature.GetState().ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
