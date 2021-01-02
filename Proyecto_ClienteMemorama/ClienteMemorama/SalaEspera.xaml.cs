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
    /// Lógica de interacción para SalaEspera.xaml
    /// </summary>
    public partial class SalaEspera : Window
    {
        private bool esAnfitrion = false;

        public SalaEspera(bool anfitrion)
        {
            esAnfitrion = anfitrion;
            InitializeComponent();
            if (esAnfitrion)
            {
                //Solicitar a servidor la creación de partida, obtener el código
                MessageBox.Show("Aqui va el codigo", "codigo", MessageBoxButton.OK);
                //botonCancelar.Content = mensajeSalir //Debe decir "Cancelar juego" si es anfitrión.
            }
            else
            {
                botonSacarJugador.Visibility = Visibility.Hidden;
                //botonCancelar.Content = mensajeSalir //Debe cambiar si no es anfitrión a "Salir de partida"
            }
        }

        private void clicCancelarJuego(object sender, RoutedEventArgs e)
        {
            if (esAnfitrion)
            {
                //Aquí debe notificar al servidor que la partida se borra.
                //Debe notificar a los demás clientes por medio del cambio.
                this.Close();
            }
            else
            {
                //Aquí debe notificar al servidor que sale de la sala.
                this.Close();
            }
        }

        private void clicSacarJugador(object sender, RoutedEventArgs e)
        {
            //Aquí necesito quitar de la lista al jugador seleccionado,
            //notificar al servidor y enviar el id del jugador,
            //y cerrar la sala del jugador sacado.
            //No puede sacarse a sí mismo.
        }

        private void clicEnviarMensaje(object sender, RoutedEventArgs e)
        {
            //Aquí debe enviar el mensaje al servidor y a los clientes que estén en la sala.
        }

        private void clicIniciarJuego(object sender, RoutedEventArgs e)
        {
            //Aquí debe notificar al servidor que el jugador está listo para iniciar,
            //se debe esperar a que todos los jugadores 
        }

    }
}
