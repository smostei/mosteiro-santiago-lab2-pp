namespace KiwikEMart
{
    partial class FormCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloCompra = new System.Windows.Forms.Label();
            this.vendedorLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vendedorCmbBox = new System.Windows.Forms.ComboBox();
            this.clienteCmbBox = new System.Windows.Forms.ComboBox();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.dataGridCarrito = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.realizarCompraButton = new System.Windows.Forms.Button();
            this.carritoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloCompra
            // 
            this.tituloCompra.AutoSize = true;
            this.tituloCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloCompra.Location = new System.Drawing.Point(223, 22);
            this.tituloCompra.Name = "tituloCompra";
            this.tituloCompra.Size = new System.Drawing.Size(361, 24);
            this.tituloCompra.TabIndex = 1;
            this.tituloCompra.Text = "Complete los datos para la compra";
            // 
            // vendedorLbl
            // 
            this.vendedorLbl.AutoSize = true;
            this.vendedorLbl.Location = new System.Drawing.Point(12, 81);
            this.vendedorLbl.Name = "vendedorLbl";
            this.vendedorLbl.Size = new System.Drawing.Size(53, 13);
            this.vendedorLbl.TabIndex = 2;
            this.vendedorLbl.Text = "Vendedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // vendedorCmbBox
            // 
            this.vendedorCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendedorCmbBox.FormattingEnabled = true;
            this.vendedorCmbBox.Location = new System.Drawing.Point(84, 78);
            this.vendedorCmbBox.Name = "vendedorCmbBox";
            this.vendedorCmbBox.Size = new System.Drawing.Size(201, 21);
            this.vendedorCmbBox.TabIndex = 4;
            this.vendedorCmbBox.SelectedIndexChanged += new System.EventHandler(this.oyenteCmbBox);
            // 
            // clienteCmbBox
            // 
            this.clienteCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteCmbBox.FormattingEnabled = true;
            this.clienteCmbBox.Location = new System.Drawing.Point(362, 78);
            this.clienteCmbBox.Name = "clienteCmbBox";
            this.clienteCmbBox.Size = new System.Drawing.Size(201, 21);
            this.clienteCmbBox.TabIndex = 5;
            this.clienteCmbBox.SelectedIndexChanged += new System.EventHandler(this.oyenteCmbBox);
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToAddRows = false;
            this.dataGridProductos.AllowUserToDeleteRows = false;
            this.dataGridProductos.AllowUserToResizeColumns = false;
            this.dataGridProductos.AllowUserToResizeRows = false;
            this.dataGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(12, 142);
            this.dataGridProductos.MultiSelect = false;
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProductos.Size = new System.Drawing.Size(377, 257);
            this.dataGridProductos.TabIndex = 6;
            this.dataGridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductos_CellClick);
            // 
            // dataGridCarrito
            // 
            this.dataGridCarrito.AllowDrop = true;
            this.dataGridCarrito.AllowUserToAddRows = false;
            this.dataGridCarrito.AllowUserToDeleteRows = false;
            this.dataGridCarrito.AllowUserToResizeColumns = false;
            this.dataGridCarrito.AllowUserToResizeRows = false;
            this.dataGridCarrito.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridCarrito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarrito.Location = new System.Drawing.Point(411, 142);
            this.dataGridCarrito.Name = "dataGridCarrito";
            this.dataGridCarrito.Size = new System.Drawing.Size(377, 257);
            this.dataGridCarrito.TabIndex = 7;
            this.dataGridCarrito.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridCarrito_RowsAdded);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Productos disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Productos en carrito";
            // 
            // realizarCompraButton
            // 
            this.realizarCompraButton.Enabled = false;
            this.realizarCompraButton.Location = new System.Drawing.Point(285, 432);
            this.realizarCompraButton.Name = "realizarCompraButton";
            this.realizarCompraButton.Size = new System.Drawing.Size(232, 23);
            this.realizarCompraButton.TabIndex = 10;
            this.realizarCompraButton.Text = "Realizar compra";
            this.realizarCompraButton.UseVisualStyleBackColor = true;
            this.realizarCompraButton.Click += new System.EventHandler(this.realizarCompraButton_Click);
            // 
            // carritoButton
            // 
            this.carritoButton.Enabled = false;
            this.carritoButton.Location = new System.Drawing.Point(349, 113);
            this.carritoButton.Name = "carritoButton";
            this.carritoButton.Size = new System.Drawing.Size(104, 23);
            this.carritoButton.TabIndex = 11;
            this.carritoButton.Text = "Agregar al carrito";
            this.carritoButton.UseVisualStyleBackColor = true;
            this.carritoButton.Click += new System.EventHandler(this.carritoButton_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.carritoButton);
            this.Controls.Add(this.realizarCompraButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridCarrito);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.clienteCmbBox);
            this.Controls.Add(this.vendedorCmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendedorLbl);
            this.Controls.Add(this.tituloCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCompra";
            this.Text = "Nueva compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloCompra;
        private System.Windows.Forms.Label vendedorLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vendedorCmbBox;
        private System.Windows.Forms.ComboBox clienteCmbBox;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.DataGridView dataGridCarrito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button realizarCompraButton;
        private System.Windows.Forms.Button carritoButton;
    }
}