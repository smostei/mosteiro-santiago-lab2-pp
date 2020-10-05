namespace KiwikEMart
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTotalDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosConMenorStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menorStockDe10UnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridCompras = new System.Windows.Forms.DataGridView();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.nombreEmpleadoTxtBox = new System.Windows.Forms.TextBox();
            this.buscarActionButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.compraToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockTotalDeProductosToolStripMenuItem,
            this.productosConMenorStockToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mostrarToolStripMenuItem.Text = "&Mostrar";
            // 
            // stockTotalDeProductosToolStripMenuItem
            // 
            this.stockTotalDeProductosToolStripMenuItem.Name = "stockTotalDeProductosToolStripMenuItem";
            this.stockTotalDeProductosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.stockTotalDeProductosToolStripMenuItem.Text = "Stock total de productos";
            this.stockTotalDeProductosToolStripMenuItem.Click += new System.EventHandler(this.stockTotalDeProductosToolStripMenuItem_Click);
            // 
            // productosConMenorStockToolStripMenuItem
            // 
            this.productosConMenorStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.menorStockDe10UnidadesToolStripMenuItem});
            this.productosConMenorStockToolStripMenuItem.Name = "productosConMenorStockToolStripMenuItem";
            this.productosConMenorStockToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.productosConMenorStockToolStripMenuItem.Text = "&Productos";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // menorStockDe10UnidadesToolStripMenuItem
            // 
            this.menorStockDe10UnidadesToolStripMenuItem.Name = "menorStockDe10UnidadesToolStripMenuItem";
            this.menorStockDe10UnidadesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.menorStockDe10UnidadesToolStripMenuItem.Text = "Menor stock de 10 unidades";
            this.menorStockDe10UnidadesToolStripMenuItem.Click += new System.EventHandler(this.menorStockDe10UnidadesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dataGridCompras
            // 
            this.dataGridCompras.AllowUserToAddRows = false;
            this.dataGridCompras.AllowUserToDeleteRows = false;
            this.dataGridCompras.AllowUserToResizeColumns = false;
            this.dataGridCompras.AllowUserToResizeRows = false;
            this.dataGridCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCompras.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCompras.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCompras.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridCompras.Location = new System.Drawing.Point(48, 207);
            this.dataGridCompras.Name = "dataGridCompras";
            this.dataGridCompras.ReadOnly = true;
            this.dataGridCompras.Size = new System.Drawing.Size(719, 231);
            this.dataGridCompras.TabIndex = 1;
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Location = new System.Drawing.Point(337, 179);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(93, 13);
            this.labelEmpleado.TabIndex = 2;
            this.labelEmpleado.Text = "Nombre empleado";
            // 
            // nombreEmpleadoTxtBox
            // 
            this.nombreEmpleadoTxtBox.Location = new System.Drawing.Point(436, 176);
            this.nombreEmpleadoTxtBox.Name = "nombreEmpleadoTxtBox";
            this.nombreEmpleadoTxtBox.Size = new System.Drawing.Size(167, 20);
            this.nombreEmpleadoTxtBox.TabIndex = 3;
            // 
            // buscarActionButton
            // 
            this.buscarActionButton.Location = new System.Drawing.Point(609, 176);
            this.buscarActionButton.Name = "buscarActionButton";
            this.buscarActionButton.Size = new System.Drawing.Size(158, 20);
            this.buscarActionButton.TabIndex = 5;
            this.buscarActionButton.Text = "Buscar Compras";
            this.buscarActionButton.UseVisualStyleBackColor = true;
            this.buscarActionButton.Click += new System.EventHandler(this.buscarActionButton_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KiwikEMart.Properties.Resources.apu_logo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscarActionButton);
            this.Controls.Add(this.nombreEmpleadoTxtBox);
            this.Controls.Add(this.labelEmpleado);
            this.Controls.Add(this.dataGridCompras);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuPrincipal";
            this.Text = "Kiwik-E-Mart";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridCompras;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.TextBox nombreEmpleadoTxtBox;
        private System.Windows.Forms.Button buscarActionButton;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTotalDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosConMenorStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menorStockDe10UnidadesToolStripMenuItem;
    }
}

