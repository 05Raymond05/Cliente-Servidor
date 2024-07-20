namespace Servidor
{
    partial class MenuPrincipal
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
            this.Boton_PeliculaXSucursal = new System.Windows.Forms.Button();
            this.Boton_Categoria = new System.Windows.Forms.Button();
            this.Boton_Peliculas = new System.Windows.Forms.Button();
            this.Boton_Sucursales = new System.Windows.Forms.Button();
            this.Boton_Encargados = new System.Windows.Forms.Button();
            this.Boton_Clientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boton_PeliculaXSucursal
            // 
            this.Boton_PeliculaXSucursal.Location = new System.Drawing.Point(468, 313);
            this.Boton_PeliculaXSucursal.Name = "Boton_PeliculaXSucursal";
            this.Boton_PeliculaXSucursal.Size = new System.Drawing.Size(235, 103);
            this.Boton_PeliculaXSucursal.TabIndex = 11;
            this.Boton_PeliculaXSucursal.Text = "Pelicula x Sucursal";
            this.Boton_PeliculaXSucursal.UseVisualStyleBackColor = true;
            // 
            // Boton_Categoria
            // 
            this.Boton_Categoria.Location = new System.Drawing.Point(468, 157);
            this.Boton_Categoria.Name = "Boton_Categoria";
            this.Boton_Categoria.Size = new System.Drawing.Size(235, 98);
            this.Boton_Categoria.TabIndex = 10;
            this.Boton_Categoria.Text = "Categorias";
            this.Boton_Categoria.UseVisualStyleBackColor = true;
            this.Boton_Categoria.Click += new System.EventHandler(this.Boton_Categoria_Click);
            // 
            // Boton_Peliculas
            // 
            this.Boton_Peliculas.Location = new System.Drawing.Point(468, 12);
            this.Boton_Peliculas.Name = "Boton_Peliculas";
            this.Boton_Peliculas.Size = new System.Drawing.Size(235, 105);
            this.Boton_Peliculas.TabIndex = 9;
            this.Boton_Peliculas.Text = "Peliculas";
            this.Boton_Peliculas.UseVisualStyleBackColor = true;
            // 
            // Boton_Sucursales
            // 
            this.Boton_Sucursales.Location = new System.Drawing.Point(94, 313);
            this.Boton_Sucursales.Name = "Boton_Sucursales";
            this.Boton_Sucursales.Size = new System.Drawing.Size(236, 103);
            this.Boton_Sucursales.TabIndex = 8;
            this.Boton_Sucursales.Text = "Sucursales";
            this.Boton_Sucursales.UseVisualStyleBackColor = true;
            // 
            // Boton_Encargados
            // 
            this.Boton_Encargados.Location = new System.Drawing.Point(94, 157);
            this.Boton_Encargados.Name = "Boton_Encargados";
            this.Boton_Encargados.Size = new System.Drawing.Size(236, 98);
            this.Boton_Encargados.TabIndex = 7;
            this.Boton_Encargados.Text = "Encargados";
            this.Boton_Encargados.UseVisualStyleBackColor = true;
            // 
            // Boton_Clientes
            // 
            this.Boton_Clientes.Location = new System.Drawing.Point(94, 12);
            this.Boton_Clientes.Name = "Boton_Clientes";
            this.Boton_Clientes.Size = new System.Drawing.Size(236, 105);
            this.Boton_Clientes.TabIndex = 6;
            this.Boton_Clientes.Text = "Clientes";
            this.Boton_Clientes.UseVisualStyleBackColor = true;
            this.Boton_Clientes.Click += new System.EventHandler(this.Boton_Clientes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Encender Servidor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Boton_PeliculaXSucursal);
            this.Controls.Add(this.Boton_Categoria);
            this.Controls.Add(this.Boton_Peliculas);
            this.Controls.Add(this.Boton_Sucursales);
            this.Controls.Add(this.Boton_Encargados);
            this.Controls.Add(this.Boton_Clientes);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_PeliculaXSucursal;
        private System.Windows.Forms.Button Boton_Categoria;
        private System.Windows.Forms.Button Boton_Peliculas;
        private System.Windows.Forms.Button Boton_Sucursales;
        private System.Windows.Forms.Button Boton_Encargados;
        private System.Windows.Forms.Button Boton_Clientes;
        private System.Windows.Forms.Button button1;
    }
}

