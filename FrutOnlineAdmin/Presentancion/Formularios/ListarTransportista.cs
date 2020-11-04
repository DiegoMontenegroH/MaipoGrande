using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Presentancion.Formularios
{
    public partial class ListarTransportista : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe; PASSWORD=admin;USER ID=C##Manuel;");
        public ListarTransportista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("seleccionarTransportistas", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction=ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            ora.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("insertar_transportista", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("newRut", OracleType.VarChar).Value = txtRut.Text;
                comando.Parameters.Add("newNombre", OracleType.VarChar).Value = txtnombre.Text;
                comando.Parameters.Add("newApellido", OracleType.VarChar).Value = txtApellido.Text;
                comando.Parameters.Add("newTelefono", OracleType.Number).Value = Convert.ToInt32(TxtTelefono.Text);
                comando.Parameters.Add("newEmail", OracleType.VarChar).Value = txtEmail.Text;
                comando.Parameters.Add("newUser", OracleType.VarChar).Value = txtUserName.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("transportista insertado");
            }
            catch (Exception)
            {
                
                MessageBox.Show("error");
            }
            ora.Close();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("actualizar_trans", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("newRut", OracleType.VarChar).Value = txtRut.Text;
                comando.Parameters.Add("newNombre", OracleType.VarChar).Value = txtnombre.Text;
                comando.Parameters.Add("newApellido", OracleType.VarChar).Value = txtApellido.Text;
                comando.Parameters.Add("newTelefono", OracleType.Number).Value = Convert.ToInt32(TxtTelefono.Text);
                comando.Parameters.Add("newEmail", OracleType.VarChar).Value = txtEmail.Text;
                comando.Parameters.Add("newUser", OracleType.VarChar).Value = txtUserName.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Persona actualizada");
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error actualizar ");
            }
            ora.Close();


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("Eliminar_trans", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("newRut", OracleType.VarChar).Value = txtRut.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Persona Eliminada");
            ora.Close();


        }

        int indexRow;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtRut.Text = row.Cells[0].Value.ToString();
            txtnombre.Text = row.Cells[1].Value.ToString();
            txtApellido.Text = row.Cells[2].Value.ToString();
            TxtTelefono.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();


        }
    }
}
