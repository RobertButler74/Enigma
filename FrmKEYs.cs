using Enigma.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class FrmKEYs : Form
    {

        private string enigmaXmlFilePath = "KEYs.xml";
        int _width;

        public static GroupBox ownerGBX;
        public static int intPlugNumber;

        public FrmKEYs()
        {
            InitializeComponent();
        }

        private void FrmKEYs_Load(object sender, EventArgs e)
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

        private void FrmKEYs_Resize(object sender, EventArgs e)
        {
            if (_width != this.ClientSize.Width && _width != 0)
            {
                Int32 widthDifference = this.ClientSize.Width - _width;
                DataGridViewColumn column;

                column = DgvDtKEYs.Columns[7];
                column.Width += widthDifference / 2;
                column = DgvDtKEYs.Columns[8];
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
                Cipher.tmpFrmKEYs = this;
                DoWork();
            }
        }

            private Task<bool> RunCipher()
            {
                TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                Task.Run(() =>
                {
                    Challenge10Scans.KEYs();
                    bool result = true;
                    tcs.SetResult(result);

                });

                return tcs.Task;
            }

        private async Task DoWork()
        {
            bool result = await RunCipher();
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

        private void DtKEYsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                dtKEYsBindingSource.EndEdit();
                dsEnigmaChallenges.WriteXml(enigmaXmlFilePath);

                TsLabelInfo.ForeColor = Color.Green;
                TsLabelInfo.Font = new Font("Segoe UI", 9);
                TsLabelInfo.Text = "Records saved successfully";
                dtKEYsBindingNavigator.Refresh();
                dtKEYsBindingNavigator.Update();

                Thread.Sleep(1500);
                TsLabelInfo.ForeColor = Color.Black;
                TsLabelInfo.Text = "";
                dtKEYsBindingNavigator.Refresh();
                dtKEYsBindingNavigator.Update();
                dtKEYsBindingNavigatorSaveItem.Enabled = false;
            }
            catch (Exception ex)
            {
                TsLabelInfo.ForeColor = Color.Red;
                TsLabelInfo.Font = new Font("Segoe UI", 9);
                TsLabelInfo.Text = "Something went wrong, your record was not saved.\t" + "Error: " + ex.Message;
                dtKEYsBindingNavigator.Refresh();
                dtKEYsBindingNavigator.Update();

                Thread.Sleep(1500);
                TsLabelInfo.ForeColor = Color.Black;
                TsLabelInfo.Text = "";
                dtKEYsBindingNavigator.Refresh();
                dtKEYsBindingNavigator.Update();
            }
        }

        private void TsBtnExitScan_Click(object sender, EventArgs e)
        {
            ownerGBX.Enabled = true;
            this.Close();
        }

        private void CreateDataGridViewDATA(string infoText)
        {
            string[] infoList = infoText.Split('|');

            DataTable table = this.dsEnigmaChallenges.Tables[4];

            DataRow myDataRow;
            myDataRow = table.NewRow();
            
            myDataRow["Reflector"] = infoList[0];
            myDataRow["RotorLeft"] = infoList[1];
            myDataRow["RotorMiddle"] = infoList[2];
            myDataRow["RotorRight"] = infoList[3];
            myDataRow["CipherKEY"] = infoList[4];
            myDataRow["Plugs"] = infoList[5];
            myDataRow["MessageText"] = infoList[6];
            myDataRow["CipherText"] = infoList[7];

            this.dsEnigmaChallenges.Tables[4].Rows.Add(myDataRow);
            if (dtKEYsBindingNavigator.InvokeRequired)
            {
                dtKEYsBindingNavigator.Invoke(new MethodInvoker(delegate { dtKEYsBindingNavigatorSaveItem.Enabled = true; }));
                dtKEYsBindingNavigator.Invoke(new MethodInvoker(delegate { bindingNavigatorMoveFirstItem.Invalidate(); }));
                dtKEYsBindingNavigator.Invoke(new MethodInvoker(delegate { dtKEYsBindingNavigator.Refresh(); }));
                Thread.Sleep(1);
            }

            if (DgvDtKEYs.InvokeRequired)
            {
                //DgvDtKEYs.Invoke(new MethodInvoker(delegate { DgvDtKEYs.Refresh(); }));
                DgvDtKEYs.Invoke(new MethodInvoker(delegate { dtKEYsBindingSource.ResetBindings(false); }));
                
                //DgvDtPlugs.Invoke(new MethodInvoker(delegate { DgvDtPlugs.Update(); }));
            }
        }

        public void ProgressChanged(string infoText)
        {
            if (infoText.Substring(0, 3) == "dgv")
            {
                infoText = infoText.Substring(3);
                CreateDataGridViewDATA(infoText);
            }
            else if (infoText.Substring(0, 3) == "lbl")
            {
                infoText = infoText.Substring(3);
                if (dtKEYsBindingNavigator.InvokeRequired)
                {
                    dtKEYsBindingNavigator.Invoke(new MethodInvoker(delegate { TsLabelInfo.Text = infoText; }));
                }
            }
        }

    }
}
