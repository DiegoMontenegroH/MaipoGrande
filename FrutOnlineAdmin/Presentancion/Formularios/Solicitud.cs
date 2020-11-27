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
    public partial class Solicitud : Form
    {
        public Solicitud()
        {
            InitializeComponent();
        }

        OracleConnection ora = new OracleConnection("DATA SOURCE = xe; PASSWORD=admin;USER ID=C##MANUEL;");
        private void button1_Click(object sender, EventArgs e)
        {

            ora.Open();
            OracleCommand comando = new OracleCommand("seleccionarSolicitudes2", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            ora.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("sp_modificar_solicitud", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

            
                comando.Parameters.Add("v_presupuesto", OracleType.Number).Value = Convert.ToInt32(txtPresupuesto.Text);
                comando.Parameters.Add("v_id_producto", OracleType.Number).Value = Convert.ToInt32(txtProducto.Text);
                comando.Parameters.Add("v_nie", OracleType.Number).Value = Convert.ToInt32(txtRut.Text);
                comando.Parameters.Add("v_id_fruta", OracleType.Number).Value = Convert.ToInt32(txtFruta.Text);
                comando.Parameters.Add("v_id_estado", OracleType.Number).Value = Convert.ToInt32(txtEstado.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Solicitud actualizada");
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }

            ora.Close();
        }


        int indexRow;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtId.Text = row.Cells[0].Value.ToString();
            txtPresupuesto.Text = row.Cells[1].Value.ToString();
            txtProducto.Text = row.Cells[2].Value.ToString();
            txtRut.Text = row.Cells[3].Value.ToString();
            txtFruta.Text = row.Cells[4].Value.ToString();
            txtEstado.Text = row.Cells[5].Value.ToString();
        }

    }
}
