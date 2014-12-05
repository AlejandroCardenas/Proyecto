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
    public partial class BusquedaExamenes : Form
    {
        public BusquedaExamenes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusquedaTrabajador bus = new BusquedaTrabajador();
            bus.ShowDialog(this);
            txtTrabajador.Text = bus.codigo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTrabajador.Text == "")
                MessageBox.Show("Busque el trabajador por favor");
            else
            {
                oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM Examen WHERE IdTrabajador ='" +
                    txtTrabajador.Text + "'";
                dataSet1.Clear();

                oleDbDataAdapter1.Fill(dataSet1, "Examenes");

                dataGrid1.SetDataBinding(dataSet1, "Examenes");
            }
        }
    }
}
