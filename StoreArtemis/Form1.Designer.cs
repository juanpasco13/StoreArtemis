﻿
namespace StoreArtemis
{
    partial class ShopArtemis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopArtemis));
            this.lblTypePrenda = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPrendasTotales = new System.Windows.Forms.Label();
            this.TipoPrendaBox = new System.Windows.Forms.ComboBox();
            this.MarcaBox = new System.Windows.Forms.ComboBox();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTypePrenda
            // 
            this.lblTypePrenda.AutoSize = true;
            this.lblTypePrenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypePrenda.Location = new System.Drawing.Point(254, 40);
            this.lblTypePrenda.Name = "lblTypePrenda";
            this.lblTypePrenda.Size = new System.Drawing.Size(111, 18);
            this.lblTypePrenda.TabIndex = 0;
            this.lblTypePrenda.Text = "Tipo Prenda ";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblColor.Location = new System.Drawing.Point(254, 82);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 18);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(254, 129);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 18);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(254, 177);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(46, 18);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Talla";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(254, 222);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 18);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Precio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(412, 177);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(215, 19);
            this.txtTalla.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(412, 223);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(215, 19);
            this.txtPrecio.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(282, 281);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 37);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPrendasTotales
            // 
            this.lblPrendasTotales.AutoSize = true;
            this.lblPrendasTotales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrendasTotales.Location = new System.Drawing.Point(157, 353);
            this.lblPrendasTotales.Name = "lblPrendasTotales";
            this.lblPrendasTotales.Size = new System.Drawing.Size(160, 18);
            this.lblPrendasTotales.TabIndex = 12;
            this.lblPrendasTotales.Text = "Prendas totales: 0";
            // 
            // TipoPrendaBox
            // 
            this.TipoPrendaBox.FormattingEnabled = true;
            this.TipoPrendaBox.Items.AddRange(new object[] {
            "Juvenil",
            "Deportiva",
            "Elegante",
            "Casual"});
            this.TipoPrendaBox.Location = new System.Drawing.Point(412, 37);
            this.TipoPrendaBox.Name = "TipoPrendaBox";
            this.TipoPrendaBox.Size = new System.Drawing.Size(215, 21);
            this.TipoPrendaBox.TabIndex = 13;
            // 
            // MarcaBox
            // 
            this.MarcaBox.FormattingEnabled = true;
            this.MarcaBox.Items.AddRange(new object[] {
            "Adidas",
            "Nike",
            "Hueco",
            "Gucci",
            "Pacifik"});
            this.MarcaBox.Location = new System.Drawing.Point(412, 129);
            this.MarcaBox.Name = "MarcaBox";
            this.MarcaBox.Size = new System.Drawing.Size(215, 21);
            this.MarcaBox.TabIndex = 14;
            // 
            // ColorBox
            // 
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Items.AddRange(new object[] {
            "Blanco",
            "Negro",
            "Verde",
            "Rojo",
            "Azul",
            "Amarillo"});
            this.ColorBox.Location = new System.Drawing.Point(412, 83);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(215, 21);
            this.ColorBox.TabIndex = 15;
            // 
            // ShopArtemis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 400);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.MarcaBox);
            this.Controls.Add(this.TipoPrendaBox);
            this.Controls.Add(this.lblPrendasTotales);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTypePrenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopArtemis";
            this.Text = "Shop Artemis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypePrenda;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPrendasTotales;
        private System.Windows.Forms.ComboBox TipoPrendaBox;
        private System.Windows.Forms.ComboBox MarcaBox;
        private System.Windows.Forms.ComboBox ColorBox;
    }
}

