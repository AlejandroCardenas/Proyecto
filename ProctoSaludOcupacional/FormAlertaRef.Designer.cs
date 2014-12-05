namespace ProctoSaludOcupacional
{
    partial class FormAlertaRef
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlertaDescripcion = new ProctoSaludOcupacional.AlertaDescripcion();
            this.ReporteReferenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteReferenciaTableAdapter = new ProctoSaludOcupacional.AlertaDescripcionTableAdapters.ReporteReferenciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AlertaDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteReferenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteReferenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProctoSaludOcupacional.ReportAlertaRef.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1073, 271);
            this.reportViewer1.TabIndex = 0;
            // 
            // AlertaDescripcion
            // 
            this.AlertaDescripcion.DataSetName = "AlertaDescripcion";
            this.AlertaDescripcion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteReferenciaBindingSource
            // 
            this.ReporteReferenciaBindingSource.DataMember = "ReporteReferencia";
            this.ReporteReferenciaBindingSource.DataSource = this.AlertaDescripcion;
            // 
            // ReporteReferenciaTableAdapter
            // 
            this.ReporteReferenciaTableAdapter.ClearBeforeFill = true;
            // 
            // FormAlertaRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 319);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormAlertaRef";
            this.Text = "FormAlertaRef";
            this.Load += new System.EventHandler(this.FormAlertaRef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlertaDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteReferenciaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteReferenciaBindingSource;
        private AlertaDescripcion AlertaDescripcion;
        private AlertaDescripcionTableAdapters.ReporteReferenciaTableAdapter ReporteReferenciaTableAdapter;
    }
}