using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMemorama
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IServicioUsuariosCallback))]
    public interface IServicioUsuarios
    {
        [OperationContract]
        bool ConexionServidorSesion(DatosUsuario inicioUsuario);
        [OperationContract]
        bool ConexionServidorRegistro(DatosUsuario registroUsuario);
        [OperationContract]
        string ConexionServidorCodigo(string correo);
    }

    public interface IServicioUsuariosCallback
    {
        [OperationContract]
        string ConexionClienteSesion();
        [OperationContract]
        void ResultadoConexionSesion(bool resultado);

    }

    [DataContract]
    public class DatosUsuario
    {
        private string usuario = "";
        private string contrasena = "";
        private string correo = "";

        [DataMember]
        public string Nombre
        {
            get { return usuario; }
            set { usuario = value; }
        }
        [DataMember]
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        [DataMember]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
    }
}
