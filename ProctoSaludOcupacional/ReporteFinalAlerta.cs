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
    public partial class ReporteFinalAlerta : Form
    {
        public ReporteFinalAlerta()
        {
            InitializeComponent();
        }

        private void ReporteFinalAlerta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.reporteFechasentre' Puede moverla o quitarla según sea necesario.
            this.reporteFechasentreTableAdapter.Fill(this.DataSet1.reporteFechasentre,dateTimePicker1.Value,dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.reporteFechasentreTableAdapter.Fill(this.DataSet1.reporteFechasentre,dateTimePicker1.Value,dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
