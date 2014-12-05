using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProctoSaludOcupacional.Formularios
{
    public partial class ReporteAlerta : Form
    {
        public ReporteAlerta()
        {
            InitializeComponent();
        }

        public ReporteAlerta(DateTime inicio, DateTime fin)
        {
            InitializeComponent();
            dateTimePicker1.Value = inicio;
            dateTimePicker2.Value = fin;
            buscar();
        }

        private void buscar()
        {
            try
            {


                oleDbDataAdapter1.SelectCommand.CommandText =
                     "SELECT * FROM TAlertas WHERE Fecha BETWEEN #" + dateTimePicker1.Value.ToShortDateString() + "# AND #" +
                     dateTimePicker2.Value.ToShortDateString() + "# ORDER BY Fecha";
                dataSet1.Clear();
                oleDbDataAdapter1.Fill(dataSet1, "Alertas");
                dataGrid1.SetDataBinding(dataSet1, "Alertas");
                if (dataSet1.Tables[0].Rows.Count <= 0)

                    MessageBox.Show("No Se Encontraron Alertas");
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("No Se Encontraron Alertas");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            buscar();
            
        }
    }
}
