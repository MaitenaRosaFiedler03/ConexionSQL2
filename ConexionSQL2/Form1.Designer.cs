namespace ConexionSQL2
{
    partial class Informe
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ejemploConexDataSet = new ConexionSQL2.EjemploConexDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new ConexionSQL2.EjemploConexDataSetTableAdapters.AlumnosTableAdapter();
            this.ejemploConexDataSet2 = new ConexionSQL2.EjemploConexDataSet2();
            this.alumnosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter1 = new ConexionSQL2.EjemploConexDataSet2TableAdapters.AlumnosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ejemploConexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemploConexDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.alumnosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConexionSQL2.Informe2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ejemploConexDataSet
            // 
            this.ejemploConexDataSet.DataSetName = "EjemploConexDataSet";
            this.ejemploConexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.ejemploConexDataSet;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // ejemploConexDataSet2
            // 
            this.ejemploConexDataSet2.DataSetName = "EjemploConexDataSet2";
            this.ejemploConexDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource1
            // 
            this.alumnosBindingSource1.DataMember = "Alumnos";
            this.alumnosBindingSource1.DataSource = this.ejemploConexDataSet2;
            // 
            // alumnosTableAdapter1
            // 
            this.alumnosTableAdapter1.ClearBeforeFill = true;
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informe";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejemploConexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemploConexDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EjemploConexDataSet ejemploConexDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private EjemploConexDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private EjemploConexDataSet2 ejemploConexDataSet2;
        private System.Windows.Forms.BindingSource alumnosBindingSource1;
        private EjemploConexDataSet2TableAdapters.AlumnosTableAdapter alumnosTableAdapter1;
    }
}

