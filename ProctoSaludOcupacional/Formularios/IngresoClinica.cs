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
    public partial class IngresoClinica : Form
    {
        public IngresoClinica()
        {
            InitializeComponent();
            oleDbConnection1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO CLINICA (CLINICA) VALUES('" +
                textBox1.Text + "')";
            oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Alerta Agregada", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
        }

        private void IngresoClinica_FormClosed(object sender, FormClosedEventArgs e)
        {
            oleDbConnection1.Close();
        }
    }
}
