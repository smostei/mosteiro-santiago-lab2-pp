using Data;
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
    public partial class FormListadoProductos : Form
    {
        public FormListadoProductos()
        {
            InitializeComponent();
        }
        private void ListadoProductosForm_Load(object sender, EventArgs e)
        {
            tituloProductos.Text = FormTitle;
            IniciarDataSource();
        }

        protected virtual string FormTitle
        {
            get => "Listado de todos los productos";
        }

        protected virtual void IniciarDataSource()
        {
            dataGridProductos.BorderStyle = BorderStyle.Fixed3D;
            dataGridProductos.DataSource = RepositorioKiwikEMart.ListaProductos;
        }

    }
}
