using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMemorama
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IServicioPuntuaciones
    {
        [OperationContract]
        List<PuntuacionUsuario> ObtenerTablaPuntuacion();
    }

    [DataContract]
    public class PuntuacionUsuario
    {
        private string nombre = "";
        private int puntos = -1;

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }
    }
}
