using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public sealed class Cliente : Persona
    {
        private List<Producto> listaCompras;

        public Cliente(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            listaCompras = new List<Producto>();
        }

        public bool EsFamiliarSimpson
        {
            get => apellido.Equals("Simpson");
        }

        public static bool operator ==(Cliente cliente, List<Cliente> listaClientes)
        {
            foreach (Cliente c in listaClientes)
            {
                if (cliente.dni == c.dni)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Cliente cliente, List<Cliente> listaClientes) =>
            !(cliente == listaClientes);
    }
}
