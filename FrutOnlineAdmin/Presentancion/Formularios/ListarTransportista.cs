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
    }
}
