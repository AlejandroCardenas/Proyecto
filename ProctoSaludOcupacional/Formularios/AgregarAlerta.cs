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
    public partial class AgregarAlerta : Form
    {
        public string examen;
        public AgregarAlerta()
        {
            InitializeComponent();
            llenarcombo(cbbRef, "ExamenReferencia", dataRef);
            txtExamen.Text = examen;

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
            txtExamen.Text = examen;
            oleDbDataAdapter1.InsertCommand.CommandText =
                "INSERT INTO TAlertas (" +
                "ExamenReferencia, Examen, Detalle, Fecha" +

                ") VALUES('" +
                (cbbRef.SelectedIndex+1)+"', '" +
                txtExamen.Text + "', '" +
                txtDetalle.Text + "', '" +
                dateTimePicker1.Value.Date
                + "')";

            
            oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();

            //DataTable tabla;
            int a = Int32.Parse(txtExamen.Text);
            oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM TAlertas WHERE INT(Examen)='" + a + "'";
            dataSet1.Clear();
            
            oleDbDataAdapter1.Fill(dataSet1,"Alertas");

            dataGrid1.SetDataBinding(dataSet1, "Alertas");

            oleDbConnection1.Close();
            txtDetalle.Clear();
            txtExamen.Clear();
            MessageBox.Show("Alerta Agregada","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
