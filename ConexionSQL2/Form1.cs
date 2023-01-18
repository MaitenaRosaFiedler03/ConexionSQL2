using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionSQL2
{
    public partial class Informe : Form
    {
        public Informe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejemploConexDataSet2.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter1.Fill(this.ejemploConexDataSet2.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'ejemploConexDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.ejemploConexDataSet.Alumnos);

            this.reportViewer1.RefreshReport();
        }
    }
}
