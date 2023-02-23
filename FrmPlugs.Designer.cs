namespace Enigma
{
    partial class FrmPlugs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlugs));
            this.dsEnigmaChallenges = new Enigma.DsEnigmaChallenges();
            this.dtPlugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPlugsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.TsBtnStartScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtPlugsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnExitScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsLabelInfo = new System.Windows.Forms.ToolStripLabel();
            this.DgvDtPlugs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BGWCipher = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnigmaChallenges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlugsBindingNavigator)).BeginInit();
            this.dtPlugsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDtPlugs)).BeginInit();
            this.SuspendLayout();
            // 
            // dsEnigmaChallenges
            // 
            this.dsEnigmaChallenges.DataSetName = "DsEnigmaChallenges";
            this.dsEnigmaChallenges.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPlugsBindingSource
            // 
            this.dtPlugsBindingSource.DataMember = "dtPlugs";
            this.dtPlugsBindingSource.DataSource = this.dsEnigmaChallenges;
            // 
            // dtPlugsBindingNavigator
            // 
            this.dtPlugsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dtPlugsBindingNavigator.BindingSource = this.dtPlugsBindingSource;
            this.dtPlugsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dtPlugsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dtPlugsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnStartScan,
            this.toolStripSeparator1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dtPlugsBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.TsBtnExitScan,
            this.toolStripSeparator3,
            this.TsLabelInfo});
            this.dtPlugsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dtPlugsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dtPlugsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dtPlugsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dtPlugsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dtPlugsBindingNavigator.Name = "dtPlugsBindingNavigator";
            this.dtPlugsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dtPlugsBindingNavigator.Size = new System.Drawing.Size(1143, 25);
            this.dtPlugsBindingNavigator.TabIndex = 0;
            this.dtPlugsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // TsBtnStartScan
            // 
            this.TsBtnStartScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsBtnStartScan.Image = global::Enigma.Properties.Resources.power_grey;
            this.TsBtnStartScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnStartScan.Name = "TsBtnStartScan";
            this.TsBtnStartScan.Size = new System.Drawing.Size(23, 22);
            this.TsBtnStartScan.Tag = "Start";
            this.TsBtnStartScan.ToolTipText = "Start scan";
            this.TsBtnStartScan.Click += new System.EventHandler(this.TsBtnStartScan_Click);
            this.TsBtnStartScan.MouseEnter += new System.EventHandler(this.TsBtnStartScan_MouseEnter);
            this.TsBtnStartScan.MouseLeave += new System.EventHandler(this.TsBtnStartScan_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dtPlugsBindingNavigatorSaveItem
            // 
            this.dtPlugsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dtPlugsBindingNavigatorSaveItem.Enabled = false;
            this.dtPlugsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dtPlugsBindingNavigatorSaveItem.Image")));
            this.dtPlugsBindingNavigatorSaveItem.Name = "dtPlugsBindingNavigatorSaveItem";
            this.dtPlugsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dtPlugsBindingNavigatorSaveItem.Text = "Save Data";
            this.dtPlugsBindingNavigatorSaveItem.Click += new System.EventHandler(this.DtPlugsBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TsBtnExitScan
            // 
            this.TsBtnExitScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsBtnExitScan.ForeColor = System.Drawing.Color.Red;
            this.TsBtnExitScan.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnExitScan.Image")));
            this.TsBtnExitScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnExitScan.Name = "TsBtnExitScan";
            this.TsBtnExitScan.Size = new System.Drawing.Size(30, 22);
            this.TsBtnExitScan.Text = "Exit";
            this.TsBtnExitScan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TsBtnExitScan.ToolTipText = "Exit scan";
            this.TsBtnExitScan.Click += new System.EventHandler(this.TsBtnExitScan_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TsLabelInfo
            // 
            this.TsLabelInfo.Font = new System.Drawing.Font("FreeMono", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsLabelInfo.Name = "TsLabelInfo";
            this.TsLabelInfo.Size = new System.Drawing.Size(0, 22);
            // 
            // DgvDtPlugs
            // 
            this.DgvDtPlugs.AutoGenerateColumns = false;
            this.DgvDtPlugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDtPlugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.DgvDtPlugs.DataSource = this.dtPlugsBindingSource;
            this.DgvDtPlugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDtPlugs.Location = new System.Drawing.Point(0, 25);
            this.DgvDtPlugs.Name = "DgvDtPlugs";
            this.DgvDtPlugs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvDtPlugs.Size = new System.Drawing.Size(1143, 598);
            this.DgvDtPlugs.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ref_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ref. ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IOC";
            this.dataGridViewTextBoxColumn3.HeaderText = "IOC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ref_IOC";
            this.dataGridViewTextBoxColumn4.HeaderText = "ref. IOC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IOCDifference";
            this.dataGridViewTextBoxColumn5.HeaderText = "IOC diff.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Reflector";
            this.dataGridViewTextBoxColumn6.HeaderText = "Reflector";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RotorLeft";
            this.dataGridViewTextBoxColumn7.HeaderText = "Rotor left";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RotorMiddle";
            this.dataGridViewTextBoxColumn8.HeaderText = "Rotor middle";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 40;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RotorRight";
            this.dataGridViewTextBoxColumn9.HeaderText = "Rotor right";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CipherKEY";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cipher KEY";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Plugs";
            this.dataGridViewTextBoxColumn11.HeaderText = "Plugs";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MessageText";
            this.dataGridViewTextBoxColumn12.HeaderText = "Message text";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 285;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CipherText";
            this.dataGridViewTextBoxColumn13.HeaderText = "Cipher text";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 285;
            // 
            // BGWCipher
            // 
            this.BGWCipher.WorkerReportsProgress = true;
            this.BGWCipher.WorkerSupportsCancellation = true;
            this.BGWCipher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWCipher_DoWork);
            this.BGWCipher.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWCipher_ProgressChanged);
            this.BGWCipher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWCipher_RunWorkerCompleted);
            // 
            // FrmPlugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 623);
            this.ControlBox = false;
            this.Controls.Add(this.DgvDtPlugs);
            this.Controls.Add(this.dtPlugsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPlugs";
            this.Load += new System.EventHandler(this.FrmPlugs_Load);
            this.Resize += new System.EventHandler(this.FrmPlugs_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dsEnigmaChallenges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlugsBindingNavigator)).EndInit();
            this.dtPlugsBindingNavigator.ResumeLayout(false);
            this.dtPlugsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDtPlugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsEnigmaChallenges dsEnigmaChallenges;
        private System.Windows.Forms.BindingSource dtPlugsBindingSource;
        private System.Windows.Forms.BindingNavigator dtPlugsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dtPlugsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView DgvDtPlugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.ToolStripButton TsBtnStartScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TsBtnExitScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.ComponentModel.BackgroundWorker BGWCipher;
        public System.Windows.Forms.ToolStripLabel TsLabelInfo;
    }
}