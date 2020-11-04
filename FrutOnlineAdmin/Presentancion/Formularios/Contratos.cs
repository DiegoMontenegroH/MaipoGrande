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
using System.Linq.Expressions;

namespace Presentancion.Formularios
{
    public partial class Contratos : Form
    {
        public Contratos()
        {
            InitializeComponent();
        }

        OracleConnection ora = new OracleConnection("DATA SOURCE = xe; PASSWORD=admin;USER ID=C##MANUEL;");
        private void button1_Click(object sender, EventArgs e)
        {

            ora.Open();
            OracleCommand comando = new OracleCommand("seleccionarContratos", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

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
                OracleCommand comando = new OracleCommand("insertarContrato", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("fecha_ini", OracleType.DateTime).Value = dateTimeInicio.Text;
                comando.Parameters.Add("fecha_fin", OracleType.DateTime).Value = dateTimeFin.Text;
                comando.Parameters.Add("r_productor", OracleType.VarChar).Value = txtRutProductor.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Contrato Insertado");
            }
            catch (Exception)
            {
                MessageBox.Show("Contrato no pudo ser insertado");
            }
            ora.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("sp_modificar_contrato2", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_fecha_inicio", OracleType.DateTime).Value = dateTimeInicio.Text;
            comando.Parameters.Add("v_fecha_fin", OracleType.DateTime).Value = dateTimeFin.Text;
            comando.Parameters.Add("v_rut_productor", OracleType.VarChar).Value = txtRutProductor.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Contrato Modificado");
            ora.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("eliminarContrato", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("v_rut", OracleType.Number).Value = Convert.ToInt32(txtRutProductor.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Contrato Eliminado");
                ora.Close();
            }
        }

        int indexRow;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            dateTimeInicio.Text = row.Cells[1].Value.ToString();
            dateTimeFin.Text = row.Cells[2].Value.ToString();
            txtRutProductor.Text = row.Cells[3].Value.ToString();
            

        }
    }
}
