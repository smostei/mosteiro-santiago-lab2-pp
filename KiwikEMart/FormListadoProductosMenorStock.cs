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
    public partial class FormListadoProductosMenorStock : FormListadoProductos
    {
        public FormListadoProductosMenorStock(): base() {}
        protected override string FormTitle => "Listado de productos con menor stock a 10";

        protected override void IniciarDataSource()
        {
            base.IniciarDataSource();
            dataGridProductos.DataSource = RepositorioKiwikEMart.GetProductosConStockMenorDiez();
        }
    }
}
