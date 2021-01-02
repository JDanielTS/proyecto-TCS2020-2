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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClienteMemorama
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void clicIniciar(object sender, RoutedEventArgs e)
        {
            string usuario = campo_usuario.Text;
            string contrasena = campo_contrasena.Password;

            //Agregar conexión al servidor para validación. Una vez validado: 

            MenuPrincipal ventana_menu =  new MenuPrincipal(usuario);
            ventana_menu.Show();
            this.Close();
        }

        private void clicRegistro(object sender, MouseButtonEventArgs e)
        {
            Registro ventana_registro = new Registro();
            ventana_registro.Owner = this;
            boton_registro.Foreground = Brushes.BlueViolet;
            ventana_registro.Show();
        }
        
    }
}
