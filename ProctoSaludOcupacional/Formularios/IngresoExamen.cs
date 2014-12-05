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
    public partial class IngresoExamen : Form
    {
        public IngresoExamen()
        {
            InitializeComponent();
            iniciar();
        }

        private void iniciar()
        {
            llenarcombo(cbbClinica, "CLINICA", DataClinia);
            llenarcombo(cbbEstado, "Estado", DataEstado);
            llenarcombo(cbbPerfil, "PERFIL", DataPerfil);
            llenarcombo(cbbTipo, "TipoExamen", DataTipo);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BusquedaTrabajador Bus = new BusquedaTrabajador();
            Bus.ShowDialog(this);
            txtTrabajador.Text= Bus.codigo;
            MessageBox.Show(Bus.codigo);
            
        }

        private void llenarcombo(ComboBox cmb, string bas, DataSet data)
        {
            DataTable tabla;
            oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM " + bas;
            data.Clear();
            oleDbDataAdapter1.Fill(data, bas);

            //dataGrid1.SetDataBinding(data, bas);
            tabla = data.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
                cmb.Items.Add(tabla.Rows[i].ItemArray[1]);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();

            oleDbDataAdapter1.InsertCommand.CommandText =
                "INSERT INTO Examen (" +
                "IdTrabajador, TipoExamen, Fecha, Estado, PERFIL, CLINICA, RESTRICCIONES, OBSERVACIONES" +
                
                ") VALUES('" +
                txtTrabajador.Text + "', '" +
                (cbbTipo.SelectedIndex + 1) + "', '" +
                dateTimePicker1.Value.Date + "', '" +
                (cbbEstado.SelectedIndex + 1) + "', '" +
                (cbbPerfil.SelectedIndex + 1) + "', '" +
                (cbbClinica.SelectedIndex + 1) + "', '" +
                textBox7.Text + "', '" +
                textBox8.Text +"')";

            actualizar();
            oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
            oleDbConnection1.Close();
            textBox8.Clear();
            textBox7.Clear();
            txtTrabajador.Clear();
            MessageBox.Show("Examen Agregado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void actualizar()
        {
            try
            {
                int a;
                oleDbDataAdapter1.SelectCommand.CommandText =
                     "SELECT IdExamen FROM Examen WHERE IdTrabajador= '" + txtTrabajador.Text + "'";
                dataSet1.Clear();
                oleDbDataAdapter1.Fill(dataSet1, "Trabajadores");
                a = dataSet1.Tables[0].Rows.Count;
                if (a > 0)
                    txtExamen.Text = dataSet1.Tables[0].Rows[a - 1].ItemArray[0].ToString();
                else
                    MessageBox.Show("No Se Encontro examenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("No Se Encontro examenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void irToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAlerta Alert = new AgregarAlerta();
            Alert.examen = txtExamen.Text;
            Alert.ShowDialog(this);
        }
    }
}
