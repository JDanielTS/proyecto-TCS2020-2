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
using EntidadesMemorama;

namespace ServicioMemorama
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public partial class ServicioClienteMemorama : IServicioUsuarios
    {
        IServicioUsuariosCallback callback = null;
        
        public ServicioClienteMemorama()
        {
            callback = OperationContext.Current.GetCallbackChannel<IServicioUsuariosCallback>();
        }

        [OperationBehavior]
        public int ConexionServidorSesion(DatosUsuario inicioUsuario)
        {
            //Obtener datos de usuario del EF
            //EntidadesMemorama.UsuariosDB usuarioBuscar = new EntidadesMemorama.UsuariosDB();
            //Comparar nombre de usuario de EF con usuario de DatosUsuario
            //if (usuarioBuscar.BuscarUsuario(inicioUsuario.Nombre) != NULL){}
            //Sobre lo anterior comparar contrasenas;
            Usuario usersesion = null;
            UsuariosDB datosBD = new UsuariosDB();
            usersesion = datosBD.BuscarUsuarioNombre(inicioUsuario.Nombre);
            if (usersesion != null)
            {
                if (usersesion.contrasena == inicioUsuario.Contrasena)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            return 0;
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
            UsuariosDB datosDB = new UsuariosDB();
            Usuario registro = null;
            registro = datosDB.BuscarUsuarioNombre(registroUsuario.Nombre);
            if (registro == null)
            {
                registro = datosDB.BuscarUsuarioCorreo(registroUsuario.Correo);
                if (registro == null)
                {
                    registro.contrasena = registroUsuario.Contrasena;
                    registro.correoUsuario = registroUsuario.Correo;
                    registro.nombreUsuario = registroUsuario.Nombre;

                    datosDB.GuardarUsuario(registro);
                    return true;
                }
            }
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
    /*
    public partial class ServicioClienteMemorama : IServicioPuntuaciones
    {
        public List<PuntuacionUsuario> ObtenerTablaPuntuacion()
        {
            ///por implementar
            var x = new List<PuntuacionUsuario>();
            return x;
        }
    }
    */
}
