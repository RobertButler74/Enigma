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
    public partial class FrmRotorsAndKEY : Form
    {

        private readonly string enigmaXmlFilePath = "RotorsAndKEY.xml";
        int _width;

        public static GroupBox ownerGBX;

        public FrmRotorsAndKEY()
        {
            InitializeComponent();
        }

        private void FrmRotorsAndKEY_Load(object sender, EventArgs e)
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
                SetData.enigmaXmlFilePath = enigmaXmlFilePath;
                SetData.dgv = DgvDtRotorsAndKEY;
            }            
        }

        private void FrmRotorsAndKEY_Resize(object sender, EventArgs e)
        {
            if (_width != this.ClientSize.Width && _width != 0)
            {
                Int32 widthDifference = this.ClientSize.Width - _width;
                DataGridViewColumn column;

                column = DgvDtRotorsAndKEY.Columns[8];
                column.Width += widthDifference / 2;
                column = DgvDtRotorsAndKEY.Columns[9];
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

        private void DtRotorsAndKEYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                dtRotorsAndKEYBindingSource.EndEdit();
                dsEnigmaChallenges.WriteXml(enigmaXmlFilePath);

                TsLabelInfo.ForeColor = Color.Green;
                TsLabelInfo.Font = new Font("Segoe UI", 9);
                TsLabelInfo.Text = "Records saved successfully";
                dtRotorsAndKEYBindingNavigator.Refresh();
                dtRotorsAndKEYBindingNavigator.Update();

                Thread.Sleep(5000);
                TsLabelInfo.ForeColor = Color.Black;
                TsLabelInfo.Text = "";
                dtRotorsAndKEYBindingNavigator.Refresh();
                dtRotorsAndKEYBindingNavigator.Update();
                dtRotorsAndKEYBindingNavigatorSaveItem.Enabled = false;
            }
            catch (Exception ex)
            {
                TsLabelInfo.ForeColor = Color.Red;
                TsLabelInfo.Font = new Font("Segoe UI", 9);
                TsLabelInfo.Text = "Something went wrong, your record was not saved.\t" + "Error: " + ex.Message;
                dtRotorsAndKEYBindingNavigator.Refresh();
                dtRotorsAndKEYBindingNavigator.Update();

                Thread.Sleep(5000);
                TsLabelInfo.ForeColor = Color.Black;
                TsLabelInfo.Text = "";
                dtRotorsAndKEYBindingNavigator.Refresh();
                dtRotorsAndKEYBindingNavigator.Update();
            }
        }

        private void TsBtnExitScan_Click(object sender, EventArgs e)
        {
            ownerGBX.Enabled= true;
            this.Close();
        }

        private void BGWCipher_DoWork(object sender, DoWorkEventArgs e)
        {
            Cipher.BGWCipher = BGWCipher;
            Challenge10Scans.RotorsAndKEY();
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

            DataTable table = this.dsEnigmaChallenges.Tables[0];

            DataRow myDataRow;
            myDataRow = table.NewRow();

            myDataRow["IoC"] = Cipher.intIoC;
            myDataRow["Reflector"] = infoList[0];
            myDataRow["RotorLeft"] = infoList[1];
            myDataRow["RotorMiddle"] = infoList[2];
            myDataRow["RotorRight"] = infoList[3];
            myDataRow["CipherKEY"] = infoList[4];
            myDataRow["Plugs"] = infoList[5];
            myDataRow["MessageText"] = infoList[6];
            myDataRow["CipherText"] = infoList[7];

            this.dsEnigmaChallenges.Tables[0].Rows.Add(myDataRow);
            dtRotorsAndKEYBindingNavigatorSaveItem.Enabled = true;
        }

        private void BGWCipher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TsBtnStartScan.Enabled = true;
            TsBtnExitScan.Enabled = true;
        }
    }
}
