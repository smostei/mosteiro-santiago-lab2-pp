using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwikEMart
{
    public partial class FormCompra : Form
    {
        private Compra compra;
        private List<ProductoItem> listaItemsCarrito;
        private List<Producto> listaProductosAux;

        private SoundPlayer reproductor;

        public FormCompra()
        {
            InitializeComponent();
            listaItemsCarrito = new List<ProductoItem>();
            listaProductosAux = new List<Producto>();
            reproductor = new SoundPlayer(Properties.Resources.gracias_por_venir);
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            iniciarData();
        }


        private void iniciarData()
        {
            cargarListaClonadaProductos();
            refrescarDataGridProductos();
            
            foreach(Cliente c in RepositorioKiwikEMart.ListaClientes)
            {
                clienteCmbBox.Items.Add(c.NombreYApellido);
            }

            foreach(Empleado e in RepositorioKiwikEMart.ListaEmpleados)
            {
                vendedorCmbBox.Items.Add(e.NombreYApellido);
            }

            alternarColorFilasDataGrid(dataGridProductos);
            alternarColorFilasDataGrid(dataGridCarrito);
        }

        private void carritoButton_Click(object sender, EventArgs e)
        {
            Producto productoAux = (Producto) dataGridProductos.SelectedRows[0].DataBoundItem; //Agarro el primer item, ya que solo se puede seleccionar 1 a la vez

            if(productoAux.StockDisponible > 0)
            {
                productoAux.StockDisponible--; 
                agregarProductoAlCarrito(productoAux);

                refrescarDataGridProductos();
;            }
  
        }

        private void agregarProductoAlCarrito(Producto producto)
        {
            //Pequeño map sobre el producto (el item se mostrará en el carrito)
            ProductoItem item = new ProductoItem(producto.Nombre, producto.Tipo, producto.Precio);
            listaItemsCarrito.Add(item);

            dataGridCarrito.DataSource = null;
            dataGridCarrito.DataSource = listaItemsCarrito;
        }

        private bool activarCarritoButton() =>
            dataGridProductos.SelectedRows[0].Selected;

        private bool activarRealizarCompraButton() =>
            clienteCmbBox.SelectedIndex != -1
            && vendedorCmbBox.SelectedIndex != -1
            && dataGridCarrito.Rows.Count != 0;

        /// <summary>
        /// Este metodo va a crear una lista "auxiliar" ya que se debe trabajar con los productos por valor y no por referencia
        /// </summary>
        private void cargarListaClonadaProductos()
        {
            foreach(Producto p in RepositorioKiwikEMart.ListaProductos)
            {
                listaProductosAux.Add(new Producto(p.Nombre, p.Tipo, p.Precio, p.StockDisponible));
            }
        }
        
        private List<ProductoItem> getListaProductosEnCarrito()
        {
            List<ProductoItem> listaCarrito = new List<ProductoItem>();

            for(int i = 0; i < dataGridCarrito.Rows.Count; i++)
            {
                ProductoItem item = (ProductoItem) dataGridCarrito.Rows[i].DataBoundItem;
                listaCarrito.Add(item);
            }

            return listaCarrito;
        }

        private void alternarColorFilasDataGrid(DataGridView dataGrid)
        {
            dataGrid.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void refrescarDataGridProductos()
        {
            dataGridProductos.DataSource = null;
            dataGridProductos.DataSource = listaProductosAux;
        }

        //Funciona para ambos comboBox (clientes y empleados)
        private void oyenteCmbBox(object sender, EventArgs e)
        {
            realizarCompraButton.Enabled = activarRealizarCompraButton();
        }

        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e) =>
            carritoButton.Enabled = activarCarritoButton();

        private void dataGridCarrito_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) =>
            realizarCompraButton.Enabled = activarRealizarCompraButton();

        private void realizarCompraButton_Click(object sender, EventArgs e)
        {
            List<ProductoItem> listaCarrito = getListaProductosEnCarrito();

            if(listaCarrito != null)
            {
                compra = new Compra(
                        RepositorioKiwikEMart.getClientePorNombreYApellido(clienteCmbBox.SelectedItem.ToString()),
                        RepositorioKiwikEMart.getEmpleadoPorNombreYApellido(vendedorCmbBox.SelectedItem.ToString()),
                        listaCarrito
                    );

                RepositorioKiwikEMart.ListaCompras.Add(compra);

                //Piso la lista de productos de verdad con la que se usó para comprar
                RepositorioKiwikEMart.ListaProductos = listaProductosAux;

                reproductor.Play();
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }

}
