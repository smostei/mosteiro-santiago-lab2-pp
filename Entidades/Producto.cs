using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum Categoria
    {
        Lacteo,
        Comida,
        Verduleria,
        Limpieza,
        Bebida
    }
    public sealed class Producto
    {
        private static int ID_AUX;

        private int id;
        private string nombre;
        private Categoria tipo;
        private double precio;
        private int stockDisponible;
        public Producto(string nombre, Categoria tipo, double precio, int stockDisponible)
        {
            ID_AUX++;
            this.id = ID_AUX;
            this.nombre = nombre;
            this.tipo = tipo;
            this.precio = precio;
            this.stockDisponible = stockDisponible;
        }

        static Producto()
        {
            ID_AUX = 0;
        }

        public int Id
        {
            get => id;
        }

        public string Nombre
        {
            get => nombre;
        }

        public Categoria Tipo
        {
            get => tipo;
        }

        public double Precio
        {
            get => precio;
        }

        public int StockDisponible
        {
            get => stockDisponible;
            set => stockDisponible = value;
        }

        public static bool operator ==(Producto producto, List<Producto> listaProductos)
        {
            foreach(Producto p in listaProductos)
            {
                if(String.Equals(p.nombre, producto.nombre))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Producto producto, List<Producto> listaProductos) =>
            !(producto == listaProductos);
    }
}
