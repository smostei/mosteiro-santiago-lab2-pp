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
    public partial class FormNuevoCliente : Form
    {
        private Cliente cliente;
        public FormNuevoCliente()
        {
            InitializeComponent();
        }
  
        private void FormNuevoCliente_Load(object sender, EventArgs e)
        {
            agregarButton.Enabled = false;
        }
        private void OyenteTextosCambiados(object sender, EventArgs e) =>
            agregarButton.Enabled = activarBotonContinuar();
        
        private bool activarBotonContinuar() =>
            !(
              String.IsNullOrWhiteSpace(nombreTxtBox.Text)
              || String.IsNullOrWhiteSpace(apellidoTxtBox.Text)
              || String.IsNullOrWhiteSpace(dniTxtBox.Text)
            );
                
        private void OyenteTextosLeave(object sender, EventArgs e) => 
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();

        private void agregarButton_Click(object sender, EventArgs e)
        {
            int auxDni;
            int.TryParse(dniTxtBox.Text, out auxDni);

            if(auxDni == 0)
            {
                MessageBox.Show(
                         "Fijate que todos los valores estén bien puestos",
                         "Advertencia",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning
                      );

                return;
            }

            cliente = new Cliente(nombreTxtBox.Text, apellidoTxtBox.Text, auxDni);

            if(cliente == RepositorioKiwikEMart.ListaClientes)
            {
                this.DialogResult = DialogResult.Cancel;
            } else
            {
                this.DialogResult = DialogResult.OK;
                RepositorioKiwikEMart.ListaClientes.Add(cliente);
            }
        }
        
    }
}
