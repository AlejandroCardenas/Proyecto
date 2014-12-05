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
    public partial class BusquedaTrabajador : Form
    {
        public string codigo{get;set;}
        public BusquedaTrabajador()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioButton1.Checked)
                
                oleDbDataAdapter1.SelectCommand.CommandText =
                     "SELECT IdTrabajador FROM Trabajador WHERE DNI= '" + txtDNI.Text + "'";
                else
                    oleDbDataAdapter1.SelectCommand.CommandText =
                         "SELECT IdTrabajador FROM Trabajador WHERE ApellidoPaterno = '" + txtApeP.Text + "' or ApellidoMaterno = '"+txtApeM.Text+"'";
                dataSet1.Clear();
                oleDbDataAdapter1.Fill(dataSet1, "Trabajadores");
                if(dataSet1.Tables[0].Rows.Count==1)
                    txtRes.Text = dataSet1.Tables[0].Rows[0].ItemArray[0].ToString();
                else
                    MessageBox.Show("No Se Encontro al trabajador");
                    
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("No Se Encontro al trabajador");
            }


        }

        private void BusquedaTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            codigo = txtRes.Text;
        }
    }
}
