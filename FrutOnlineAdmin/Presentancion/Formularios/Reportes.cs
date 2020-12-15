using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentancion.Formularios
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CrearPDF();
        }


        private void CrearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("ReporteExterno.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);

            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Codigo solicitud", "Presupuesto", "Codigo producto", "NIE", "Nombre fruta", "Estado" };

            float[] tamanios = { 2, 4, 2, 4, 4, 2};

            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach(string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "select id_solicitud, presupuesto, id_producto, nie, fruta.nombre, estado.tipo from solicitud_compra_ext INNER JOIN fruta ON solicitud_compra_ext.id_fruta = fruta.id_fruta INNER JOIN estado ON solicitud_compra_ext.id_estado = estado.id_estado";
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe; PASSWORD=admin;USER ID=C##MANUEL;");
            ora.Open();

            OracleCommand comando = new OracleCommand(sql, ora);
            OracleDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(reader["id_solicitud"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Presupuesto"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["id_producto"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["NIE"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["nombre"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["tipo"].ToString()).SetFont(fontContenido)));
            }

            documento.Add(tabla);
            documento.Close();
        }

        private void btnReporteInterno_Click(object sender, EventArgs e)
        {
            CrearPDFInterno();
        }


        private void CrearPDFInterno()
        {
            PdfWriter pdfWriter = new PdfWriter("ReporteInterno.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);

            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Codigo de Venta", "Costo de Transporte", "Comisión de la empresa", "Rut cliente", "Codigo producto", "Estado" };

            float[] tamanios = { 2, 4, 2, 4, 4, 2 };

            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "select id_ventaL, costo_transporte, comision_empresa, rut_clii, id_produs, estado.tipo from proceso_venta_local INNER JOIN estado ON proceso_venta_local.id_estado = estado.id_estado";
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe; PASSWORD=admin;USER ID=C##MANUEL;");
            ora.Open();

            OracleCommand comando = new OracleCommand(sql, ora);
            OracleDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(reader["id_ventaL"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["costo_transporte"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["comision_empresa"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["rut_clii"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["id_produs"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["tipo"].ToString()).SetFont(fontContenido)));
            }

            documento.Add(tabla);
            documento.Close();
        }


    }
}
