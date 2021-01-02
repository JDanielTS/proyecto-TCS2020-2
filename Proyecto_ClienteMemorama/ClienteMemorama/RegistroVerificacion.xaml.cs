using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    /// Lógica de interacción para RegistroVerificacion.xaml
    /// </summary>
    public partial class RegistroVerificacion : Window
    {
        
        public RegistroVerificacion()
        {
            InitializeComponent();
            this.EnviarCorreo();
        }

        public void ClicReintentarCorreo(Object sender, RoutedEventArgs e)
        {
            EnviarCorreo();
            enviaCorreo.Visibility = Visibility.Hidden;

            /**Timer temporizador = new Timer(20);
            temporizador.Start();
            temporizador.Elapsed += EventoTemporizador;
            temporizador.Stop();
            temporizador.Dispose();**/
        }
        private void EnviarCorreo()
        {
            //Enviar correo con código de verificación de cuenta aquí.
        }

        public void ClicRegresar(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void ClicComprobarCodigo(Object sender, RoutedEventArgs e)
        {
            //Aquí se debe aprobar el código que se mandó por correo.
        }
    }
}
