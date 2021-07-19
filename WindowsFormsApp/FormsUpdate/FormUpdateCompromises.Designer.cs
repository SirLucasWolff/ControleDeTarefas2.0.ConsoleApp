
namespace WindowsFormsApp
{
    partial class FormUpdateCompromises
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewUpdate = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compromiseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindOfCompromiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBCompromiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSet = new WindowsFormsApp.DBTarefasDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dBCompromiseTableAdapter = new WindowsFormsApp.DBTarefasDataSetTableAdapters.DBCompromiseTableAdapter();
            this.txtUpdatedCompromise = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBCompromiseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBTarefasDataSet1 = new WindowsFormsApp.DBTarefasDataSet1();
            this.dBCompromiseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCompromiseTableAdapter1 = new WindowsFormsApp.DBTarefasDataSet1TableAdapters.DBCompromiseTableAdapter();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(367, 582);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 53);
            this.btnUpdate.TabIndex = 76;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNewUpdate);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Location = new System.Drawing.Point(11, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 100);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(33, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "New update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(105, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Id";
            // 
            // txtNewUpdate
            // 
            this.txtNewUpdate.Location = new System.Drawing.Point(139, 58);
            this.txtNewUpdate.Name = "txtNewUpdate";
            this.txtNewUpdate.Size = new System.Drawing.Size(364, 22);
            this.txtNewUpdate.TabIndex = 1;
            this.txtNewUpdate.TextChanged += new System.EventHandler(this.txtNewUpdate_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 22);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Location = new System.Drawing.Point(705, 409);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 61);
            this.button6.TabIndex = 74;
            this.button6.Text = "END HOUR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(539, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 61);
            this.button5.TabIndex = 73;
            this.button5.Text = "START HOUR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(373, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 61);
            this.button3.TabIndex = 71;
            this.button3.Text = "SPOT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(207, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 61);
            this.button1.TabIndex = 70;
            this.button1.Text = "SUBJECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 46);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(368, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "SELECT WHAT WISH TO EDIT:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.spotDataGridViewTextBoxColumn,
            this.compromiseDateDataGridViewTextBoxColumn,
            this.startHourDataGridViewTextBoxColumn,
            this.endHourDataGridViewTextBoxColumn,
            this.kindOfCompromiseDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dBCompromiseBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(26, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1029, 235);
            this.dataGridView2.TabIndex = 68;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // spotDataGridViewTextBoxColumn
            // 
            this.spotDataGridViewTextBoxColumn.DataPropertyName = "Spot";
            this.spotDataGridViewTextBoxColumn.HeaderText = "Spot";
            this.spotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spotDataGridViewTextBoxColumn.Name = "spotDataGridViewTextBoxColumn";
            this.spotDataGridViewTextBoxColumn.Width = 125;
            // 
            // compromiseDateDataGridViewTextBoxColumn
            // 
            this.compromiseDateDataGridViewTextBoxColumn.DataPropertyName = "Compromise Date";
            this.compromiseDateDataGridViewTextBoxColumn.HeaderText = "Compromise Date";
            this.compromiseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compromiseDateDataGridViewTextBoxColumn.Name = "compromiseDateDataGridViewTextBoxColumn";
            this.compromiseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // startHourDataGridViewTextBoxColumn
            // 
            this.startHourDataGridViewTextBoxColumn.DataPropertyName = "Start hour";
            this.startHourDataGridViewTextBoxColumn.HeaderText = "Start hour";
            this.startHourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startHourDataGridViewTextBoxColumn.Name = "startHourDataGridViewTextBoxColumn";
            this.startHourDataGridViewTextBoxColumn.Width = 125;
            // 
            // endHourDataGridViewTextBoxColumn
            // 
            this.endHourDataGridViewTextBoxColumn.DataPropertyName = "End hour";
            this.endHourDataGridViewTextBoxColumn.HeaderText = "End hour";
            this.endHourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endHourDataGridViewTextBoxColumn.Name = "endHourDataGridViewTextBoxColumn";
            this.endHourDataGridViewTextBoxColumn.Width = 125;
            // 
            // kindOfCompromiseDataGridViewTextBoxColumn
            // 
            this.kindOfCompromiseDataGridViewTextBoxColumn.DataPropertyName = "Kind of compromise";
            this.kindOfCompromiseDataGridViewTextBoxColumn.HeaderText = "Kind of compromise";
            this.kindOfCompromiseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kindOfCompromiseDataGridViewTextBoxColumn.Name = "kindOfCompromiseDataGridViewTextBoxColumn";
            this.kindOfCompromiseDataGridViewTextBoxColumn.Width = 125;
            // 
            // dBCompromiseBindingSource
            // 
            this.dBCompromiseBindingSource.DataMember = "DBCompromise";
            this.dBCompromiseBindingSource.DataSource = this.dBTarefasDataSet;
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
            this.button2.Location = new System.Drawing.Point(520, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 53);
            this.button2.TabIndex = 67;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnUpdateBackScreenCompromise_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 261);
            this.dataGridView1.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 75);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(138, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATING THE COMPROMISES";
            // 
            // dBCompromiseTableAdapter
            // 
            this.dBCompromiseTableAdapter.ClearBeforeFill = true;
            // 
            // txtUpdatedCompromise
            // 
            this.txtUpdatedCompromise.AutoSize = true;
            this.txtUpdatedCompromise.ForeColor = System.Drawing.Color.Green;
            this.txtUpdatedCompromise.Location = new System.Drawing.Point(12, 618);
            this.txtUpdatedCompromise.Name = "txtUpdatedCompromise";
            this.txtUpdatedCompromise.Size = new System.Drawing.Size(174, 17);
            this.txtUpdatedCompromise.TabIndex = 77;
            this.txtUpdatedCompromise.Text = "COMPROMISE UPDATED!";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView3.DataSource = this.dBCompromiseBindingSource2;
            this.dataGridView3.Location = new System.Drawing.Point(26, 103);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(1029, 235);
            this.dataGridView3.TabIndex = 78;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Spot";
            this.dataGridViewTextBoxColumn3.HeaderText = "Spot";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Compromise Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Compromise Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Start hour";
            this.dataGridViewTextBoxColumn5.HeaderText = "Start hour";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "End hour";
            this.dataGridViewTextBoxColumn6.HeaderText = "End hour";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Kind of compromise";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kind of compromise";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dBCompromiseBindingSource1
            // 
            this.dBCompromiseBindingSource1.DataMember = "DBCompromise";
            this.dBCompromiseBindingSource1.DataSource = this.dBTarefasDataSet;
            // 
            // dBTarefasDataSet1
            // 
            this.dBTarefasDataSet1.DataSetName = "DBTarefasDataSet1";
            this.dBTarefasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBCompromiseBindingSource2
            // 
            this.dBCompromiseBindingSource2.DataMember = "DBCompromise";
            this.dBCompromiseBindingSource2.DataSource = this.dBTarefasDataSet1;
            // 
            // dBCompromiseTableAdapter1
            // 
            this.dBCompromiseTableAdapter1.ClearBeforeFill = true;
            // 
            // FormUpdateCompromises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 645);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.txtUpdatedCompromise);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUpdateCompromises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateCompromises";
            this.Load += new System.EventHandler(this.FormUpdateCompromises_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCompromiseBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DBTarefasDataSet dBTarefasDataSet;
        private System.Windows.Forms.BindingSource dBCompromiseBindingSource;
        private DBTarefasDataSetTableAdapters.DBCompromiseTableAdapter dBCompromiseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compromiseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindOfCompromiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label txtUpdatedCompromise;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource dBCompromiseBindingSource1;
        private DBTarefasDataSet1 dBTarefasDataSet1;
        private System.Windows.Forms.BindingSource dBCompromiseBindingSource2;
        private DBTarefasDataSet1TableAdapters.DBCompromiseTableAdapter dBCompromiseTableAdapter1;
    }
}