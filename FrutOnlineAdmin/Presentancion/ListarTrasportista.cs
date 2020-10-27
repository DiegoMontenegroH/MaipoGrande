using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using FontAwesome.Sharp;

namespace Presentancion
{
    public partial class ListarTrasportista : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public ListarTrasportista()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelTras.Controls.Add(leftBorderBtn);
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



        private void BtnTrasportistas_Click(object sender, EventArgs e)
        {
            ActivateButtton(sender, RGBColors.color1);
        }

        private void BtnSolicitudes_Click(object sender, EventArgs e)
        {
            ActivateButtton(sender, RGBColors.color2);
        }

        private void BtnInforme_Click(object sender, EventArgs e)
        {
            ActivateButtton(sender, RGBColors.color3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnClienteExterno_Click(object sender, EventArgs e)
        {
            ActivateButtton(sender, RGBColors.color4);
        }
    }
}

