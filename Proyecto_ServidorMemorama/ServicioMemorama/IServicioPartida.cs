using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMemorama
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IServicioPartidaCallback))]
    public interface IServicioPartida
    {

    }

    public interface IServicioPartidaCallback
    {

    }

    [DataContract]
    public class PartidaJuego
    {

    }
}
