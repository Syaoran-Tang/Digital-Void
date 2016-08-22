namespace Digital_Void
{
    partial class EntityManager
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EM_New = new System.Windows.Forms.Button();
            this.EM_Delete = new System.Windows.Forms.Button();
            this.EM_Name = new System.Windows.Forms.Label();
            this.EM_PositionX = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.EM_PositionY = new System.Windows.Forms.TextBox();
            this.EM_PositionZ = new System.Windows.Forms.TextBox();
            this.EM_VelocityZ = new System.Windows.Forms.TextBox();
            this.EM_VelocityY = new System.Windows.Forms.TextBox();
            this.EM_VelocityX = new System.Windows.Forms.TextBox();
            this.EM_Radius = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EM_Mass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EM_Save = new System.Windows.Forms.Button();
            this.listDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempDataSet = new Digital_Void.TempDataSet();
            this.listTableAdapter = new Digital_Void.TempDataSetTableAdapters.ListTableAdapter();
            this.tableAdapterManager = new Digital_Void.TempDataSetTableAdapters.TableAdapterManager();
            this.EMBackGroundWorker = new System.ComponentModel.BackgroundWorker();
            this.data1TableAdapter = new Digital_Void.TempDataSetTableAdapters.Data1TableAdapter();
            this.data2TableAdapter = new Digital_Void.TempDataSetTableAdapters.Data2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "实体\r\n信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "位置\r\n矢量";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "速度\r\n矢量";
            // 
            // EM_New
            // 
            this.EM_New.Location = new System.Drawing.Point(12, 355);
            this.EM_New.Name = "EM_New";
            this.EM_New.Size = new System.Drawing.Size(70, 25);
            this.EM_New.TabIndex = 5;
            this.EM_New.Text = "新增实体";
            this.EM_New.UseVisualStyleBackColor = true;
            this.EM_New.Click += new System.EventHandler(this.EM_New_Click);
            // 
            // EM_Delete
            // 
            this.EM_Delete.Location = new System.Drawing.Point(88, 355);
            this.EM_Delete.Name = "EM_Delete";
            this.EM_Delete.Size = new System.Drawing.Size(70, 25);
            this.EM_Delete.TabIndex = 6;
            this.EM_Delete.Text = "删除实体";
            this.EM_Delete.UseVisualStyleBackColor = true;
            this.EM_Delete.Click += new System.EventHandler(this.EM_Delete_Click);
            // 
            // EM_Name
            // 
            this.EM_Name.AutoSize = true;
            this.EM_Name.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EM_Name.Location = new System.Drawing.Point(59, 17);
            this.EM_Name.Name = "EM_Name";
            this.EM_Name.Size = new System.Drawing.Size(88, 16);
            this.EM_Name.TabIndex = 8;
            this.EM_Name.Text = "未选中实体";
            // 
            // EM_PositionX
            // 
            this.EM_PositionX.Location = new System.Drawing.Point(73, 87);
            this.EM_PositionX.Margin = new System.Windows.Forms.Padding(1);
            this.EM_PositionX.Multiline = true;
            this.EM_PositionX.Name = "EM_PositionX";
            this.EM_PositionX.ReadOnly = true;
            this.EM_PositionX.Size = new System.Drawing.Size(85, 15);
            this.EM_PositionX.TabIndex = 15;
            this.EM_PositionX.WordWrap = false;
            // 
            // EM_PositionY
            // 
            this.EM_PositionY.Location = new System.Drawing.Point(73, 104);
            this.EM_PositionY.Margin = new System.Windows.Forms.Padding(1);
            this.EM_PositionY.Multiline = true;
            this.EM_PositionY.Name = "EM_PositionY";
            this.EM_PositionY.ReadOnly = true;
            this.EM_PositionY.Size = new System.Drawing.Size(85, 15);
            this.EM_PositionY.TabIndex = 16;
            this.EM_PositionY.WordWrap = false;
            // 
            // EM_PositionZ
            // 
            this.EM_PositionZ.Location = new System.Drawing.Point(73, 121);
            this.EM_PositionZ.Margin = new System.Windows.Forms.Padding(1);
            this.EM_PositionZ.Multiline = true;
            this.EM_PositionZ.Name = "EM_PositionZ";
            this.EM_PositionZ.ReadOnly = true;
            this.EM_PositionZ.Size = new System.Drawing.Size(85, 15);
            this.EM_PositionZ.TabIndex = 17;
            this.EM_PositionZ.WordWrap = false;
            // 
            // EM_VelocityZ
            // 
            this.EM_VelocityZ.Location = new System.Drawing.Point(73, 177);
            this.EM_VelocityZ.Margin = new System.Windows.Forms.Padding(1);
            this.EM_VelocityZ.Multiline = true;
            this.EM_VelocityZ.Name = "EM_VelocityZ";
            this.EM_VelocityZ.ReadOnly = true;
            this.EM_VelocityZ.Size = new System.Drawing.Size(84, 15);
            this.EM_VelocityZ.TabIndex = 20;
            this.EM_VelocityZ.WordWrap = false;
            // 
            // EM_VelocityY
            // 
            this.EM_VelocityY.Location = new System.Drawing.Point(73, 160);
            this.EM_VelocityY.Margin = new System.Windows.Forms.Padding(1);
            this.EM_VelocityY.Multiline = true;
            this.EM_VelocityY.Name = "EM_VelocityY";
            this.EM_VelocityY.ReadOnly = true;
            this.EM_VelocityY.Size = new System.Drawing.Size(84, 15);
            this.EM_VelocityY.TabIndex = 19;
            this.EM_VelocityY.WordWrap = false;
            // 
            // EM_VelocityX
            // 
            this.EM_VelocityX.Location = new System.Drawing.Point(73, 143);
            this.EM_VelocityX.Margin = new System.Windows.Forms.Padding(1);
            this.EM_VelocityX.Multiline = true;
            this.EM_VelocityX.Name = "EM_VelocityX";
            this.EM_VelocityX.ReadOnly = true;
            this.EM_VelocityX.Size = new System.Drawing.Size(84, 15);
            this.EM_VelocityX.TabIndex = 18;
            this.EM_VelocityX.WordWrap = false;
            // 
            // EM_Radius
            // 
            this.EM_Radius.Location = new System.Drawing.Point(83, 49);
            this.EM_Radius.Margin = new System.Windows.Forms.Padding(1);
            this.EM_Radius.Multiline = true;
            this.EM_Radius.Name = "EM_Radius";
            this.EM_Radius.ReadOnly = true;
            this.EM_Radius.Size = new System.Drawing.Size(74, 15);
            this.EM_Radius.TabIndex = 21;
            this.EM_Radius.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(47, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "半径";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(47, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "质量";
            // 
            // EM_Mass
            // 
            this.EM_Mass.Location = new System.Drawing.Point(83, 66);
            this.EM_Mass.Margin = new System.Windows.Forms.Padding(1);
            this.EM_Mass.Multiline = true;
            this.EM_Mass.Name = "EM_Mass";
            this.EM_Mass.ReadOnly = true;
            this.EM_Mass.Size = new System.Drawing.Size(74, 15);
            this.EM_Mass.TabIndex = 24;
            this.EM_Mass.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(57, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 48);
            this.label1.TabIndex = 25;
            this.label1.Text = "X\r\nY\r\nZ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(57, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 48);
            this.label7.TabIndex = 26;
            this.label7.Text = "X\r\nY\r\nZ";
            // 
            // EM_Save
            // 
            this.EM_Save.Location = new System.Drawing.Point(12, 386);
            this.EM_Save.Name = "EM_Save";
            this.EM_Save.Size = new System.Drawing.Size(146, 25);
            this.EM_Save.TabIndex = 28;
            this.EM_Save.Text = "保存全部修改";
            this.EM_Save.UseVisualStyleBackColor = true;
            this.EM_Save.Click += new System.EventHandler(this.EM_Save_Click);
            // 
            // listDataGridView
            // 
            this.listDataGridView.AllowUserToAddRows = false;
            this.listDataGridView.AllowUserToDeleteRows = false;
            this.listDataGridView.AllowUserToResizeColumns = false;
            this.listDataGridView.AllowUserToResizeRows = false;
            this.listDataGridView.AutoGenerateColumns = false;
            this.listDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.listDataGridView.DataSource = this.listBindingSource;
            this.listDataGridView.Location = new System.Drawing.Point(12, 196);
            this.listDataGridView.MultiSelect = false;
            this.listDataGridView.Name = "listDataGridView";
            this.listDataGridView.RowHeadersVisible = false;
            this.listDataGridView.RowTemplate.Height = 23;
            this.listDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listDataGridView.Size = new System.Drawing.Size(145, 153);
            this.listDataGridView.TabIndex = 28;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 30;
            // 
            // listBindingSource
            // 
            this.listBindingSource.DataMember = "List";
            this.listBindingSource.DataSource = this.tempDataSet;
            // 
            // tempDataSet
            // 
            this.tempDataSet.DataSetName = "TempDataSet";
            this.tempDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listTableAdapter
            // 
            this.listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Data1TableAdapter = null;
            this.tableAdapterManager.Data2TableAdapter = null;
            this.tableAdapterManager.ListTableAdapter = this.listTableAdapter;
            this.tableAdapterManager.UpdateOrder = Digital_Void.TempDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // EMBackGroundWorker
            // 
            this.EMBackGroundWorker.WorkerReportsProgress = true;
            this.EMBackGroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EMBackGroundWorker_DoWork);
            this.EMBackGroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.EMBackGroundWorker_ProgressChanged);
            this.EMBackGroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EMBackGroundWorker_RunWorkerCompleted);
            // 
            // data1TableAdapter
            // 
            this.data1TableAdapter.ClearBeforeFill = true;
            // 
            // data2TableAdapter
            // 
            this.data2TableAdapter.ClearBeforeFill = true;
            // 
            // EntityManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(169, 417);
            this.Controls.Add(this.listDataGridView);
            this.Controls.Add(this.EM_Save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EM_Mass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EM_Radius);
            this.Controls.Add(this.EM_VelocityZ);
            this.Controls.Add(this.EM_VelocityY);
            this.Controls.Add(this.EM_VelocityX);
            this.Controls.Add(this.EM_PositionZ);
            this.Controls.Add(this.EM_PositionY);
            this.Controls.Add(this.EM_PositionX);
            this.Controls.Add(this.EM_Name);
            this.Controls.Add(this.EM_Delete);
            this.Controls.Add(this.EM_New);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntityManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "实体管理";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EntityManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EM_Name;
        private System.Windows.Forms.TextBox EM_PositionX;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox EM_PositionY;
        private System.Windows.Forms.TextBox EM_PositionZ;
        private System.Windows.Forms.TextBox EM_VelocityZ;
        private System.Windows.Forms.TextBox EM_VelocityY;
        private System.Windows.Forms.TextBox EM_VelocityX;
        private System.Windows.Forms.TextBox EM_Radius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EM_Mass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private TempDataSet tempDataSet;
        private TempDataSetTableAdapters.ListTableAdapter listTableAdapter;
        private TempDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView listDataGridView;
        private System.Windows.Forms.BindingSource listBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker EMBackGroundWorker;
        private TempDataSetTableAdapters.Data1TableAdapter data1TableAdapter;
        private TempDataSetTableAdapters.Data2TableAdapter data2TableAdapter;
        public System.Windows.Forms.Button EM_New;
        public System.Windows.Forms.Button EM_Delete;
        public System.Windows.Forms.Button EM_Save;
    }
}