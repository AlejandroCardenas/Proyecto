using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProctoSaludOcupacional
{
    public partial class FormAlertaRef : Form
    {
        int num;
        public FormAlertaRef(int a)
        {
            num = a;
            InitializeComponent();
        }

        private void FormAlertaRef_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AlertaDescripcion.ReporteReferencia' Puede moverla o quitarla según sea necesario.
            this.ReporteReferenciaTableAdapter.Fill(this.AlertaDescripcion.ReporteReferencia,num);

            this.reportViewer1.RefreshReport();
        }
    }
}
