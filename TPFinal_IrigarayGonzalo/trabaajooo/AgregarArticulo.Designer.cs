namespace trabaajooo
{
    partial class AgregarArticulo
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
            this.BtnAgegarImagen = new System.Windows.Forms.Button();
            this.PtbUrlImagen = new System.Windows.Forms.PictureBox();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.UrlImagen = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PtbUrlImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgegarImagen
            // 
            this.BtnAgegarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgegarImagen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAgegarImagen.Location = new System.Drawing.Point(415, 161);
            this.BtnAgegarImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgegarImagen.Name = "BtnAgegarImagen";
            this.BtnAgegarImagen.Size = new System.Drawing.Size(46, 41);
            this.BtnAgegarImagen.TabIndex = 31;
            this.BtnAgegarImagen.Text = "+";
            this.BtnAgegarImagen.UseVisualStyleBackColor = true;
            this.BtnAgegarImagen.Click += new System.EventHandler(this.BtnAgegarImagen_Click);
            // 
            // PtbUrlImagen
            // 
            this.PtbUrlImagen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PtbUrlImagen.Location = new System.Drawing.Point(497, 63);
            this.PtbUrlImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PtbUrlImagen.Name = "PtbUrlImagen";
            this.PtbUrlImagen.Size = new System.Drawing.Size(263, 269);
            this.PtbUrlImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbUrlImagen.TabIndex = 30;
            this.PtbUrlImagen.TabStop = false;
            // 
            // TxtImagen
            // 
            this.TxtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImagen.Location = new System.Drawing.Point(153, 176);
            this.TxtImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(210, 22);
            this.TxtImagen.TabIndex = 20;
            // 
            // UrlImagen
            // 
            this.UrlImagen.AutoSize = true;
            this.UrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlImagen.ImeMode = System.Windows.Forms.ImeMode.On;
            this.UrlImagen.Location = new System.Drawing.Point(5, 176);
            this.UrlImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UrlImagen.Name = "UrlImagen";
            this.UrlImagen.Size = new System.Drawing.Size(100, 20);
            this.UrlImagen.TabIndex = 29;
            this.UrlImagen.Text = "UrlImagen:";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Marca.Location = new System.Drawing.Point(15, 253);
            this.Marca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(76, 25);
            this.Marca.TabIndex = 28;
            this.Marca.Text = "Marca";
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Categoria.Location = new System.Drawing.Point(11, 210);
            this.Categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(120, 25);
            this.Categoria.TabIndex = 27;
            this.Categoria.Text = "Categoria:";
            // 
            // CboMarca
            // 
            this.CboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Location = new System.Drawing.Point(153, 250);
            this.CboMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(108, 28);
            this.CboMarca.TabIndex = 24;
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(153, 207);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(108, 28);
            this.CboCategoria.TabIndex = 22;
            this.CboCategoria.SelectedIndexChanged += new System.EventHandler(this.CboCategoria_SelectedIndexChanged);
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescrip.Location = new System.Drawing.Point(153, 142);
            this.TxtDescrip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(210, 22);
            this.TxtDescrip.TabIndex = 18;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(153, 112);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(210, 22);
            this.TxtNombre.TabIndex = 17;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(153, 83);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(210, 22);
            this.TxtCodigo.TabIndex = 16;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Descripcion.Location = new System.Drawing.Point(11, 144);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(116, 20);
            this.Descripcion.TabIndex = 23;
            this.Descripcion.Text = "Descripcion:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nombre.Location = new System.Drawing.Point(11, 114);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(80, 20);
            this.Nombre.TabIndex = 21;
            this.Nombre.Text = "Nombre:";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Codigo.Location = new System.Drawing.Point(11, 83);
            this.Codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(91, 25);
            this.Codigo.TabIndex = 19;
            this.Codigo.Text = "Codigo:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancelar.Location = new System.Drawing.Point(256, 371);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(107, 46);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAceptar.Location = new System.Drawing.Point(112, 371);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(107, 46);
            this.BtnAceptar.TabIndex = 25;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(153, 298);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(210, 22);
            this.TxtPrecio.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Precio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 481);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgegarImagen);
            this.Controls.Add(this.PtbUrlImagen);
            this.Controls.Add(this.TxtImagen);
            this.Controls.Add(this.UrlImagen);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.CboMarca);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.TxtDescrip);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgregarArticulo";
            this.Text = "AgregarArticulo";
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbUrlImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgegarImagen;
        private System.Windows.Forms.PictureBox PtbUrlImagen;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.Label UrlImagen;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.ComboBox CboMarca;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label1;
    }
}