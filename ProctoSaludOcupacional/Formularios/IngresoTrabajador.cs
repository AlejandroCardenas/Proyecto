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
    public partial class IngresoTrabajador : Form
    {
        public IngresoTrabajador()
        {
            InitializeComponent();
            oleDbConnection1.Open();
            iniciar();
        }

        private void llenarcombo(ComboBox cmb, string bas,DataSet data)
        {
            DataTable tabla;
            oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM " + bas;
            data.Clear();
            oleDbDataAdapter1.Fill(data,bas);

            //dataGrid1.SetDataBinding(data, bas);
            tabla = data.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
                cmb.Items.Add(tabla.Rows[i].ItemArray[1]);
        }

        private void iniciar()
        {
            
            llenarcombo(comboBox2, "EstadoCivil",dataSet1);
            llenarcombo(comboBox1, "Sexo",dataSet2);
            
        }

        private string generarcodigo()
        {
            string res;
            Char c;
            Random rdm = new Random();
            
            c = Convert.ToChar(rdm.Next(65, 75));//90 es la z
            //codigo de la forma letra+numer0+.+numero
            res = c + rdm.Next(00, 100).ToString() +"."+ rdm.Next(00, 100).ToString();
            
            return res;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            
            oleDbDataAdapter1.InsertCommand.CommandText =
                "INSERT INTO Trabajador (" +
                "IdTrabajador, DNI, NombreP, NombreS, ApellidoPaterno, ApellidoMaterno, " +
                "Fotocheck, RH, Area, PuestodeTrabajo, FechaNacimiento, Sexo, EstadoCivil" +
                ") VALUES('" +
                generarcodigo() + "', '" +
                txtDNI.Text + "', '" +
                txtNom1.Text + "', '" +
                txtNom2.Text + "', '" +
                txtApe1.Text + "', '" +
                txtApe2.Text + "', '" +
                txtFtck.Text + "', '" +
                txtRH.Text + "', '" +
                txtArea.Text + "', '" +
                txtPuesto.Text + "', '" +
                Nacimiento.Value.Date + "', '" +
                (comboBox1.SelectedIndex+1) + "', '" +
                (comboBox2.SelectedIndex+1) + "')";

            
            oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Traabajador Agregado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtApe1.Clear(); txtApe2.Clear(); txtArea.Clear();
            txtDNI.Clear(); txtFtck.Clear(); txtNom1.Clear(); txtNom2.Clear();
            txtPuesto.Clear(); txtRH.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IngresoTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            oleDbConnection1.Close();
        }
    }
}
