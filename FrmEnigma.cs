using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class FrmEnigma : Form
    {
        public FrmEnigma()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var area = Screen.AllScreens.Length > 1 ? Screen.AllScreens[1].WorkingArea : Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point((area.Width - this.Width) / 2, (area.Height - this.Height) / 2);
            base.OnLoad(e);
        }

        private void FrmEnigma_Load(object sender, EventArgs e)
        {

        }

        private void BtnOpenScan_Click(object sender, EventArgs e)
        {
            BasicSetup();
        }

        private void BasicSetup()
        {

            Form frmTemp = new Form();

            if (RbtnRotorsAndKEY.Checked)
            {
                frmTemp = new FrmRotorsAndKEY();
            }
            else if (RbtnRotorRAndRingR.Checked)
            {
                //frmTemp = new FrmRotorRAndRingR();
            }
            else if (RbtnRotorMAndRingM.Checked)
            {
                //frmTemp = new FrmRotorMAndRingM();
            }
            else if (RbtnKEYs.Checked)
            {
                //frmTemp = new FrmKEYs();
            }

            frmTemp.TopLevel = false;
            frmTemp.AutoScroll = true;
            frmTemp.Dock = DockStyle.Fill;
            this.PnlDGV.Controls.Add(frmTemp);
            GbxScanSelection.Enabled = false;
            frmTemp.Show();
            GbxScanSelection.Enabled = true;

        }
    }
}
