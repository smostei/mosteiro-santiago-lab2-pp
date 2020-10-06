using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public sealed class Compra
    {
        private static int ID_AUX;

        private int id;
        private Cliente cliente;
        private Empleado vendedor;
        private List<ProductoItem> listaProductosComprados;

        public Compra(Cliente cliente, Empleado vendedor, List<ProductoItem> listaProductosComprados)
        {
            ID_AUX++;
            this.id = ID_AUX;
            this.cliente = cliente;
            this.vendedor = vendedor;
            this.listaProductosComprados = listaProductosComprados;
        }

        static Compra()
        {
            ID_AUX = 0;
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
            get //De esta manera, se mostraran los productos comprados en el data grid view
            {
                StringBuilder sb = new StringBuilder();

                foreach(ProductoItem p in listaProductosComprados)
                {
                    sb.AppendLine($"NOMBRE: {p.Nombre}, TIPO: {p.Tipo}, PRECIO: ${p.Precio}");
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// El monto final puede ir con un descuento del 13% si el cliente es de la familia Simpson
        /// </summary>
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

        /// <summary>
        /// Retorna el monto total de la lista de productos que van a estar en el carrito
        /// </summary>
        /// <returns></returns>
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
