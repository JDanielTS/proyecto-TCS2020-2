using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

            ConexionServicio1.DatosUsuario usuarioIntroducido= new ConexionServicio1.DatosUsuario();
            usuarioIntroducido.Nombre = usuario;
            usuarioIntroducido.Contrasena = contrasena;

            try
            {
                ManejoCallbackUsuarios manejoCallback = new ManejoCallbackUsuarios();
                InstanceContext contexto = new InstanceContext(manejoCallback);
                ConexionServicio1.ServicioUsuariosClient cliente = new ConexionServicio1.ServicioUsuariosClient(contexto);

                int comprobanteUsuario = cliente.ConexionServidorSesion(usuarioIntroducido);
                if (comprobanteUsuario == 2)
                {
                    MenuPrincipal ventana_menu = new MenuPrincipal(usuario);
                    ventana_menu.Show();
                    this.Close();
                }
                else if (comprobanteUsuario == 1)
                {
                    
                }
                else if (comprobanteUsuario == 0)
                {
                    
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error:\n\n", error.GetType(), "\n\n", error.Message, "\n\n", error.StackTrace);
            }
            

            
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
