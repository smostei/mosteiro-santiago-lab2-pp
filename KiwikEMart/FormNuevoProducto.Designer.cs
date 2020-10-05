namespace KiwikEMart
{
    partial class FormNuevoProducto
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
            this.tituloProducto = new System.Windows.Forms.Label();
            this.nombreProductoLbl = new System.Windows.Forms.Label();
            this.precioProductoLbl = new System.Windows.Forms.Label();
            this.stockProductoLbl = new System.Windows.Forms.Label();
            this.categoriaProductoLbl = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.cmbCategoriaProductos = new System.Windows.Forms.ComboBox();
            this.stockTxtBox = new System.Windows.Forms.TextBox();
            this.precioTxtBox = new System.Windows.Forms.TextBox();
            this.nombreTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tituloProducto
            // 
            this.tituloProducto.AutoSize = true;
            this.tituloProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloProducto.Location = new System.Drawing.Point(53, 24);
            this.tituloProducto.Name = "tituloProducto";
            this.tituloProducto.Size = new System.Drawing.Size(268, 24);
            this.tituloProducto.TabIndex = 1;
            this.tituloProducto.Text = "Información del producto";
            // 
            // nombreProductoLbl
            // 
            this.nombreProductoLbl.AutoSize = true;
            this.nombreProductoLbl.Location = new System.Drawing.Point(54, 71);
            this.nombreProductoLbl.Name = "nombreProductoLbl";
            this.nombreProductoLbl.Size = new System.Drawing.Size(44, 13);
            this.nombreProductoLbl.TabIndex = 2;
            this.nombreProductoLbl.Text = "Nombre";
            // 
            // precioProductoLbl
            // 
            this.precioProductoLbl.AutoSize = true;
            this.precioProductoLbl.Location = new System.Drawing.Point(54, 106);
            this.precioProductoLbl.Name = "precioProductoLbl";
            this.precioProductoLbl.Size = new System.Drawing.Size(37, 13);
            this.precioProductoLbl.TabIndex = 3;
            this.precioProductoLbl.Text = "Precio";
            // 
            // stockProductoLbl
            // 
            this.stockProductoLbl.AutoSize = true;
            this.stockProductoLbl.Location = new System.Drawing.Point(54, 139);
            this.stockProductoLbl.Name = "stockProductoLbl";
            this.stockProductoLbl.Size = new System.Drawing.Size(85, 13);
            this.stockProductoLbl.TabIndex = 4;
            this.stockProductoLbl.Text = "Stock disponible";
            // 
            // categoriaProductoLbl
            // 
            this.categoriaProductoLbl.AutoSize = true;
            this.categoriaProductoLbl.Location = new System.Drawing.Point(54, 172);
            this.categoriaProductoLbl.Name = "categoriaProductoLbl";
            this.categoriaProductoLbl.Size = new System.Drawing.Size(54, 13);
            this.categoriaProductoLbl.TabIndex = 5;
            this.categoriaProductoLbl.Text = "Categoría";
            // 
            // agregarButton
            // 
            this.agregarButton.Enabled = false;
            this.agregarButton.Location = new System.Drawing.Point(57, 261);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(309, 23);
            this.agregarButton.TabIndex = 5;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // cmbCategoriaProductos
            // 
            this.cmbCategoriaProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaProductos.FormattingEnabled = true;
            this.cmbCategoriaProductos.Location = new System.Drawing.Point(150, 169);
            this.cmbCategoriaProductos.Name = "cmbCategoriaProductos";
            this.cmbCategoriaProductos.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaProductos.TabIndex = 4;
            this.cmbCategoriaProductos.SelectedIndexChanged += new System.EventHandler(this.oyenteTextosCambiados);
            // 
            // stockTxtBox
            // 
            this.stockTxtBox.Location = new System.Drawing.Point(150, 136);
            this.stockTxtBox.Name = "stockTxtBox";
            this.stockTxtBox.Size = new System.Drawing.Size(121, 20);
            this.stockTxtBox.TabIndex = 3;
            this.stockTxtBox.TextChanged += new System.EventHandler(this.oyenteTextosCambiados);
            this.stockTxtBox.Leave += new System.EventHandler(this.oyenteFocoSalidaTextos);
            // 
            // precioTxtBox
            // 
            this.precioTxtBox.Location = new System.Drawing.Point(150, 103);
            this.precioTxtBox.Name = "precioTxtBox";
            this.precioTxtBox.Size = new System.Drawing.Size(121, 20);
            this.precioTxtBox.TabIndex = 2;
            this.precioTxtBox.TextChanged += new System.EventHandler(this.oyenteTextosCambiados);
            this.precioTxtBox.Leave += new System.EventHandler(this.oyenteFocoSalidaTextos);
            // 
            // nombreTxtBox
            // 
            this.nombreTxtBox.Location = new System.Drawing.Point(150, 71);
            this.nombreTxtBox.Name = "nombreTxtBox";
            this.nombreTxtBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTxtBox.TabIndex = 1;
            this.nombreTxtBox.TextChanged += new System.EventHandler(this.oyenteTextosCambiados);
            this.nombreTxtBox.Leave += new System.EventHandler(this.oyenteFocoSalidaTextos);
            // 
            // FormNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(404, 311);
            this.Controls.Add(this.nombreTxtBox);
            this.Controls.Add(this.precioTxtBox);
            this.Controls.Add(this.stockTxtBox);
            this.Controls.Add(this.cmbCategoriaProductos);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.categoriaProductoLbl);
            this.Controls.Add(this.stockProductoLbl);
            this.Controls.Add(this.precioProductoLbl);
            this.Controls.Add(this.nombreProductoLbl);
            this.Controls.Add(this.tituloProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNuevoProducto";
            this.Text = "Nuevo producto";
            this.Load += new System.EventHandler(this.FormNuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloProducto;
        private System.Windows.Forms.Label nombreProductoLbl;
        private System.Windows.Forms.Label precioProductoLbl;
        private System.Windows.Forms.Label stockProductoLbl;
        private System.Windows.Forms.Label categoriaProductoLbl;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.ComboBox cmbCategoriaProductos;
        private System.Windows.Forms.TextBox stockTxtBox;
        private System.Windows.Forms.TextBox precioTxtBox;
        private System.Windows.Forms.TextBox nombreTxtBox;
    }
}