
namespace WindowsFormsApp
{
    partial class FormViewCompromises
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
            this.dBCompromiseBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSet1 = new WindowsFormsApp.DBTarefasDataSet1();
            this.dBCompromiseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCompromiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSet = new WindowsFormsApp.DBTarefasDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dBCompromiseTableAdapter = new WindowsFormsApp.DBTarefasDataSetTableAdapters.DBCompromiseTableAdapter();
            this.dBCompromiseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCompromiseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCompromiseTableAdapter1 = new WindowsFormsApp.DBTarefasDataSet1TableAdapters.DBCompromiseTableAdapter();
            this.txtCompromises = new System.Windows.Forms.Label();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compromiseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindOfCompromiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advancedDataGridView2 = new ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dBCompromiseBindingSource4
            // 
            this.dBCompromiseBindingSource4.DataMember = "DBCompromise";
            this.dBCompromiseBindingSource4.DataSource = this.dBTarefasDataSet1BindingSource;
            // 
            // dBTarefasDataSet1BindingSource
            // 
            this.dBTarefasDataSet1BindingSource.DataSource = this.dBTarefasDataSet1;
            this.dBTarefasDataSet1BindingSource.Position = 0;
            // 
            // dBTarefasDataSet1
            // 
            this.dBTarefasDataSet1.DataSetName = "DBTarefasDataSet1";
            this.dBTarefasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBCompromiseBindingSource3
            // 
            this.dBCompromiseBindingSource3.DataMember = "DBCompromise";
            this.dBCompromiseBindingSource3.DataSource = this.dBTarefasDataSet1BindingSource;
            // 
            // dBCompromiseBindingSource
            // 
            this.dBCompromiseBindingSource.DataMember = "DBCompromise";
            this.dBCompromiseBindingSource.DataSource = this.dBTarefasDataSetBindingSource;
            this.dBCompromiseBindingSource.CurrentChanged += new System.EventHandler(this.dBCompromiseBindingSource4_CurrentChanged);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(451, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 53);
            this.button2.TabIndex = 48;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnViewBackScreenCompromise_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 437);
            this.dataGridView1.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 75);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(151, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEWING THE COMPROMISES";
            // 
            // dBCompromiseTableAdapter
            // 
            this.dBCompromiseTableAdapter.ClearBeforeFill = true;
            // 
            // dBCompromiseBindingSource1
            // 
            this.dBCompromiseBindingSource1.DataMember = "DBCompromise";
            this.dBCompromiseBindingSource1.DataSource = this.dBTarefasDataSetBindingSource;
            // 
            // dBCompromiseBindingSource2
            // 
            this.dBCompromiseBindingSource2.DataMember = "DBCompromise";
            this.dBCompromiseBindingSource2.DataSource = this.dBTarefasDataSetBindingSource;
            // 
            // dBCompromiseTableAdapter1
            // 
            this.dBCompromiseTableAdapter1.ClearBeforeFill = true;
            // 
            // txtCompromises
            // 
            this.txtCompromises.AutoSize = true;
            this.txtCompromises.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompromises.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCompromises.Location = new System.Drawing.Point(458, 492);
            this.txtCompromises.Name = "txtCompromises";
            this.txtCompromises.Size = new System.Drawing.Size(140, 17);
            this.txtCompromises.TabIndex = 50;
            this.txtCompromises.Text = "0: COMPROMISES";
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.spotDataGridViewTextBoxColumn,
            this.compromiseDateDataGridViewTextBoxColumn,
            this.startHourDataGridViewTextBoxColumn,
            this.endHourDataGridViewTextBoxColumn,
            this.kindOfCompromiseDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.dBCompromiseBindingSource4;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(21, 101);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(1034, 379);
            this.advancedDataGridView1.TabIndex = 51;
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
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.subjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // spotDataGridViewTextBoxColumn
            // 
            this.spotDataGridViewTextBoxColumn.DataPropertyName = "Spot";
            this.spotDataGridViewTextBoxColumn.HeaderText = "Spot";
            this.spotDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.spotDataGridViewTextBoxColumn.Name = "spotDataGridViewTextBoxColumn";
            this.spotDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.spotDataGridViewTextBoxColumn.Width = 125;
            // 
            // compromiseDateDataGridViewTextBoxColumn
            // 
            this.compromiseDateDataGridViewTextBoxColumn.DataPropertyName = "Compromise Date";
            this.compromiseDateDataGridViewTextBoxColumn.HeaderText = "Compromise Date";
            this.compromiseDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.compromiseDateDataGridViewTextBoxColumn.Name = "compromiseDateDataGridViewTextBoxColumn";
            this.compromiseDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.compromiseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // startHourDataGridViewTextBoxColumn
            // 
            this.startHourDataGridViewTextBoxColumn.DataPropertyName = "Start hour";
            this.startHourDataGridViewTextBoxColumn.HeaderText = "Start hour";
            this.startHourDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.startHourDataGridViewTextBoxColumn.Name = "startHourDataGridViewTextBoxColumn";
            this.startHourDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.startHourDataGridViewTextBoxColumn.Width = 125;
            // 
            // endHourDataGridViewTextBoxColumn
            // 
            this.endHourDataGridViewTextBoxColumn.DataPropertyName = "End hour";
            this.endHourDataGridViewTextBoxColumn.HeaderText = "End hour";
            this.endHourDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.endHourDataGridViewTextBoxColumn.Name = "endHourDataGridViewTextBoxColumn";
            this.endHourDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.endHourDataGridViewTextBoxColumn.Width = 125;
            // 
            // kindOfCompromiseDataGridViewTextBoxColumn
            // 
            this.kindOfCompromiseDataGridViewTextBoxColumn.DataPropertyName = "Kind of compromise";
            this.kindOfCompromiseDataGridViewTextBoxColumn.HeaderText = "Kind of compromise";
            this.kindOfCompromiseDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.kindOfCompromiseDataGridViewTextBoxColumn.Name = "kindOfCompromiseDataGridViewTextBoxColumn";
            this.kindOfCompromiseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.kindOfCompromiseDataGridViewTextBoxColumn.Width = 125;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.linkDataGridViewTextBoxColumn.Width = 125;
            // 
            // advancedDataGridView2
            // 
            this.advancedDataGridView2.AutoGenerateColumns = false;
            this.advancedDataGridView2.AutoGenerateContextFilters = true;
            this.advancedDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.advancedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.advancedDataGridView2.DataSource = this.dBCompromiseBindingSource4;
            this.advancedDataGridView2.DateWithTime = false;
            this.advancedDataGridView2.Location = new System.Drawing.Point(21, 101);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            this.advancedDataGridView2.RowHeadersWidth = 51;
            this.advancedDataGridView2.RowTemplate.Height = 24;
            this.advancedDataGridView2.Size = new System.Drawing.Size(1034, 379);
            this.advancedDataGridView2.TabIndex = 52;
            this.advancedDataGridView2.TimeFilter = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Spot";
            this.dataGridViewTextBoxColumn3.HeaderText = "Spot";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Compromise Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Compromise Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Start hour";
            this.dataGridViewTextBoxColumn5.HeaderText = "Start hour";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "End hour";
            this.dataGridViewTextBoxColumn6.HeaderText = "End hour";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Kind of compromise";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kind of compromise";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Link";
            this.dataGridViewTextBoxColumn8.HeaderText = "Link";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // FormViewCompromises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 589);
            this.Controls.Add(this.advancedDataGridView2);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.txtCompromises);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormViewCompromises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewCompromises";
            this.Load += new System.EventHandler(this.FormViewCompromises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dBTarefasDataSetBindingSource;
        private DBTarefasDataSet dBTarefasDataSet;
        private System.Windows.Forms.BindingSource dBCompromiseBindingSource;
        private DBTarefasDataSetTableAdapters.DBCompromiseTableAdapter dBCompromiseTableAdapter;
        private System.Windows.Forms.BindingSource dBTarefasDataSet1BindingSource;
        private DBTarefasDataSet1 dBTarefasDataSet1;
        private System.Windows.Forms.BindingSource dBCompromiseBindingSource1;
        private System.Windows.Forms.BindingSource dBCompromiseBindingSource2;
        private System.Windows.Forms.BindingSource dBCompromiseBindingSource3;
        private DBTarefasDataSet1TableAdapters.DBCompromiseTableAdapter dBCompromiseTableAdapter1;
        private System.Windows.Forms.BindingSource dBCompromiseBindingSource4;
        private System.Windows.Forms.Label txtCompromises;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compromiseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindOfCompromiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private ADGV.AdvancedDataGridView advancedDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}