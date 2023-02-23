﻿namespace Enigma
{
    partial class FrmKEYs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKEYs));
            this.dsEnigmaChallenges = new Enigma.DsEnigmaChallenges();
            this.dtKEYsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtKEYsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dtKEYsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnExitScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsLabelInfo = new System.Windows.Forms.ToolStripLabel();
            this.DgvDtKEYs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnigmaChallenges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKEYsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKEYsBindingNavigator)).BeginInit();
            this.dtKEYsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDtKEYs)).BeginInit();
            this.SuspendLayout();
            // 
            // dsEnigmaChallenges
            // 
            this.dsEnigmaChallenges.DataSetName = "DsEnigmaChallenges";
            this.dsEnigmaChallenges.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtKEYsBindingSource
            // 
            this.dtKEYsBindingSource.DataMember = "dtKEYs";
            this.dtKEYsBindingSource.DataSource = this.dsEnigmaChallenges;
            // 
            // dtKEYsBindingNavigator
            // 
            this.dtKEYsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dtKEYsBindingNavigator.BindingSource = this.dtKEYsBindingSource;
            this.dtKEYsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dtKEYsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dtKEYsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dtKEYsBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.TsBtnExitScan,
            this.toolStripSeparator3,
            this.TsLabelInfo});
            this.dtKEYsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dtKEYsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dtKEYsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dtKEYsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dtKEYsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dtKEYsBindingNavigator.Name = "dtKEYsBindingNavigator";
            this.dtKEYsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dtKEYsBindingNavigator.Size = new System.Drawing.Size(1143, 25);
            this.dtKEYsBindingNavigator.TabIndex = 0;
            this.dtKEYsBindingNavigator.Text = "bindingNavigator1";
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
            // dtKEYsBindingNavigatorSaveItem
            // 
            this.dtKEYsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dtKEYsBindingNavigatorSaveItem.Enabled = false;
            this.dtKEYsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dtKEYsBindingNavigatorSaveItem.Image")));
            this.dtKEYsBindingNavigatorSaveItem.Name = "dtKEYsBindingNavigatorSaveItem";
            this.dtKEYsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dtKEYsBindingNavigatorSaveItem.Text = "Save Data";
            this.dtKEYsBindingNavigatorSaveItem.Click += new System.EventHandler(this.DtKEYsBindingNavigatorSaveItem_Click);
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
            this.TsLabelInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TsLabelInfo.Name = "TsLabelInfo";
            this.TsLabelInfo.Size = new System.Drawing.Size(0, 22);
            this.TsLabelInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // DgvDtKEYs
            // 
            this.DgvDtKEYs.AutoGenerateColumns = false;
            this.DgvDtKEYs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDtKEYs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.DgvDtKEYs.DataSource = this.dtKEYsBindingSource;
            this.DgvDtKEYs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDtKEYs.Location = new System.Drawing.Point(0, 25);
            this.DgvDtKEYs.Name = "DgvDtKEYs";
            this.DgvDtKEYs.Size = new System.Drawing.Size(1143, 598);
            this.DgvDtKEYs.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Reflector";
            this.dataGridViewTextBoxColumn2.HeaderText = "Reflector";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RotorLeft";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rotor left";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RotorMiddle";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rotor middle";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RotorRight";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rotor right";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CipherKEY";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cipher KEY";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Plugs";
            this.dataGridViewTextBoxColumn7.HeaderText = "Plugs";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MessageText";
            this.dataGridViewTextBoxColumn8.HeaderText = "MessageText";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CipherText";
            this.dataGridViewTextBoxColumn9.HeaderText = "CipherText";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // FrmKEYs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 623);
            this.ControlBox = false;
            this.Controls.Add(this.DgvDtKEYs);
            this.Controls.Add(this.dtKEYsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKEYs";
            this.Load += new System.EventHandler(this.FrmKEYs_Load);
            this.Resize += new System.EventHandler(this.FrmKEYs_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dsEnigmaChallenges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKEYsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKEYsBindingNavigator)).EndInit();
            this.dtKEYsBindingNavigator.ResumeLayout(false);
            this.dtKEYsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDtKEYs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsEnigmaChallenges dsEnigmaChallenges;
        private System.Windows.Forms.BindingSource dtKEYsBindingSource;
        private System.Windows.Forms.BindingNavigator dtKEYsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton TsBtnStartScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dtKEYsBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TsBtnExitScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel TsLabelInfo;
        private System.Windows.Forms.DataGridView DgvDtKEYs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}