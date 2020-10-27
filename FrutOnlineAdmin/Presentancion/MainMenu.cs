using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using FontAwesome.Sharp;

namespace Presentancion
{
    public partial class PanelMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public PanelMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelTras.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //estructura
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114); 
            public static Color color4 = Color.FromArgb(95, 77, 221);
        }

        //metodos
        private void ActivateButtton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBotton();

                //Boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icono actual formlario hijo
                iconFormHijoActual.IconChar = currentBtn.IconChar;
                iconFormHijoActual.IconColor = color; 

            }
        }

        private void DisableBotton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;


        }

        private void BtnTrasportistas_Click(object sender, EventArgs e)
        {
            ActivateButtton(sender, RGBColors.color1);
            //OpenChildForm(new NOMBRE FORMULARIO());
        }

        private void BtnSolicitudes_Click(object sender, EventArgs e)
        {
            ActivateButtton(sender, RGBColors.color2);
            //OpenChildForm(new NOMBRE FORMULARIO());
        }

        private void BtnInforme_Click(object sender, EventArgs e)
        {
            ActivateButtton(sender, RGBColors.color3);
            //OpenChildForm(new NOMBRE FORMULARIO());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
             
        }

        private void Reset()
        {
            DisableBotton();
            leftBorderBtn.Visible = false;
            iconFormHijoActual.IconChar = currentBtn.IconChar;
            iconFormHijoActual.IconColor = Color.Lime;
            lblTitleChildForm.Text = "Home";

        }

        private void BtnClienteExterno_Click(object sender, EventArgs e)
        {
            ActivateButtton(sender, RGBColors.color4);
            //OpenChildForm(new NOMBRE FORMULARIO());
        }

        //DRAG FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);


        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

