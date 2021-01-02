using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMemorama.ModeloDummy
{
    class Usuario
    {
        protected string NombreUsuario { get; set; }
        protected string Contrasena { get; set; }

        public Usuario() { }
        public Usuario(string usuario, string contrasena)
        {
            NombreUsuario = usuario;
            Contrasena = contrasena;
        }
    }
}
