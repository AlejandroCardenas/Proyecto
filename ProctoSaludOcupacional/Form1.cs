using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProctoSaludOcupacional.Formularios;

namespace ProctoSaludOcupacional
{
    public partial class PantallaPrinipal : Form
    {
        public PantallaPrinipal()
        {
            InitializeComponent();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoTrabajador ing = new IngresoTrabajador();
            ing.Show();
        }

        private void PantallaPrinipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void clinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoClinica clin = new IngresoClinica();
            clin.Show();
        }

        private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoExamen ex = new IngresoExamen();
            ex.Show();
        }

        private void trabajadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BusquedaTrabajador bus = new BusquedaTrabajador();
            bus.Show();
        }

        private void rangoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteFinalAlerta f = new ReporteFinalAlerta();
            //FormAlerta f = new FormAlerta();
            f.Show();
        }

        

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlertaRef f = new FormAlertaRef(1);
            f.Show();
        }

        private void clinicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BusquedaExamenes bus = new BusquedaExamenes();
            bus.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlerta f = new FormAlerta();
            f.Show();
        }

        private void siguienteMesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAlertaRef f = new FormAlertaRef(2);
            f.Show();
        }

        private void fisicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlertaRef f = new FormAlertaRef(3);
            f.Show();
        }

        private void alertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAlerta a = new AgregarAlerta();
            a.Show();
        }
    }
}
