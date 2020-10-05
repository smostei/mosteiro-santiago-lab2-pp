using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public sealed class Compra
    {
        private static int id;
        private Cliente cliente;
        private Empleado vendedor;
        private List<ProductoItem> listaProductosComprados;

        public Compra(Cliente cliente, Empleado vendedor, List<ProductoItem> listaProductosComprados)
        {
            id++;
            this.cliente = cliente;
            this.vendedor = vendedor;
            this.listaProductosComprados = listaProductosComprados;
        }

        static Compra()
        {
            id = 0;
        }

        public String NombreVendedor
        {
            get => vendedor.Nombre;
        }
        
        public int DniCliente
        {
            get => cliente.Dni;
        }

        public String ListaProductosComprados
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach(ProductoItem p in listaProductosComprados)
                {
                    sb.AppendLine($"NOMBRE: {p.Nombre}, TIPO: {p.Tipo}, PRECIO: ${p.Precio}");
                }

                return sb.ToString();
            }
        }
        public string MontoFinal
        {
            get
            {
                double montoFinal = GetMontoProductos();

                if (cliente.EsFamiliarSimpson)
                {
                    double descuento = GetMontoProductos() * 0.13;
                    montoFinal -= descuento;
                }

                return "$" + montoFinal;
            }
        }

        public double GetMontoProductos()
        {
            double montoTotal = 0;

            foreach(ProductoItem p in listaProductosComprados)
            {
                montoTotal += p.Precio;
            }

            return montoTotal;
        }

    }
}
