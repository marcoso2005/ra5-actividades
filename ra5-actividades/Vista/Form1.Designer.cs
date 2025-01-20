namespace ra5_actividades
{
    partial class Form1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.filtrar = new System.Windows.Forms.Button();
            this.sueldo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(985, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // filtrar
            // 
            this.filtrar.Location = new System.Drawing.Point(12, 415);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(75, 23);
            this.filtrar.TabIndex = 2;
            this.filtrar.Text = "Filtrar";
            this.filtrar.UseVisualStyleBackColor = true;
            this.filtrar.Click += new System.EventHandler(this.filtrar_Click);
            // 
            // sueldo
            // 
            this.sueldo.DecimalPlaces = 2;
            this.sueldo.Location = new System.Drawing.Point(161, 418);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(120, 20);
            this.sueldo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.sueldo);
            this.Controls.Add(this.filtrar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sueldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button filtrar;
        private System.Windows.Forms.NumericUpDown sueldo;
    }
}

