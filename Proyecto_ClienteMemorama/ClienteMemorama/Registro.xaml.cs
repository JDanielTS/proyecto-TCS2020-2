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
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void clicRegresar(object sender, RoutedEventArgs e)
        {
            this.Owner.Focus();
            this.Close();
        }

        private void clicRegistro(object sender, RoutedEventArgs e)
        {
            //Conectar al servidor para mandar correo con código de confirmación.

            //Además, abrir ventana de código.
            RegistroVerificacion verificador = new RegistroVerificacion();
            verificador.Owner = this;
            verificador.ShowDialog();
        }
        

    }
}
