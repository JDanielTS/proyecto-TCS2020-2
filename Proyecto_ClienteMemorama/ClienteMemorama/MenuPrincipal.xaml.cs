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

namespace ClienteMemorama
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal(string usuario)
        {
            InitializeComponent();
        }

        public void clicCerrarSesion(Object sender, RoutedEventArgs e)
        {
            InicioSesion ventana_inicio = new InicioSesion();
            ventana_inicio.Show();
            this.Close();
        }

        public void clicCrearPartida()
        {

        }

        public void clicBuscarPartida()
        {

        }

        public void clicTablaPuntuaciones()
        {

        }
        
    }
}
