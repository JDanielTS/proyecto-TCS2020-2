using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMemorama
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public partial class ServicioClienteMemorama : IServicioUsuarios
    {
        [OperationBehavior]
        public bool ConexionServidorSesion(DatosUsuario inicioUsuario)
        {
            //Obtener datos de usuario del EF
            //EntidadesMemorama.UsuariosDB usuarioBuscar = new EntidadesMemorama.UsuariosDB();
            //Comparar nombre de usuario de EF con usuario de DatosUsuario
            //if (usuarioBuscar.BuscarUsuario(inicioUsuario.Nombre) != NULL){}
            //Sobre lo anterior comparar contrasenas;

            return true;
        }

        [OperationBehavior]
        public bool ConexionServidorRegistro(DatosUsuario registroUsuario)
        {
            //Buscar por EF los usuarios
            //Comparar primero correos y luego usuarios, no debe haber coincidencias.
            //if (!usuarioBusqueda.BuscarCorreo(registroUsuario.Correo))
            // if (!usuarioBusqueda.BuscarNombreUsuario(registroUsuario.Nombre))
            //  return true; 
            //Encriptar registroUsuario.Contrasena y guardarlo en EF

            return false;
        }

        [OperationBehavior]
        public string ConexionServidorCodigo(string correo)
        {
            var mensaje = new MimeMessage();
            mensaje.From.Add(MailboxAddress.Parse("correoejemplo@example.com"));
            mensaje.To.Add(MailboxAddress.Parse(correo));
            mensaje.Subject = "Codigo de cuenta para Memorama";
            //Generar codigo de 5 numeros.
            string mensajeCodigo = "mensaje " + "codigo";
            mensaje.Body = new TextPart(TextFormat.Plain) { Text = mensajeCodigo };

            using (var smtpCliente = new SmtpClient())
            {
                //if gmail.com
                smtpCliente.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                // if hotmail
                //smtpCliente.Connect("smtp.live.com", 587, SecureSocketOptions.StartTls);

                //smtpCliente.Authenticate
                smtpCliente.Send(mensaje);
                smtpCliente.Disconnect(true);
            }

            return "codigo";
        }
        
    }
}
