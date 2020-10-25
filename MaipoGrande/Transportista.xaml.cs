using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MaipoGrande
{
    /// <summary>
    /// Lógica de interacción para Transportista.xaml
    /// </summary>
    public partial class Transportista : Window
    {
        public Transportista()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mv = new MainWindow();
            mv.Show();
        }
    }
}
