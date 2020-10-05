using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace KiwikEMart
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            RepositorioKiwikEMart.iniciarClientes();
            RepositorioKiwikEMart.iniciarEmpleados();
            RepositorioKiwikEMart.iniciarProductos();
            RepositorioKiwikEMart.iniciarCompras();

            //Ni bien se inicia la app, se settea este gridView con las compras totales
            dataGridCompras.DataSource = RepositorioKiwikEMart.ListaCompras;
            dataGridCompras.BorderStyle = BorderStyle.Fixed3D;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(new FormNuevoCliente().ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(
                    "Se agregó el cliente correctamente!",
                    "Confirmación"
                );
            } else
            {
                mostrarMensajeError("No se pudo agregar el cliente :/");
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new FormNuevoProducto().ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(
                    "Se agregó el producto correctamente!",
                    "Confirmación"
                );
            }
            else
            {
                mostrarMensajeError("No se pudo agregar el producto :/");
            }
        }

        private void mostrarMensajeError(string mensaje)
            => MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Desea salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buscarActionButton_Click(object sender, EventArgs e)
        {
            dataGridCompras.DataSource = null;
            dataGridCompras.DataSource =
                RepositorioKiwikEMart.getComprasPorEmpleado(nombreEmpleadoTxtBox.Text);
        }        
        private void refrescarListaCompras()
        {
            dataGridCompras.DataSource = null;
            dataGridCompras.DataSource =
                RepositorioKiwikEMart.ListaCompras;
        }

        private void stockTotalDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                 $"El stock total de productos es de {RepositorioKiwikEMart.getTotalStockProductos()} unidades.",
                 "Stock disponible de productos",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e) =>
            new FormListadoProductos().Show();

        private void menorStockDe10UnidadesToolStripMenuItem_Click(object sender, EventArgs e) =>
            new FormListadoProductosMenorStock().Show();

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(new FormCompra().ShowDialog() == DialogResult.OK)
            {
                refrescarListaCompras();
                MessageBox.Show(
                       "Gracias!! Vuelva prontosss",
                       "Confirmación de compra"
                );
            } else
            {
                mostrarMensajeError("No se pudo realizar la compra :/");
            }
        }
    }
}
