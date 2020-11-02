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
    public partial class Transportes : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe; PASSWORD=admin;USER ID=C##Manuel;");

        public Transportes()
        {
            InitializeComponent();
        }

        private void btnCargarTransportes_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_LISTAR_TRANSPORTES", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("transportes", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvTransportes.DataSource = tabla;

            ora.Close();
        }


        private void btnEliminarTransporte_Click(object sender, EventArgs e)
        {
            try 
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_TRANSPORTE", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("v_patente", OracleType.VarChar).Value = txtPatente.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Transporte eliminado");

            }
            catch(Exception)
            {
                MessageBox.Show("No se ha podido eliminar el transporte");
            }

            ora.Close();
        }

        private void btnAgregarTransporte_Click_1(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_TRANSPORTE", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("v_patente", OracleType.VarChar).Value = txtPatente.Text;
                comando.Parameters.Add("v_capacidad", OracleType.Number).Value = txtCapacidad.Text;
                comando.Parameters.Add("v_refigeracion", OracleType.Char).Value = txtRefigeracion.Text;
                comando.Parameters.Add("v_tamanio", OracleType.VarChar).Value = txtTamanio.Text;
                comando.Parameters.Add("v_rut_transportista", OracleType.VarChar).Value = txtRut_Transportista.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Transporte insertado");

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha logrado insertar el transporte");
            }

            ora.Close();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("SP_MODIFICAR_TRANSPORTE", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("v_patente", OracleType.VarChar).Value = txtPatente.Text;
                comando.Parameters.Add("v_capacidad", OracleType.Number).Value = Convert.ToInt32(txtCapacidad.Text);
                comando.Parameters.Add("v_refigeracion", OracleType.Char).Value = txtRefigeracion.Text;
                comando.Parameters.Add("v_tamanio", OracleType.VarChar).Value = txtTamanio.Text;
                comando.Parameters.Add("v_rut_transportista", OracleType.VarChar).Value = txtRut_Transportista.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Transporte modificado");

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido modificar el transporte");
            }

            ora.Close();
        }
    }
}
