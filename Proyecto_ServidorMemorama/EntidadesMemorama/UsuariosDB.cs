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
            Usuario usuarioEncontrado = null;
            using (var entidadesDB = new MemoramaBDEntities())
            {
                var usuarioDB = entidadesDB.Usuario
                    .Where(x => x.nombreUsuario == nombreusuario)
                    .ToList();
                if (usuarioDB != null)
                {
                    usuarioEncontrado = usuarioDB[0];
                }
            }
            return usuarioEncontrado;
        }

        public Usuario BuscarUsuarioCorreo(string correo)
        {
            Usuario usuarioEncontrado = null;
            using (var entidadesDB = new MemoramaBDEntities())
            {
                var usuarioDB = entidadesDB.Usuario
                    .Where(x => x.correoUsuario == correo)
                    .ToList();
                if (usuarioDB != null)
                {
                    usuarioEncontrado = usuarioDB[0];
                }
            }
            return usuarioEncontrado;
        }


    }
}
