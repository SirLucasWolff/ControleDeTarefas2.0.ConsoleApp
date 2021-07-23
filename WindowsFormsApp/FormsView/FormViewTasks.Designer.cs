
namespace WindowsFormsApp
{
    partial class FormViewTasks
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dBTaskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSet1 = new WindowsFormsApp.DBTarefasDataSet1();
            this.dBTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSet = new WindowsFormsApp.DBTarefasDataSet();
            this.dataSet1 = new System.Data.DataSet();
            this.DBTasks = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dBTaskTableAdapter = new WindowsFormsApp.DBTarefasDataSetTableAdapters.DBTaskTableAdapter();
            this.dBTaskTableAdapter1 = new WindowsFormsApp.DBTarefasDataSet1TableAdapters.DBTaskTableAdapter();
            this.dBTaskBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTaskBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importanceLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusionPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBTaskBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.txtCount = new System.Windows.Forms.Label();
            this.dBCompromiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCompromiseTableAdapter = new WindowsFormsApp.DBTarefasDataSetTableAdapters.DBCompromiseTableAdapter();
            this.advancedDataGridView2 = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(339, 433);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 43);
            this.button2.TabIndex = 38;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnViewBackScreenTask_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(791, 355);
            this.dataGridView1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(791, 61);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(179, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEWING THE TASKS";
            // 
            // dBTaskBindingSource1
            // 
            this.dBTaskBindingSource1.DataMember = "DBTask";
            this.dBTaskBindingSource1.DataSource = this.dBTarefasDataSet1;
            // 
            // dBTarefasDataSet1
            // 
            this.dBTarefasDataSet1.DataSetName = "DBTarefasDataSet1";
            this.dBTarefasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBTaskBindingSource
            // 
            this.dBTaskBindingSource.DataMember = "DBTask";
            this.dBTaskBindingSource.DataSource = this.dBTarefasDataSetBindingSource;
            this.dBTaskBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.dBTaskBindingSource_ListChanged);
            // 
            // dBTarefasDataSetBindingSource
            // 
            this.dBTarefasDataSetBindingSource.DataSource = this.dBTarefasDataSet;
            this.dBTarefasDataSetBindingSource.Position = 0;
            // 
            // dBTarefasDataSet
            // 
            this.dBTarefasDataSet.DataSetName = "DBTarefasDataSet";
            this.dBTarefasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.DBTasks});
            // 
            // DBTasks
            // 
            this.DBTasks.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.DBTasks.TableName = "DBTasks";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "ID";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "TASK";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "CREATION DATE";
            this.dataColumn3.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "CONCLUSION DATE";
            this.dataColumn4.DataType = typeof(System.DateTime);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "IMPORTANCE LEVEL";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "CONCLUSION PERCENT";
            // 
            // dBTaskTableAdapter
            // 
            this.dBTaskTableAdapter.ClearBeforeFill = true;
            // 
            // dBTaskTableAdapter1
            // 
            this.dBTaskTableAdapter1.ClearBeforeFill = true;
            // 
            // dBTaskBindingSource3
            // 
            this.dBTaskBindingSource3.DataMember = "DBTask";
            this.dBTaskBindingSource3.DataSource = this.dBTarefasDataSet1BindingSource;
            // 
            // dBTarefasDataSet1BindingSource
            // 
            this.dBTarefasDataSet1BindingSource.DataSource = this.dBTarefasDataSet1;
            this.dBTarefasDataSet1BindingSource.Position = 0;
            // 
            // dBTaskBindingSource2
            // 
            this.dBTaskBindingSource2.DataMember = "DBTask";
            this.dBTaskBindingSource2.DataSource = this.dBTarefasDataSetBindingSource;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.taskDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.conclusionDateDataGridViewTextBoxColumn,
            this.importanceLevelDataGridViewTextBoxColumn,
            this.conclusionPercentDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.dBTaskBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(16, 82);
            this.advancedDataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(778, 311);
            this.advancedDataGridView1.TabIndex = 43;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskDataGridViewTextBoxColumn
            // 
            this.taskDataGridViewTextBoxColumn.DataPropertyName = "Task";
            this.taskDataGridViewTextBoxColumn.HeaderText = "Task";
            this.taskDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.taskDataGridViewTextBoxColumn.Name = "taskDataGridViewTextBoxColumn";
            this.taskDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.taskDataGridViewTextBoxColumn.Width = 125;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "Creation Date";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "Creation Date";
            this.creationDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.creationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // conclusionDateDataGridViewTextBoxColumn
            // 
            this.conclusionDateDataGridViewTextBoxColumn.DataPropertyName = "Conclusion Date";
            this.conclusionDateDataGridViewTextBoxColumn.HeaderText = "Conclusion Date";
            this.conclusionDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.conclusionDateDataGridViewTextBoxColumn.Name = "conclusionDateDataGridViewTextBoxColumn";
            this.conclusionDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.conclusionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // importanceLevelDataGridViewTextBoxColumn
            // 
            this.importanceLevelDataGridViewTextBoxColumn.DataPropertyName = "Importance Level";
            this.importanceLevelDataGridViewTextBoxColumn.HeaderText = "Importance Level";
            this.importanceLevelDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.importanceLevelDataGridViewTextBoxColumn.Name = "importanceLevelDataGridViewTextBoxColumn";
            this.importanceLevelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.importanceLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // conclusionPercentDataGridViewTextBoxColumn
            // 
            this.conclusionPercentDataGridViewTextBoxColumn.DataPropertyName = "Conclusion Percent";
            this.conclusionPercentDataGridViewTextBoxColumn.HeaderText = "Conclusion Percent";
            this.conclusionPercentDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.conclusionPercentDataGridViewTextBoxColumn.Name = "conclusionPercentDataGridViewTextBoxColumn";
            this.conclusionPercentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.conclusionPercentDataGridViewTextBoxColumn.Width = 125;
            // 
            // dBTaskBindingSource4
            // 
            this.dBTaskBindingSource4.DataMember = "DBTask";
            this.dBTaskBindingSource4.DataSource = this.dBTarefasDataSet1BindingSource;
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCount.Location = new System.Drawing.Point(365, 404);
            this.txtCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(62, 13);
            this.txtCount.TabIndex = 44;
            this.txtCount.Text = "0: TASKS";
            // 
            // dBCompromiseBindingSource
            // 
            this.dBCompromiseBindingSource.DataMember = "DBCompromise";
            this.dBCompromiseBindingSource.DataSource = this.dBTarefasDataSetBindingSource;
            // 
            // dBCompromiseTableAdapter
            // 
            this.dBCompromiseTableAdapter.ClearBeforeFill = true;
            // 
            // advancedDataGridView2
            // 
            this.advancedDataGridView2.AutoGenerateContextFilters = true;
            this.advancedDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.advancedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView2.DateWithTime = false;
            this.advancedDataGridView2.Location = new System.Drawing.Point(16, 82);
            this.advancedDataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            this.advancedDataGridView2.RowHeadersWidth = 51;
            this.advancedDataGridView2.RowTemplate.Height = 24;
            this.advancedDataGridView2.Size = new System.Drawing.Size(778, 311);
            this.advancedDataGridView2.TabIndex = 45;
            this.advancedDataGridView2.TimeFilter = false;
            // 
            // FormViewTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 483);
            this.Controls.Add(this.advancedDataGridView2);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormViewTasks";
            this.Text = "FormViewTasks";
            this.Load += new System.EventHandler(this.FormViewTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTaskBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable DBTasks;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.BindingSource dBTarefasDataSetBindingSource;
        private DBTarefasDataSet dBTarefasDataSet;
        private System.Windows.Forms.BindingSource dBTaskBindingSource;
        private DBTarefasDataSetTableAdapters.DBTaskTableAdapter dBTaskTableAdapter;
        private DBTarefasDataSet1 dBTarefasDataSet1;
        private System.Windows.Forms.BindingSource dBTaskBindingSource1;
        private DBTarefasDataSet1TableAdapters.DBTaskTableAdapter dBTaskTableAdapter1;
        private System.Windows.Forms.BindingSource dBTaskBindingSource2;
        private System.Windows.Forms.BindingSource dBTarefasDataSet1BindingSource;
        private System.Windows.Forms.BindingSource dBTaskBindingSource3;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importanceLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusionPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dBTaskBindingSource4;
        private System.Windows.Forms.Label txtCount;
        private System.Windows.Forms.BindingSource dBCompromiseBindingSource;
        private DBTarefasDataSetTableAdapters.DBCompromiseTableAdapter dBCompromiseTableAdapter;
        private ADGV.AdvancedDataGridView advancedDataGridView2;
    }
}