using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Data
{
    public static class RepositorioKiwikEMart
    {
        private static List<Producto> listaProductos;
        private static List<Empleado> listaEmpleados; 
        private static List<Compra> listaCompras;
        private static List<Cliente> listaClientes;

        static RepositorioKiwikEMart()
        {
            //Inicio toda la fuente de datos
            listaProductos = new List<Producto>();
            listaEmpleados = new List<Empleado>();
            listaCompras = new List<Compra>();
            listaClientes = new List<Cliente>();
        }

        public static List<Producto> ListaProductos
        {
            get //Cuando haga un get de la lista de productos, solo me traerá los que tienen stock
            {
                List<Producto> listaProductosConStock = new List<Producto>();

                foreach(Producto p in listaProductos)
                {
                    if(p.StockDisponible > 0)
                    {
                        listaProductosConStock.Add(p);
                    }
                }

                return listaProductosConStock;
            }

            set => listaProductos = value;
        }

        public static List<Empleado> ListaEmpleados
        {
            get => listaEmpleados;
        }

        public static List<Compra> ListaCompras
        {
            get => listaCompras;
        }

        public static List<Cliente> ListaClientes
        {
            get => listaClientes;
        }

        public static void iniciarProductos()
        {
            //Hardcodear 30 productos para iniciar la aplicación con stock
            listaProductos.Add(new Producto("Vino toro", Categoria.Bebida, 45.0, 8));
            listaProductos.Add(new Producto("Cerveza Duff", Categoria.Bebida, 35.0, 14));
            listaProductos.Add(new Producto("Vodka", Categoria.Bebida, 60.5, 6));
            listaProductos.Add(new Producto("Muzzarella", Categoria.Lacteo, 70.0, 10));
            listaProductos.Add(new Producto("Salame fiambre", Categoria.Comida, 55.5, 5));
            listaProductos.Add(new Producto("Jamon fiambre", Categoria.Comida, 65.5, 9));
            listaProductos.Add(new Producto("Queso roquefort", Categoria.Lacteo, 48.0, 12));
            listaProductos.Add(new Producto("Jugo Baggio", Categoria.Bebida, 55.0, 25));
            listaProductos.Add(new Producto("Jugo Cepita", Categoria.Bebida, 60.0, 24));
            listaProductos.Add(new Producto("Redbull", Categoria.Bebida, 100.0, 5));
            listaProductos.Add(new Producto("Fideos mostacholes", Categoria.Comida, 25.0, 14));
            listaProductos.Add(new Producto("Ravioles", Categoria.Comida, 42.0, 16));
            listaProductos.Add(new Producto("Noquis", Categoria.Comida, 38.5, 11));
            listaProductos.Add(new Producto("Salsa de tomate", Categoria.Verduleria, 27.5, 42));
            listaProductos.Add(new Producto("Manzanas", Categoria.Verduleria, 30.0, 29));
            listaProductos.Add(new Producto("Naranjas", Categoria.Verduleria, 38.9, 33));
            listaProductos.Add(new Producto("Leche", Categoria.Lacteo, 58.0, 19));
            listaProductos.Add(new Producto("Yogurt", Categoria.Lacteo, 80.0, 8));
            listaProductos.Add(new Producto("Manteca", Categoria.Lacteo, 72.5, 20));
            listaProductos.Add(new Producto("Hamburguesas", Categoria.Comida, 120.0, 11));
            listaProductos.Add(new Producto("Salchichas", Categoria.Comida, 82.0, 17));
            listaProductos.Add(new Producto("Alfajor", Categoria.Comida, 25.0, 12));
            listaProductos.Add(new Producto("Barrita de Cereal", Categoria.Comida, 18.0, 34));
            listaProductos.Add(new Producto("Rollo de cocina", Categoria.Limpieza, 39.0, 56));
            listaProductos.Add(new Producto("Papel higienico", Categoria.Limpieza, 42.5, 47));
            listaProductos.Add(new Producto("Palta", Categoria.Verduleria, 150.0, 12));
            listaProductos.Add(new Producto("Queso Mar del Plata", Categoria.Lacteo, 170.0, 9));
            listaProductos.Add(new Producto("Carne", Categoria.Comida, 220.0, 19));
            listaProductos.Add(new Producto("Pollo", Categoria.Comida, 135.5, 7));
            listaProductos.Add(new Producto("Carne de cerdo", Categoria.Comida, 170.5, 15));
        }

        public static void iniciarEmpleados()
        {
            //Unicos dos empleados de la tienda
            listaEmpleados.Add(new Empleado("Apu", "Nahasapeemapetilon", 24500346, "apu", "1234"));
            listaEmpleados.Add(new Empleado("Sanjay", "Nahasapeemapetilon", 17490312, "sanjay", "4321"));
        }

        public static void iniciarClientes()
        {
            //A primera instancia, solo tendremos estos 3 clientes
            listaClientes.Add(new Cliente("Homero", "Simpson", 25170875));
            listaClientes.Add(new Cliente("Milhouse", "Van Houten", 50230213));
            listaClientes.Add(new Cliente("Ned", "Flanders", 16658126));
        }

        public static void iniciarCompras()
        {
            List<ProductoItem> productosComprados = new List<ProductoItem>();
            productosComprados.Add(new ProductoItem("Carne", Categoria.Comida, 225.5));
            productosComprados.Add(new ProductoItem("Pollo", Categoria.Comida, 165.0));
            productosComprados.Add(new ProductoItem("Vino Toro", Categoria.Bebida, 25.0));


            //Hardcodeando algunas compras para iniciar la aplicación
            listaCompras.Add(new Compra(listaClientes[0], listaEmpleados[0], productosComprados));
            listaCompras.Add(new Compra(listaClientes[2], listaEmpleados[0], productosComprados));
            listaCompras.Add(new Compra(listaClientes[0], listaEmpleados[1], productosComprados));
            listaCompras.Add(new Compra(listaClientes[1], listaEmpleados[0], productosComprados));
            listaCompras.Add(new Compra(listaClientes[2], listaEmpleados[0], productosComprados));
            listaCompras.Add(new Compra(listaClientes[1], listaEmpleados[1], productosComprados));
            listaCompras.Add(new Compra(listaClientes[2], listaEmpleados[1], productosComprados));
            listaCompras.Add(new Compra(listaClientes[0], listaEmpleados[0], productosComprados));
            listaCompras.Add(new Compra(listaClientes[2], listaEmpleados[0], productosComprados));
            listaCompras.Add(new Compra(listaClientes[0], listaEmpleados[1], productosComprados));
        }

        /// <summary>
        /// Agregar un producto a la lista
        /// </summary>
        /// <param name="producto"></param>
        public static void agregarProducto(Producto producto) => listaProductos.Add(producto);

        /// <summary>
        /// Agregar un cliente a la lista
        /// </summary>
        /// <param name="cliente"></param>
        public static void agregarCliente(Cliente cliente) => listaClientes.Add(cliente);

        /// <summary>
        /// Devuelve una lista de productos con aquellos productos que tengan un stock menor a 10
        /// </summary>
        /// <returns></returns>
        public static List<Producto> GetProductosConStockMenorDiez()
        {
            List<Producto> listaFiltrada = new List<Producto>();

            foreach(Producto p in listaProductos)
            {
                if(p.StockDisponible < 10)
                {
                    listaFiltrada.Add(p);
                }
            }

            return listaFiltrada;
        }

        /// <summary>
        /// Devuelve el stock total de todos los productos
        /// </summary>
        /// <returns></returns>
        public static int getTotalStockProductos()
        {
            int stockTotal = 0;

            foreach(Producto p in listaProductos)
            {
                stockTotal += p.StockDisponible;
            }

            return stockTotal;
        }

        /// <summary>
        /// Retorna una lista con todas las compras segun un empleado
        /// </summary>
        /// <param name="nombreEmpleado"></param>
        /// <returns></returns>
        public static List<Compra> getComprasPorEmpleado(string nombreEmpleado)
        {
            List<Compra> listaFiltrada = new List<Compra>();

            foreach(Compra compra in listaCompras)
            {
                if(compra.NombreVendedor == nombreEmpleado)
                {
                    listaFiltrada.Add(compra);
                }
            }

            return listaFiltrada;
        }

        /// <summary>
        /// Devuelve un objeto de tipo Empleado segun su nombre y apellido
        /// </summary>
        /// <param name="nombreYApellido"></param>
        /// <returns></returns>
        public static Empleado getEmpleadoPorNombreYApellido(string nombreYApellido)
        {
            Empleado emp = null;

            foreach(Empleado e in listaEmpleados)
            {
                if(String.Equals(e.NombreYApellido, nombreYApellido))
                {
                    emp = e;
                    break;
                }
            }

            return emp;
        }

        /// <summary>
        /// Devuelve un objeto de tipo Cliente segun su nombre y apellido
        /// </summary>
        /// <param name="nombreYApellido"></param>
        /// <returns></returns>
        public static Cliente getClientePorNombreYApellido(string nombreYApellido)
        {
            Cliente cliente = null;

            foreach (Cliente c in listaClientes)
            {
                if (String.Equals(c.NombreYApellido, nombreYApellido))
                {
                    cliente = c;
                    break;
                }
            }

            return cliente;
        }

    }
}
