namespace KiwikEMart
{
    partial class FormNuevoCliente
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
            this.tituloCliente = new System.Windows.Forms.Label();
            this.nombreClienteLbl = new System.Windows.Forms.Label();
            this.apellidoClienteLbl = new System.Windows.Forms.Label();
            this.dniClienteLbl = new System.Windows.Forms.Label();
            this.nombreTxtBox = new System.Windows.Forms.TextBox();
            this.apellidoTxtBox = new System.Windows.Forms.TextBox();
            this.dniTxtBox = new System.Windows.Forms.TextBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloCliente
            // 
            this.tituloCliente.AutoSize = true;
            this.tituloCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloCliente.Location = new System.Drawing.Point(32, 29);
            this.tituloCliente.Name = "tituloCliente";
            this.tituloCliente.Size = new System.Drawing.Size(313, 24);
            this.tituloCliente.TabIndex = 0;
            this.tituloCliente.Text = "Complete los datos del cliente";
            // 
            // nombreClienteLbl
            // 
            this.nombreClienteLbl.AutoSize = true;
            this.nombreClienteLbl.Location = new System.Drawing.Point(33, 102);
            this.nombreClienteLbl.Name = "nombreClienteLbl";
            this.nombreClienteLbl.Size = new System.Drawing.Size(44, 13);
            this.nombreClienteLbl.TabIndex = 1;
            this.nombreClienteLbl.Text = "Nombre";
            // 
            // apellidoClienteLbl
            // 
            this.apellidoClienteLbl.AutoSize = true;
            this.apellidoClienteLbl.Location = new System.Drawing.Point(33, 146);
            this.apellidoClienteLbl.Name = "apellidoClienteLbl";
            this.apellidoClienteLbl.Size = new System.Drawing.Size(44, 13);
            this.apellidoClienteLbl.TabIndex = 2;
            this.apellidoClienteLbl.Text = "Apellido";
            // 
            // dniClienteLbl
            // 
            this.dniClienteLbl.AutoSize = true;
            this.dniClienteLbl.Location = new System.Drawing.Point(33, 187);
            this.dniClienteLbl.Name = "dniClienteLbl";
            this.dniClienteLbl.Size = new System.Drawing.Size(26, 13);
            this.dniClienteLbl.TabIndex = 3;
            this.dniClienteLbl.Text = "DNI";
            // 
            // nombreTxtBox
            // 
            this.nombreTxtBox.Location = new System.Drawing.Point(98, 102);
            this.nombreTxtBox.Name = "nombreTxtBox";
            this.nombreTxtBox.Size = new System.Drawing.Size(134, 20);
            this.nombreTxtBox.TabIndex = 4;
            this.nombreTxtBox.TextChanged += new System.EventHandler(this.OyenteTextosCambiados);
            this.nombreTxtBox.Leave += new System.EventHandler(this.OyenteTextosLeave);
            // 
            // apellidoTxtBox
            // 
            this.apellidoTxtBox.Location = new System.Drawing.Point(98, 143);
            this.apellidoTxtBox.Name = "apellidoTxtBox";
            this.apellidoTxtBox.Size = new System.Drawing.Size(134, 20);
            this.apellidoTxtBox.TabIndex = 5;
            this.apellidoTxtBox.TextChanged += new System.EventHandler(this.OyenteTextosCambiados);
            this.apellidoTxtBox.Leave += new System.EventHandler(this.OyenteTextosLeave);
            // 
            // dniTxtBox
            // 
            this.dniTxtBox.Location = new System.Drawing.Point(98, 184);
            this.dniTxtBox.Name = "dniTxtBox";
            this.dniTxtBox.Size = new System.Drawing.Size(134, 20);
            this.dniTxtBox.TabIndex = 6;
            this.dniTxtBox.TextChanged += new System.EventHandler(this.OyenteTextosCambiados);
            this.dniTxtBox.Leave += new System.EventHandler(this.OyenteTextosLeave);
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(36, 260);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(309, 23);
            this.agregarButton.TabIndex = 7;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // FormNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(404, 311);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.dniTxtBox);
            this.Controls.Add(this.apellidoTxtBox);
            this.Controls.Add(this.nombreTxtBox);
            this.Controls.Add(this.dniClienteLbl);
            this.Controls.Add(this.apellidoClienteLbl);
            this.Controls.Add(this.nombreClienteLbl);
            this.Controls.Add(this.tituloCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNuevoCliente";
            this.Text = "Nuevo cliente";
            this.Load += new System.EventHandler(this.FormNuevoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloCliente;
        private System.Windows.Forms.Label nombreClienteLbl;
        private System.Windows.Forms.Label apellidoClienteLbl;
        private System.Windows.Forms.Label dniClienteLbl;
        private System.Windows.Forms.TextBox nombreTxtBox;
        private System.Windows.Forms.TextBox apellidoTxtBox;
        private System.Windows.Forms.TextBox dniTxtBox;
        private System.Windows.Forms.Button agregarButton;
    }
}