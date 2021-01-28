using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMemorama
{
    public class ManejoCallbackUsuarios : ConexionServicio1.IServicioUsuariosCallback
    {
        public string ConexionClienteSesion()
        {
            throw new NotImplementedException();
        }

        public void ResultadoConexionSesion(bool resultado)
        {
            throw new NotImplementedException();
        }
    }
}
