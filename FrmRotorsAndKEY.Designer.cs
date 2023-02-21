namespace Enigma
{
    partial class FrmRotorsAndKEY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRotorsAndKEY));
            this.dsEnigmaChallenges = new Enigma.DsEnigmaChallenges();
            this.dtRotorsAndKEYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtRotorsAndKEYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dtRotorsAndKEYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnExitScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsLabelInfo = new System.Windows.Forms.ToolStripLabel();
            this.DgvDtRotorsAndKEY = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reflectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotorLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotorMiddleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotorRightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cipherKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plugsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cipherTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BGWCipher = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnigmaChallenges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRotorsAndKEYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRotorsAndKEYBindingNavigator)).BeginInit();
            this.dtRotorsAndKEYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDtRotorsAndKEY)).BeginInit();
            this.SuspendLayout();
            // 
            // dsEnigmaChallenges
            // 
            this.dsEnigmaChallenges.DataSetName = "DsEnigmaChallenges";
            this.dsEnigmaChallenges.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtRotorsAndKEYBindingSource
            // 
            this.dtRotorsAndKEYBindingSource.DataMember = "dtRotorsAndKEY";
            this.dtRotorsAndKEYBindingSource.DataSource = this.dsEnigmaChallenges;
            // 
            // dtRotorsAndKEYBindingNavigator
            // 
            this.dtRotorsAndKEYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dtRotorsAndKEYBindingNavigator.BindingSource = this.dtRotorsAndKEYBindingSource;
            this.dtRotorsAndKEYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dtRotorsAndKEYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dtRotorsAndKEYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dtRotorsAndKEYBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.TsBtnExitScan,
            this.toolStripSeparator3,
            this.TsLabelInfo});
            this.dtRotorsAndKEYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dtRotorsAndKEYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dtRotorsAndKEYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dtRotorsAndKEYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dtRotorsAndKEYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dtRotorsAndKEYBindingNavigator.Name = "dtRotorsAndKEYBindingNavigator";
            this.dtRotorsAndKEYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dtRotorsAndKEYBindingNavigator.Size = new System.Drawing.Size(1143, 25);
            this.dtRotorsAndKEYBindingNavigator.TabIndex = 0;
            this.dtRotorsAndKEYBindingNavigator.Text = "bindingNavigator1";
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
            // dtRotorsAndKEYBindingNavigatorSaveItem
            // 
            this.dtRotorsAndKEYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dtRotorsAndKEYBindingNavigatorSaveItem.Enabled = false;
            this.dtRotorsAndKEYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dtRotorsAndKEYBindingNavigatorSaveItem.Image")));
            this.dtRotorsAndKEYBindingNavigatorSaveItem.Name = "dtRotorsAndKEYBindingNavigatorSaveItem";
            this.dtRotorsAndKEYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dtRotorsAndKEYBindingNavigatorSaveItem.Text = "Save Data";
            this.dtRotorsAndKEYBindingNavigatorSaveItem.Click += new System.EventHandler(this.DtRotorsAndKEYBindingNavigatorSaveItem_Click);
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
            this.TsLabelInfo.Name = "TsLabelInfo";
            this.TsLabelInfo.Size = new System.Drawing.Size(0, 22);
            // 
            // DgvDtRotorsAndKEY
            // 
            this.DgvDtRotorsAndKEY.AutoGenerateColumns = false;
            this.DgvDtRotorsAndKEY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDtRotorsAndKEY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iOCDataGridViewTextBoxColumn,
            this.reflectorDataGridViewTextBoxColumn,
            this.rotorLeftDataGridViewTextBoxColumn,
            this.rotorMiddleDataGridViewTextBoxColumn,
            this.rotorRightDataGridViewTextBoxColumn,
            this.cipherKEYDataGridViewTextBoxColumn,
            this.plugsDataGridViewTextBoxColumn,
            this.messageTextDataGridViewTextBoxColumn,
            this.cipherTextDataGridViewTextBoxColumn});
            this.DgvDtRotorsAndKEY.DataSource = this.dtRotorsAndKEYBindingSource;
            this.DgvDtRotorsAndKEY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDtRotorsAndKEY.Location = new System.Drawing.Point(0, 25);
            this.DgvDtRotorsAndKEY.Name = "DgvDtRotorsAndKEY";
            this.DgvDtRotorsAndKEY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvDtRotorsAndKEY.Size = new System.Drawing.Size(1143, 598);
            this.DgvDtRotorsAndKEY.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // iOCDataGridViewTextBoxColumn
            // 
            this.iOCDataGridViewTextBoxColumn.DataPropertyName = "IOC";
            this.iOCDataGridViewTextBoxColumn.HeaderText = "IOC";
            this.iOCDataGridViewTextBoxColumn.Name = "iOCDataGridViewTextBoxColumn";
            this.iOCDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iOCDataGridViewTextBoxColumn.Width = 40;
            // 
            // reflectorDataGridViewTextBoxColumn
            // 
            this.reflectorDataGridViewTextBoxColumn.DataPropertyName = "Reflector";
            this.reflectorDataGridViewTextBoxColumn.HeaderText = "Reflector";
            this.reflectorDataGridViewTextBoxColumn.Name = "reflectorDataGridViewTextBoxColumn";
            this.reflectorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reflectorDataGridViewTextBoxColumn.Width = 60;
            // 
            // rotorLeftDataGridViewTextBoxColumn
            // 
            this.rotorLeftDataGridViewTextBoxColumn.DataPropertyName = "RotorLeft";
            this.rotorLeftDataGridViewTextBoxColumn.HeaderText = "Rotor left";
            this.rotorLeftDataGridViewTextBoxColumn.Name = "rotorLeftDataGridViewTextBoxColumn";
            this.rotorLeftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rotorLeftDataGridViewTextBoxColumn.Width = 40;
            // 
            // rotorMiddleDataGridViewTextBoxColumn
            // 
            this.rotorMiddleDataGridViewTextBoxColumn.DataPropertyName = "RotorMiddle";
            this.rotorMiddleDataGridViewTextBoxColumn.HeaderText = "Rotor middle";
            this.rotorMiddleDataGridViewTextBoxColumn.Name = "rotorMiddleDataGridViewTextBoxColumn";
            this.rotorMiddleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rotorMiddleDataGridViewTextBoxColumn.Width = 40;
            // 
            // rotorRightDataGridViewTextBoxColumn
            // 
            this.rotorRightDataGridViewTextBoxColumn.DataPropertyName = "RotorRight";
            this.rotorRightDataGridViewTextBoxColumn.HeaderText = "Rotor right";
            this.rotorRightDataGridViewTextBoxColumn.Name = "rotorRightDataGridViewTextBoxColumn";
            this.rotorRightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rotorRightDataGridViewTextBoxColumn.Width = 40;
            // 
            // cipherKEYDataGridViewTextBoxColumn
            // 
            this.cipherKEYDataGridViewTextBoxColumn.DataPropertyName = "CipherKEY";
            this.cipherKEYDataGridViewTextBoxColumn.HeaderText = "Cipher KEY";
            this.cipherKEYDataGridViewTextBoxColumn.Name = "cipherKEYDataGridViewTextBoxColumn";
            this.cipherKEYDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cipherKEYDataGridViewTextBoxColumn.Width = 50;
            // 
            // plugsDataGridViewTextBoxColumn
            // 
            this.plugsDataGridViewTextBoxColumn.DataPropertyName = "Plugs";
            this.plugsDataGridViewTextBoxColumn.HeaderText = "Plugs";
            this.plugsDataGridViewTextBoxColumn.Name = "plugsDataGridViewTextBoxColumn";
            this.plugsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // messageTextDataGridViewTextBoxColumn
            // 
            this.messageTextDataGridViewTextBoxColumn.DataPropertyName = "MessageText";
            this.messageTextDataGridViewTextBoxColumn.HeaderText = "Message text";
            this.messageTextDataGridViewTextBoxColumn.Name = "messageTextDataGridViewTextBoxColumn";
            this.messageTextDataGridViewTextBoxColumn.Width = 345;
            // 
            // cipherTextDataGridViewTextBoxColumn
            // 
            this.cipherTextDataGridViewTextBoxColumn.DataPropertyName = "CipherText";
            this.cipherTextDataGridViewTextBoxColumn.HeaderText = "Cipher text";
            this.cipherTextDataGridViewTextBoxColumn.Name = "cipherTextDataGridViewTextBoxColumn";
            this.cipherTextDataGridViewTextBoxColumn.Width = 345;
            // 
            // BGWCipher
            // 
            this.BGWCipher.WorkerReportsProgress = true;
            this.BGWCipher.WorkerSupportsCancellation = true;
            this.BGWCipher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWCipher_DoWork);
            this.BGWCipher.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWCipher_ProgressChanged);
            this.BGWCipher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWCipher_RunWorkerCompleted);
            // 
            // FrmRotorsAndKEY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 623);
            this.ControlBox = false;
            this.Controls.Add(this.DgvDtRotorsAndKEY);
            this.Controls.Add(this.dtRotorsAndKEYBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRotorsAndKEY";
            this.Load += new System.EventHandler(this.FrmRotorsAndKEY_Load);
            this.Resize += new System.EventHandler(this.FrmRotorsAndKEY_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dsEnigmaChallenges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRotorsAndKEYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRotorsAndKEYBindingNavigator)).EndInit();
            this.dtRotorsAndKEYBindingNavigator.ResumeLayout(false);
            this.dtRotorsAndKEYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDtRotorsAndKEY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsEnigmaChallenges dsEnigmaChallenges;
        private System.Windows.Forms.BindingSource dtRotorsAndKEYBindingSource;
        private System.Windows.Forms.BindingNavigator dtRotorsAndKEYBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dtRotorsAndKEYBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton TsBtnStartScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TsBtnExitScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel TsLabelInfo;
        private System.Windows.Forms.DataGridView DgvDtRotorsAndKEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reflectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotorLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotorMiddleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotorRightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cipherKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plugsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cipherTextDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker BGWCipher;
    }
}