namespace Programa.Formularios
{
    partial class Agregar_Categoria
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
            this.ID_Categoria_textBox = new System.Windows.Forms.TextBox();
            this.ID_Categoria_label = new System.Windows.Forms.Label();
            this.Agregar_Boton = new System.Windows.Forms.Button();
            this.Descripcion_Box = new System.Windows.Forms.TextBox();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.descripcion_label = new System.Windows.Forms.Label();
            this.Nombre_label = new System.Windows.Forms.Label();
            this.Categoria_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_Categoria_textBox
            // 
            this.ID_Categoria_textBox.Location = new System.Drawing.Point(628, 69);
            this.ID_Categoria_textBox.Name = "ID_Categoria_textBox";
            this.ID_Categoria_textBox.Size = new System.Drawing.Size(161, 26);
            this.ID_Categoria_textBox.TabIndex = 54;
            // 
            // ID_Categoria_label
            // 
            this.ID_Categoria_label.AutoSize = true;
            this.ID_Categoria_label.Location = new System.Drawing.Point(502, 70);
            this.ID_Categoria_label.Name = "ID_Categoria_label";
            this.ID_Categoria_label.Size = new System.Drawing.Size(104, 20);
            this.ID_Categoria_label.TabIndex = 53;
            this.ID_Categoria_label.Text = "ID_Categoria";
            // 
            // Agregar_Boton
            // 
            this.Agregar_Boton.Location = new System.Drawing.Point(318, 356);
            this.Agregar_Boton.Name = "Agregar_Boton";
            this.Agregar_Boton.Size = new System.Drawing.Size(119, 40);
            this.Agregar_Boton.TabIndex = 52;
            this.Agregar_Boton.Text = "Agregar Categoria";
            this.Agregar_Boton.UseVisualStyleBackColor = true;
            this.Agregar_Boton.Click += new System.EventHandler(this.Agregar_Boton_Click);
            // 
            // Descripcion_Box
            // 
            this.Descripcion_Box.Location = new System.Drawing.Point(25, 142);
            this.Descripcion_Box.Multiline = true;
            this.Descripcion_Box.Name = "Descripcion_Box";
            this.Descripcion_Box.Size = new System.Drawing.Size(708, 173);
            this.Descripcion_Box.TabIndex = 47;
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(122, 69);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(252, 26);
            this.Nombre_textBox.TabIndex = 41;
            // 
            // descripcion_label
            // 
            this.descripcion_label.AutoSize = true;
            this.descripcion_label.Location = new System.Drawing.Point(21, 119);
            this.descripcion_label.Name = "descripcion_label";
            this.descripcion_label.Size = new System.Drawing.Size(92, 20);
            this.descripcion_label.TabIndex = 39;
            this.descripcion_label.Text = "Descripcion";
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Location = new System.Drawing.Point(21, 73);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(65, 20);
            this.Nombre_label.TabIndex = 38;
            this.Nombre_label.Text = "Nombre";
            // 
            // Categoria_label
            // 
            this.Categoria_label.AutoSize = true;
            this.Categoria_label.Location = new System.Drawing.Point(10, 18);
            this.Categoria_label.Name = "Categoria_label";
            this.Categoria_label.Size = new System.Drawing.Size(216, 20);
            this.Categoria_label.TabIndex = 37;
            this.Categoria_label.Text = "Ingresar una nueva categoria";
            // 
            // Agregar_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 532);
            this.Controls.Add(this.ID_Categoria_textBox);
            this.Controls.Add(this.ID_Categoria_label);
            this.Controls.Add(this.Agregar_Boton);
            this.Controls.Add(this.Descripcion_Box);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.descripcion_label);
            this.Controls.Add(this.Nombre_label);
            this.Controls.Add(this.Categoria_label);
            this.Name = "Agregar_Categoria";
            this.Text = "Agregar_Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Categoria_textBox;
        private System.Windows.Forms.Label ID_Categoria_label;
        private System.Windows.Forms.Button Agregar_Boton;
        private System.Windows.Forms.TextBox Descripcion_Box;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label descripcion_label;
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.Label Categoria_label;
    }
}