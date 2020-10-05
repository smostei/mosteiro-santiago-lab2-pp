using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public sealed class ProductoItem
    {

        private string nombre;
        private Categoria tipo;
        private double precio;

        public ProductoItem(string nombre, Categoria tipo, double precio)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.precio = precio;
        }

        public string Nombre
        {
            get => nombre;
        }

        public string Tipo
        {
            get => tipo.ToString();
        }

        public double Precio
        {
            get => precio;
        }
    }
}
