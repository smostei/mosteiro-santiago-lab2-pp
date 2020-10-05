using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwikEMart
{
    public partial class FormNuevoProducto : Form
    {
        private Producto producto; 

        public FormNuevoProducto()
        {
            InitializeComponent();
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            cmbCategoriaProductos.DataSource =
                Enum.GetValues(typeof(Categoria));

            cmbCategoriaProductos.SelectedIndex = -1;
        }

        private bool activarBotonContinuar() =>
            !(
                cmbCategoriaProductos.SelectedIndex == -1
                || String.IsNullOrWhiteSpace(nombreTxtBox.Text)
                || String.IsNullOrWhiteSpace(precioTxtBox.Text)
                || String.IsNullOrWhiteSpace(stockTxtBox.Text)
            );

        private void oyenteTextosCambiados(object sender, EventArgs e) =>
            agregarButton.Enabled = activarBotonContinuar();

        private void oyenteFocoSalidaTextos(object sender, EventArgs e) =>
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();

        private void agregarButton_Click(object sender, EventArgs e)
        {
            double auxPrecio;
            double.TryParse(precioTxtBox.Text, out auxPrecio);

            int auxStock;
            int.TryParse(stockTxtBox.Text, out auxStock);

            if (auxPrecio == 0 || auxStock == 0)
            {
                MessageBox.Show(
                        "Fijate que todos los valores estén bien puestos",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                return;
            }

            producto = new Producto(
                    nombreTxtBox.Text,
                    (Categoria)Enum.Parse(typeof(Categoria), cmbCategoriaProductos.SelectedValue.ToString()),
                    auxPrecio,
                    auxStock
                );

            if(producto == RepositorioKiwikEMart.ListaProductos)
            {
                this.DialogResult = DialogResult.Cancel;
            } else
            {
                RepositorioKiwikEMart.agregarProducto(producto);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
