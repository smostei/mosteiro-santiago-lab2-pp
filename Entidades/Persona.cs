using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public int Dni
        {
            get => dni;
        }

        public string Nombre
        {
            get => nombre;
        }

        public string NombreYApellido
        {
            get => $"{nombre} {apellido}";
        }

        public static bool operator ==(Persona persona, List<Persona> listaPersonas)
        {
            foreach (Persona p in listaPersonas)
            {
                if (persona.dni == p.dni)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Persona persona, List<Persona> listaPersonas) =>
            !(persona == listaPersonas);
    }
}
