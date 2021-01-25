using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMemorama
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IServicioSalaPartidaCallback))]
    public interface IServicioSalaPartida
    {
        [OperationContract]
        void MandarMensajeChat(string mensaje);

        [OperationContract]
        bool CrearPartida();

        [OperationContract]
        bool AgregarJugador();


    }
    public interface IServicioSalaPartidaCallback
    {
        [OperationContract]
        DatosUsuario ObtenerJugador();
        //[OperationContract]
        //void 
    }

    [DataContract]
    public class SalaPartida
    {
        private int estadoPartida = -1;
        private int idPartida = -1;

        public virtual ICollection<Jugador> Jugadores { get; set; }
        public int IdPartida
        {
            get { return idPartida; }
            set { idPartida = value; }
        }
        public int EstadoPartida
        {
            get { return estadoPartida; }
            set { estadoPartida = value; }
        }
    }
    [DataContract]
    public class Jugador
    {
        private int idJugadorPartida;
        private int puntosJugador;

        public DatosUsuario usuarioJugador { get; set; }
        public int IdJugador
        {
            get { return idJugadorPartida; }
            set { idJugadorPartida = value; }
        }
        public int Puntos
        {
            get { return puntosJugador; }
            set { puntosJugador = value; }
        }
    }
}
