using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public sealed class Empleado : Persona
    {
        private string nombreUsuario;
        private string passUsuario;

        public Empleado(string nombre, string apellido, int dni, string nombreUsuario, string passUsuario)
            : base(nombre, apellido, dni)
        {
            this.nombreUsuario = nombreUsuario;
            this.passUsuario = passUsuario;
        }
     
    }
}
