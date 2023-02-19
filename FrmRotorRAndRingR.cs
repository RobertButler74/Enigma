using Enigma.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class FrmRotorRAndRingR : Form
    {

        private readonly string enigmaXmlFilePath = "RotorRAndRingR.xml";
        int _width;

        public static GroupBox ownerGBX;

        public FrmRotorRAndRingR()
        {
            InitializeComponent();
        }

        private void FrmRotorRAndRingR_Load(object sender, EventArgs e)
        {
            _width = this.ClientSize.Width;

            if (File.Exists(enigmaXmlFilePath))
            {
                dsEnigmaChallenges.ReadXml(enigmaXmlFilePath);
                TsBtnStartScan.Enabled = false;
                TsBtnExitScan.Enabled = true;
            }
            else
            {
                TsBtnStartScan.Enabled = true;
            }
        }

        private void FrmRotorRAndRingR_Resize(object sender, EventArgs e)
        {
            if (_width != this.ClientSize.Width && _width != 0)
            {
                Int32 widthDifference = this.ClientSize.Width - _width;
                DataGridViewColumn column;

                column = DgvDtRotorRAndRingR.Columns[11];
                column.Width += widthDifference / 2;
                column = DgvDtRotorRAndRingR.Columns[12];
                column.Width += widthDifference / 2;
            }
            _width = this.ClientSize.Width;
        }

        private void TsBtnStartScan_Click(object sender, EventArgs e)
        {
            if ((string)TsBtnStartScan.Tag == "Start")
            {
                TsBtnStartScan.Image = Resources.power_green;
                TsBtnStartScan.Tag = "Stop";
                TsBtnStartScan.Enabled = false;
                TsBtnExitScan.Enabled = false;
                BGWCipher.RunWorkerAsync();
            }
        }

        private void TsBtnStartScan_MouseEnter(object sender, EventArgs e)
        {
            if ((string)TsBtnStartScan.Tag == "Start")
            {
                TsBtnStartScan.Image = Resources.power_green;
            }
        }

        private void TsBtnStartScan_MouseLeave(object sender, EventArgs e)
        {
            if ((string)TsBtnStartScan.Tag == "Start")
            {
                TsBtnStartScan.Image = Resources.power_grey;
            }
        }

        private void DtRotorRAndRingRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                dtRotorRAndRingRBindingSource.EndEdit();
                dsEnigmaChallenges.WriteXml(enigmaXmlFilePath);

                TsLabelInfo.ForeColor = Color.Green;
                TsLabelInfo.Font = new Font("Segoe UI", 9);
                TsLabelInfo.Text = "Records saved successfully";
                dtRotorRAndRingRBindingNavigator.Refresh();
                dtRotorRAndRingRBindingNavigator.Update();

                Thread.Sleep(5000);
                TsLabelInfo.ForeColor = Color.Black;
                TsLabelInfo.Text = "";
                dtRotorRAndRingRBindingNavigator.Refresh();
                dtRotorRAndRingRBindingNavigator.Update();
                dtRotorRAndRingRBindingNavigatorSaveItem.Enabled = false;
            }
            catch (Exception ex)
            {
                TsLabelInfo.ForeColor = Color.Red;
                TsLabelInfo.Font = new Font("Segoe UI", 9);
                TsLabelInfo.Text = "Something went wrong, your record was not saved.\t" + "Error: " + ex.Message;
                dtRotorRAndRingRBindingNavigator.Refresh();
                dtRotorRAndRingRBindingNavigator.Update();

                Thread.Sleep(5000);
                TsLabelInfo.ForeColor = Color.Black;
                TsLabelInfo.Text = "";
                dtRotorRAndRingRBindingNavigator.Refresh();
                dtRotorRAndRingRBindingNavigator.Update();
            }
        }

        private void TsBtnExitScan_Click(object sender, EventArgs e)
        {
            ownerGBX.Enabled = true;
            this.Close();
        }

        private void BGWCipher_DoWork(object sender, DoWorkEventArgs e)
        {
            Cipher.BGWCipher = BGWCipher;
            Challenge10Scans.RotorRAndRingR();
        }

        private void BGWCipher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string infoText = e.UserState.ToString();

            if (infoText.Substring(0, 3) == "dgv")
            {
                infoText = infoText.Substring(3);
                CreateDataGridViewDATA(infoText);
            }
            else if (infoText.Substring(0, 3) == "lbl")
            {
                infoText = infoText.Substring(3);
                TsLabelInfo.Font = new Font("FreeMono", 10, FontStyle.Bold);
                TsLabelInfo.Text = infoText;
            }
        }

        private void CreateDataGridViewDATA(string infoText)
        {
            string[] infoList = infoText.Split('|');

            DataTable table = this.dsEnigmaChallenges.Tables[1];

            DataRow myDataRow;
            myDataRow = table.NewRow();

            myDataRow["ref_ID"] = Convert.ToString(Cipher.intRefID);
            myDataRow["IoC"] = Cipher.intIoC;
            myDataRow["ref_IoC"] = Cipher.intRefIoC;
            myDataRow["IoCDifference"] = Cipher.IoCDiff;
            myDataRow["Reflector"] = infoList[0];
            myDataRow["RotorLeft"] = infoList[1];
            myDataRow["RotorMiddle"] = infoList[2];
            myDataRow["RotorRight"] = infoList[3];
            myDataRow["CipherKEY"] = infoList[4];
            myDataRow["Plugs"] = infoList[5];
            myDataRow["MessageText"] = infoList[6];
            myDataRow["CipherText"] = infoList[7];

            this.dsEnigmaChallenges.Tables[1].Rows.Add(myDataRow);
            dtRotorRAndRingRBindingNavigatorSaveItem.Enabled = true;
        }

        private void BGWCipher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TsBtnStartScan.Enabled = true;
            TsBtnExitScan.Enabled = true;
        }

        

    }
}
