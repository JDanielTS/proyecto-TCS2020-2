using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMemorama
{
    public class UsuariosDB 
    {
        
        public void GuardarUsuario(Usuario usuario)
        {
            using (var entidadesDB = new MemoramaBDEntities())
            {
                entidadesDB.Usuario.Add(usuario);
                entidadesDB.SaveChanges();
            }
        }

        public Usuario BuscarUsuarioNombre(string nombreusuario)
        {
            return null;
        }

        public Usuario BuscarUsuarioCorreo(string correo)
        {
            return null;
        }


    }
}
