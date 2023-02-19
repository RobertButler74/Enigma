namespace Enigma
{
    partial class FrmEnigma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PnlSelection = new System.Windows.Forms.Panel();
            this.GbxScanSelection = new System.Windows.Forms.GroupBox();
            this.BtnOpenScan = new System.Windows.Forms.Button();
            this.RbtnRotorsAndKEY = new System.Windows.Forms.RadioButton();
            this.RbtnRotorRAndRingR = new System.Windows.Forms.RadioButton();
            this.RbtnRotorMAndRingM = new System.Windows.Forms.RadioButton();
            this.RbtnKEYs = new System.Windows.Forms.RadioButton();
            this.PbxEnigma = new System.Windows.Forms.PictureBox();
            this.PnlDGV = new System.Windows.Forms.Panel();
            this.PnlSelection.SuspendLayout();
            this.GbxScanSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEnigma)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1434, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PnlSelection
            // 
            this.PnlSelection.Controls.Add(this.GbxScanSelection);
            this.PnlSelection.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSelection.Location = new System.Drawing.Point(0, 50);
            this.PnlSelection.Name = "PnlSelection";
            this.PnlSelection.Size = new System.Drawing.Size(275, 639);
            this.PnlSelection.TabIndex = 2;
            // 
            // GbxScanSelection
            // 
            this.GbxScanSelection.Controls.Add(this.RbtnKEYs);
            this.GbxScanSelection.Controls.Add(this.RbtnRotorMAndRingM);
            this.GbxScanSelection.Controls.Add(this.RbtnRotorRAndRingR);
            this.GbxScanSelection.Controls.Add(this.RbtnRotorsAndKEY);
            this.GbxScanSelection.Controls.Add(this.BtnOpenScan);
            this.GbxScanSelection.Location = new System.Drawing.Point(12, 6);
            this.GbxScanSelection.Name = "GbxScanSelection";
            this.GbxScanSelection.Size = new System.Drawing.Size(257, 156);
            this.GbxScanSelection.TabIndex = 0;
            this.GbxScanSelection.TabStop = false;
            this.GbxScanSelection.Text = "Scan selection";
            // 
            // BtnOpenScan
            // 
            this.BtnOpenScan.Location = new System.Drawing.Point(6, 19);
            this.BtnOpenScan.Name = "BtnOpenScan";
            this.BtnOpenScan.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenScan.TabIndex = 0;
            this.BtnOpenScan.Text = "Open scan";
            this.BtnOpenScan.UseVisualStyleBackColor = true;
            this.BtnOpenScan.Click += new System.EventHandler(this.BtnOpenScan_Click);
            // 
            // RbtnRotorsAndKEY
            // 
            this.RbtnRotorsAndKEY.AutoSize = true;
            this.RbtnRotorsAndKEY.Checked = true;
            this.RbtnRotorsAndKEY.Location = new System.Drawing.Point(6, 48);
            this.RbtnRotorsAndKEY.Name = "RbtnRotorsAndKEY";
            this.RbtnRotorsAndKEY.Size = new System.Drawing.Size(175, 17);
            this.RbtnRotorsAndKEY.TabIndex = 1;
            this.RbtnRotorsAndKEY.TabStop = true;
            this.RbtnRotorsAndKEY.Text = "Scan the rotors and Cipher KEY";
            this.RbtnRotorsAndKEY.UseVisualStyleBackColor = true;
            // 
            // RbtnRotorRAndRingR
            // 
            this.RbtnRotorRAndRingR.AutoSize = true;
            this.RbtnRotorRAndRingR.Location = new System.Drawing.Point(6, 71);
            this.RbtnRotorRAndRingR.Name = "RbtnRotorRAndRingR";
            this.RbtnRotorRAndRingR.Size = new System.Drawing.Size(187, 17);
            this.RbtnRotorRAndRingR.TabIndex = 2;
            this.RbtnRotorRAndRingR.Text = "Scan the fast rotor and ring setting";
            this.RbtnRotorRAndRingR.UseVisualStyleBackColor = true;
            // 
            // RbtnRotorMAndRingM
            // 
            this.RbtnRotorMAndRingM.AutoSize = true;
            this.RbtnRotorMAndRingM.Location = new System.Drawing.Point(6, 94);
            this.RbtnRotorMAndRingM.Name = "RbtnRotorMAndRingM";
            this.RbtnRotorMAndRingM.Size = new System.Drawing.Size(200, 17);
            this.RbtnRotorMAndRingM.TabIndex = 3;
            this.RbtnRotorMAndRingM.Text = "Scan the middle rotor and ring setting";
            this.RbtnRotorMAndRingM.UseVisualStyleBackColor = true;
            // 
            // RbtnKEYs
            // 
            this.RbtnKEYs.AutoSize = true;
            this.RbtnKEYs.Location = new System.Drawing.Point(6, 133);
            this.RbtnKEYs.Name = "RbtnKEYs";
            this.RbtnKEYs.Size = new System.Drawing.Size(79, 17);
            this.RbtnKEYs.TabIndex = 4;
            this.RbtnKEYs.Text = "Scan KEYs";
            this.RbtnKEYs.UseVisualStyleBackColor = true;
            // 
            // PbxEnigma
            // 
            this.PbxEnigma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.PbxEnigma.BackgroundImage = global::Enigma.Properties.Resources._114x50_Enigma_logo;
            this.PbxEnigma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxEnigma.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbxEnigma.Location = new System.Drawing.Point(0, 0);
            this.PbxEnigma.Name = "PbxEnigma";
            this.PbxEnigma.Size = new System.Drawing.Size(1434, 50);
            this.PbxEnigma.TabIndex = 0;
            this.PbxEnigma.TabStop = false;
            // 
            // PnlDGV
            // 
            this.PnlDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDGV.Location = new System.Drawing.Point(275, 50);
            this.PnlDGV.Name = "PnlDGV";
            this.PnlDGV.Size = new System.Drawing.Size(1159, 639);
            this.PnlDGV.TabIndex = 3;
            // 
            // FrmEnigma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 711);
            this.Controls.Add(this.PnlDGV);
            this.Controls.Add(this.PnlSelection);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PbxEnigma);
            this.Name = "FrmEnigma";
            this.Text = "Enigma";
            this.Load += new System.EventHandler(this.FrmEnigma_Load);
            this.PnlSelection.ResumeLayout(false);
            this.GbxScanSelection.ResumeLayout(false);
            this.GbxScanSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEnigma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxEnigma;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel PnlSelection;
        private System.Windows.Forms.GroupBox GbxScanSelection;
        private System.Windows.Forms.RadioButton RbtnKEYs;
        private System.Windows.Forms.RadioButton RbtnRotorMAndRingM;
        private System.Windows.Forms.RadioButton RbtnRotorRAndRingR;
        private System.Windows.Forms.RadioButton RbtnRotorsAndKEY;
        private System.Windows.Forms.Button BtnOpenScan;
        private System.Windows.Forms.Panel PnlDGV;
    }
}

