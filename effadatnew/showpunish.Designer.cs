namespace effadatnew
{
    partial class showpunish
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.effadatDataSet = new effadatnew.effadatDataSet();
            this.SubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubjectsTableAdapter = new effadatnew.effadatDataSetTableAdapters.SubjectsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.punishProcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punishProcTableAdapter = new effadatnew.effadatDataSetTableAdapters.PunishProcTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.effadatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punishProcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // effadatDataSet
            // 
            this.effadatDataSet.DataSetName = "effadatDataSet";
            this.effadatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SubjectsBindingSource
            // 
            this.SubjectsBindingSource.DataMember = "Subjects";
            this.SubjectsBindingSource.DataSource = this.effadatDataSet;
            // 
            // SubjectsTableAdapter
            // 
            this.SubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.punishProcBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "effadatnew.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(51, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(809, 470);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // punishProcBindingSource
            // 
            this.punishProcBindingSource.DataMember = "PunishProc";
            this.punishProcBindingSource.DataSource = this.effadatDataSet;
            // 
            // punishProcTableAdapter
            // 
            this.punishProcTableAdapter.ClearBeforeFill = true;
            // 
            // showpunish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 577);
            this.Controls.Add(this.reportViewer1);
            this.Name = "showpunish";
            this.Text = "showpunish";
            this.Load += new System.EventHandler(this.showpunish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.effadatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punishProcBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource SubjectsBindingSource;
        private effadatDataSet effadatDataSet;
        private effadatDataSetTableAdapters.SubjectsTableAdapter SubjectsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource punishProcBindingSource;
        private effadatDataSetTableAdapters.PunishProcTableAdapter punishProcTableAdapter;
    }
}