namespace Access
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msRabota = new System.Windows.Forms.MenuStrip();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msStud = new System.Windows.Forms.ToolStripMenuItem();
            this.msWork = new System.Windows.Forms.ToolStripMenuItem();
            this.msFAC = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСПроцедурамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетВТабличнойФормеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетВСвободнойФормеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетСГруппировкойПоДвумТаблицамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dvFAC = new System.Windows.Forms.DataGridView();
            this.dvWork = new System.Windows.Forms.DataGridView();
            this.dvFIO = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sTUDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUD2dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUD3DNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wORKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SELHOZRABOTIDataSet = new Access.DB_SELHOZRABOTIDataSet();
            this.wORKIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zarplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACULTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIOTableAdapter = new Access.DB_SELHOZRABOTIDataSetTableAdapters.FIOTableAdapter();
            this.worksTableAdapter = new Access.DB_SELHOZRABOTIDataSetTableAdapters.WorksTableAdapter();
            this.fACTableAdapter = new Access.DB_SELHOZRABOTIDataSetTableAdapters.FACTableAdapter();
            this.report1 = new FastReport.Report();
            this.report2 = new FastReport.Report();
            this.report3 = new FastReport.Report();
            this.msRabota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvFIO)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SELHOZRABOTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report3)).BeginInit();
            this.SuspendLayout();
            // 
            // msRabota
            // 
            this.msRabota.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТаблицамиToolStripMenuItem,
            this.работаСПроцедурамиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.msRabota.Location = new System.Drawing.Point(0, 0);
            this.msRabota.Name = "msRabota";
            this.msRabota.Size = new System.Drawing.Size(917, 24);
            this.msRabota.TabIndex = 1;
            this.msRabota.Text = "menuStrip1";
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msStud,
            this.msWork,
            this.msFAC});
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.работаСТаблицамиToolStripMenuItem.Text = "Работа с таблицами";
            // 
            // msStud
            // 
            this.msStud.Name = "msStud";
            this.msStud.Size = new System.Drawing.Size(139, 22);
            this.msStud.Text = "Студенты";
            this.msStud.Click += new System.EventHandler(this.msStud_Click);
            // 
            // msWork
            // 
            this.msWork.Name = "msWork";
            this.msWork.Size = new System.Drawing.Size(139, 22);
            this.msWork.Text = "Работы";
            this.msWork.Click += new System.EventHandler(this.msWork_Click);
            // 
            // msFAC
            // 
            this.msFAC.Name = "msFAC";
            this.msFAC.Size = new System.Drawing.Size(139, 22);
            this.msFAC.Text = "Факультеты";
            this.msFAC.Click += new System.EventHandler(this.msFAC_Click);
            // 
            // работаСПроцедурамиToolStripMenuItem
            // 
            this.работаСПроцедурамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.процедура1ToolStripMenuItem,
            this.процедура2ToolStripMenuItem,
            this.процедура3ToolStripMenuItem});
            this.работаСПроцедурамиToolStripMenuItem.Name = "работаСПроцедурамиToolStripMenuItem";
            this.работаСПроцедурамиToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.работаСПроцедурамиToolStripMenuItem.Text = "Работа с процедурами";
            this.работаСПроцедурамиToolStripMenuItem.Click += new System.EventHandler(this.работаСПроцедурамиToolStripMenuItem_Click);
            // 
            // процедура1ToolStripMenuItem
            // 
            this.процедура1ToolStripMenuItem.Name = "процедура1ToolStripMenuItem";
            this.процедура1ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.процедура1ToolStripMenuItem.Text = "Процедура №1";
            this.процедура1ToolStripMenuItem.Click += new System.EventHandler(this.процедура1ToolStripMenuItem_Click);
            // 
            // процедура2ToolStripMenuItem
            // 
            this.процедура2ToolStripMenuItem.Name = "процедура2ToolStripMenuItem";
            this.процедура2ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.процедура2ToolStripMenuItem.Text = "Процедура №2";
            this.процедура2ToolStripMenuItem.Click += new System.EventHandler(this.процедура2ToolStripMenuItem_Click);
            // 
            // процедура3ToolStripMenuItem
            // 
            this.процедура3ToolStripMenuItem.Name = "процедура3ToolStripMenuItem";
            this.процедура3ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.процедура3ToolStripMenuItem.Text = "Процедура №3";
            this.процедура3ToolStripMenuItem.Click += new System.EventHandler(this.процедура3ToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетВТабличнойФормеToolStripMenuItem,
            this.отчетВСвободнойФормеToolStripMenuItem,
            this.отчетСГруппировкойПоДвумТаблицамToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчетВТабличнойФормеToolStripMenuItem
            // 
            this.отчетВТабличнойФормеToolStripMenuItem.Name = "отчетВТабличнойФормеToolStripMenuItem";
            this.отчетВТабличнойФормеToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.отчетВТабличнойФормеToolStripMenuItem.Text = "Отчет в табличной форме";
            this.отчетВТабличнойФормеToolStripMenuItem.Click += new System.EventHandler(this.отчетВТабличнойФормеToolStripMenuItem_Click);
            // 
            // отчетВСвободнойФормеToolStripMenuItem
            // 
            this.отчетВСвободнойФормеToolStripMenuItem.Name = "отчетВСвободнойФормеToolStripMenuItem";
            this.отчетВСвободнойФормеToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.отчетВСвободнойФормеToolStripMenuItem.Text = "Отчет в свободной форме";
            this.отчетВСвободнойФормеToolStripMenuItem.Click += new System.EventHandler(this.отчетВСвободнойФормеToolStripMenuItem_Click);
            // 
            // отчетСГруппировкойПоДвумТаблицамToolStripMenuItem
            // 
            this.отчетСГруппировкойПоДвумТаблицамToolStripMenuItem.Name = "отчетСГруппировкойПоДвумТаблицамToolStripMenuItem";
            this.отчетСГруппировкойПоДвумТаблицамToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.отчетСГруппировкойПоДвумТаблицамToolStripMenuItem.Text = "Отчет с группировкой по двум таблицам";
            this.отчетСГруппировкойПоДвумТаблицамToolStripMenuItem.Click += new System.EventHandler(this.отчетСГруппировкойПоДвумТаблицамToolStripMenuItem_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=WIN-9RQHM7VTVJV;Initial Catalog=DB_SELHOZRABOTI;Integrated Security=T" +
    "rue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dvFAC
            // 
            this.dvFAC.AllowUserToAddRows = false;
            this.dvFAC.AllowUserToDeleteRows = false;
            this.dvFAC.AutoGenerateColumns = false;
            this.dvFAC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvFAC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dvFAC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvFAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvFAC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fACIDDataGridViewTextBoxColumn1,
            this.fACULTDataGridViewTextBoxColumn});
            this.dvFAC.DataSource = this.fACBindingSource;
            this.dvFAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFAC.Location = new System.Drawing.Point(3, 361);
            this.dvFAC.Name = "dvFAC";
            this.dvFAC.ReadOnly = true;
            this.dvFAC.Size = new System.Drawing.Size(911, 159);
            this.dvFAC.TabIndex = 2;
            // 
            // dvWork
            // 
            this.dvWork.AllowUserToAddRows = false;
            this.dvWork.AllowUserToDeleteRows = false;
            this.dvWork.AutoGenerateColumns = false;
            this.dvWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvWork.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dvWork.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wORKIDDataGridViewTextBoxColumn1,
            this.workNameDataGridViewTextBoxColumn,
            this.zarplataDataGridViewTextBoxColumn});
            this.dvWork.DataSource = this.worksBindingSource;
            this.dvWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWork.Location = new System.Drawing.Point(3, 162);
            this.dvWork.Name = "dvWork";
            this.dvWork.ReadOnly = true;
            this.dvWork.Size = new System.Drawing.Size(911, 193);
            this.dvWork.TabIndex = 1;
            // 
            // dvFIO
            // 
            this.dvFIO.AllowUserToAddRows = false;
            this.dvFIO.AllowUserToDeleteRows = false;
            this.dvFIO.AutoGenerateColumns = false;
            this.dvFIO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvFIO.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dvFIO.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvFIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvFIO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUDIDDataGridViewTextBoxColumn,
            this.sTUD2dDataGridViewTextBoxColumn,
            this.sTUDNAMEDataGridViewTextBoxColumn,
            this.sTUD3DNAMEDataGridViewTextBoxColumn,
            this.fACIDDataGridViewTextBoxColumn,
            this.wORKIDDataGridViewTextBoxColumn});
            this.dvFIO.DataSource = this.fIOBindingSource;
            this.dvFIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFIO.Location = new System.Drawing.Point(3, 3);
            this.dvFIO.Name = "dvFIO";
            this.dvFIO.ReadOnly = true;
            this.dvFIO.Size = new System.Drawing.Size(911, 153);
            this.dvFIO.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dvFIO, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dvWork, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dvFAC, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.44398F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.05497F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.28964F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 523);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sTUDIDDataGridViewTextBoxColumn
            // 
            this.sTUDIDDataGridViewTextBoxColumn.DataPropertyName = "STUD_ID";
            this.sTUDIDDataGridViewTextBoxColumn.HeaderText = "STUD_ID";
            this.sTUDIDDataGridViewTextBoxColumn.Name = "sTUDIDDataGridViewTextBoxColumn";
            this.sTUDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUD2dDataGridViewTextBoxColumn
            // 
            this.sTUD2dDataGridViewTextBoxColumn.DataPropertyName = "STUD_2d";
            this.sTUD2dDataGridViewTextBoxColumn.HeaderText = "STUD_2d";
            this.sTUD2dDataGridViewTextBoxColumn.Name = "sTUD2dDataGridViewTextBoxColumn";
            this.sTUD2dDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUDNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUD_NAME";
            this.sTUDNAMEDataGridViewTextBoxColumn.HeaderText = "STUD_NAME";
            this.sTUDNAMEDataGridViewTextBoxColumn.Name = "sTUDNAMEDataGridViewTextBoxColumn";
            this.sTUDNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUD3DNAMEDataGridViewTextBoxColumn
            // 
            this.sTUD3DNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUD_3DNAME";
            this.sTUD3DNAMEDataGridViewTextBoxColumn.HeaderText = "STUD_3DNAME";
            this.sTUD3DNAMEDataGridViewTextBoxColumn.Name = "sTUD3DNAMEDataGridViewTextBoxColumn";
            this.sTUD3DNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fACIDDataGridViewTextBoxColumn
            // 
            this.fACIDDataGridViewTextBoxColumn.DataPropertyName = "FAC_ID";
            this.fACIDDataGridViewTextBoxColumn.HeaderText = "FAC_ID";
            this.fACIDDataGridViewTextBoxColumn.Name = "fACIDDataGridViewTextBoxColumn";
            this.fACIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wORKIDDataGridViewTextBoxColumn
            // 
            this.wORKIDDataGridViewTextBoxColumn.DataPropertyName = "WORK_ID";
            this.wORKIDDataGridViewTextBoxColumn.HeaderText = "WORK_ID";
            this.wORKIDDataGridViewTextBoxColumn.Name = "wORKIDDataGridViewTextBoxColumn";
            this.wORKIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIOBindingSource
            // 
            this.fIOBindingSource.DataMember = "FIO";
            this.fIOBindingSource.DataSource = this.dB_SELHOZRABOTIDataSet;
            // 
            // dB_SELHOZRABOTIDataSet
            // 
            this.dB_SELHOZRABOTIDataSet.DataSetName = "DB_SELHOZRABOTIDataSet";
            this.dB_SELHOZRABOTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wORKIDDataGridViewTextBoxColumn1
            // 
            this.wORKIDDataGridViewTextBoxColumn1.DataPropertyName = "WORK_ID";
            this.wORKIDDataGridViewTextBoxColumn1.HeaderText = "WORK_ID";
            this.wORKIDDataGridViewTextBoxColumn1.Name = "wORKIDDataGridViewTextBoxColumn1";
            this.wORKIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // workNameDataGridViewTextBoxColumn
            // 
            this.workNameDataGridViewTextBoxColumn.DataPropertyName = "WorkName";
            this.workNameDataGridViewTextBoxColumn.HeaderText = "WorkName";
            this.workNameDataGridViewTextBoxColumn.Name = "workNameDataGridViewTextBoxColumn";
            this.workNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zarplataDataGridViewTextBoxColumn
            // 
            this.zarplataDataGridViewTextBoxColumn.DataPropertyName = "Zarplata";
            this.zarplataDataGridViewTextBoxColumn.HeaderText = "Zarplata";
            this.zarplataDataGridViewTextBoxColumn.Name = "zarplataDataGridViewTextBoxColumn";
            this.zarplataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // worksBindingSource
            // 
            this.worksBindingSource.DataMember = "Works";
            this.worksBindingSource.DataSource = this.dB_SELHOZRABOTIDataSet;
            // 
            // fACIDDataGridViewTextBoxColumn1
            // 
            this.fACIDDataGridViewTextBoxColumn1.DataPropertyName = "FAC_ID";
            this.fACIDDataGridViewTextBoxColumn1.HeaderText = "FAC_ID";
            this.fACIDDataGridViewTextBoxColumn1.Name = "fACIDDataGridViewTextBoxColumn1";
            this.fACIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fACULTDataGridViewTextBoxColumn
            // 
            this.fACULTDataGridViewTextBoxColumn.DataPropertyName = "FACULT";
            this.fACULTDataGridViewTextBoxColumn.HeaderText = "FACULT";
            this.fACULTDataGridViewTextBoxColumn.Name = "fACULTDataGridViewTextBoxColumn";
            this.fACULTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fACBindingSource
            // 
            this.fACBindingSource.DataMember = "FAC";
            this.fACBindingSource.DataSource = this.dB_SELHOZRABOTIDataSet;
            // 
            // fIOTableAdapter
            // 
            this.fIOTableAdapter.ClearBeforeFill = true;
            // 
            // worksTableAdapter
            // 
            this.worksTableAdapter.ClearBeforeFill = true;
            // 
            // fACTableAdapter
            // 
            this.fACTableAdapter.ClearBeforeFill = true;
            // 
            // report1
            // 
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.RegisterData(this.dB_SELHOZRABOTIDataSet, "dB_SELHOZRABOTIDataSet");
            // 
            // report2
            // 
            this.report2.ReportResourceString = resources.GetString("report2.ReportResourceString");
            this.report2.RegisterData(this.dB_SELHOZRABOTIDataSet, "dB_SELHOZRABOTIDataSet");
            // 
            // report3
            // 
            this.report3.ReportResourceString = resources.GetString("report3.ReportResourceString");
            this.report3.RegisterData(this.dB_SELHOZRABOTIDataSet, "dB_SELHOZRABOTIDataSet");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.msRabota);
            this.MainMenuStrip = this.msRabota;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msRabota.ResumeLayout(false);
            this.msRabota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvFIO)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SELHOZRABOTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msRabota;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msStud;
        private System.Windows.Forms.ToolStripMenuItem msWork;
        private System.Windows.Forms.ToolStripMenuItem msFAC;
        private System.Windows.Forms.ToolStripMenuItem работаСПроцедурамиToolStripMenuItem;
        protected internal System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.ToolStripMenuItem процедура1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетВТабличнойФормеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетВСвободнойФормеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетСГруппировкойПоДвумТаблицамToolStripMenuItem;
        private System.Windows.Forms.DataGridView dvFAC;
        private System.Windows.Forms.DataGridView dvWork;
        private System.Windows.Forms.DataGridView dvFIO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DB_SELHOZRABOTIDataSet dB_SELHOZRABOTIDataSet;
        private System.Windows.Forms.BindingSource fIOBindingSource;
        private DB_SELHOZRABOTIDataSetTableAdapters.FIOTableAdapter fIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUD2dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUD3DNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource worksBindingSource;
        private DB_SELHOZRABOTIDataSetTableAdapters.WorksTableAdapter worksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zarplataDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fACBindingSource;
        private DB_SELHOZRABOTIDataSetTableAdapters.FACTableAdapter fACTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACULTDataGridViewTextBoxColumn;
        private FastReport.Report report1;
        private FastReport.Report report2;
        private FastReport.Report report3;

    }
}

