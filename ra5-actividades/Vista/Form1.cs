using Microsoft.Reporting.WinForms;
using ra5_actividades.Controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ra5_actividades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ControladorElemento.cargar();
            sueldo.Maximum = decimal.MaxValue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportGrafico.rdlc";
            ReportDataSource source = new ReportDataSource("Grafico", ControladorElemento.lista);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void filtrar_Click(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.ReportPath = "ReportGrafico.rdlc";
            var empleadosFiltro = ControladorElemento.lista.Where(el => el.Salario > double.Parse(this.sueldo.Value.ToString()));
            ReportDataSource source = new ReportDataSource("Grafico", empleadosFiltro);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);


            this.reportViewer1.RefreshReport();
        }
    }
}
