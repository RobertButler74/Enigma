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
                FrmRotorsAndKEY.ownerGBX = GbxScanSelection;
            }
            else if (RbtnRotorRAndRingR.Checked)
            {
                frmTemp = new FrmRotorRAndRingR();
                FrmRotorRAndRingR.ownerGBX = GbxScanSelection;
            }
            else if (RbtnRotorMAndRingM.Checked)
            {
                frmTemp = new FrmRotorMAndRingM();
                FrmRotorMAndRingM.ownerGBX = GbxScanSelection;
            }
            else
            {
                string plugNumber = GbxScanSelection.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
                int intPlugNumber = Convert.ToInt32(plugNumber.Substring(8));
                CreatePlugForm(frmTemp, intPlugNumber);
                return;
            }
            /*
             * Made for maybe later. Bruteforce all rotors, rings, rotor position and plugs,
             * to match the given cipher KEY = EDF => unknown => GTX.
             * Since the Enigma is reversible ciphering to, that means if the uknown KEY gives thew result of,
             * 'GTX' that could be the solution to solve the challange.
             * But that would be just with 2 reflectors('B' or 'C'), 5 rotors('I', 'II', 'III', 'IV', 'V') and 10 plugs,
             * 317 925 110 435 653 000 000 quintillion(trillioner) possibilities.
             * If we use 8 rotors 1,78 sextillion(trilarder)
             * 
             * */
            //else if (RbtnKEYs.Checked)
            //{
            //    //frmTemp = new FrmKEYs();
            //}

            OpenScan(frmTemp);                        
        }

        private void OpenScan(Form frmTemp)
        {
            frmTemp.TopLevel = false;
            frmTemp.AutoScroll = true;
            frmTemp.Dock = DockStyle.Fill;
            this.PnlDGV.Controls.Add(frmTemp);
            GbxScanSelection.Enabled = false;
            frmTemp.Show();
        }

        private void CreatePlugForm(Form frmTemp, int _intPlugNumber)
        {
            frmTemp = new FrmPlugs();
            FrmPlugs.ownerGBX = GbxScanSelection;
            FrmPlugs.intPlugNumber = _intPlugNumber;
            OpenScan(frmTemp);
        }

        private void BtnTestPlugs_Click(object sender, EventArgs e)
        {
            //EnigmaMachine.SetPlugs(1, 2);
        }
    }
}
