namespace Programa.Formularios
{
    partial class Agregar_PeliculaxSucursal
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
            this.PeliculaxSucursal_dataGridView = new System.Windows.Forms.DataGridView();
            this.Boton_Agregar = new System.Windows.Forms.Button();
            this.Sucursal_comboBox = new System.Windows.Forms.ComboBox();
            this.Pelicula_comboBox = new System.Windows.Forms.ComboBox();
            this.Pelicula_Label = new System.Windows.Forms.Label();
            this.Sucursal_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cantidad_label = new System.Windows.Forms.Label();
            this.cantidad_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculaxSucursal_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeliculaxSucursal_dataGridView
            // 
            this.PeliculaxSucursal_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeliculaxSucursal_dataGridView.Location = new System.Drawing.Point(209, 207);
            this.PeliculaxSucursal_dataGridView.Name = "PeliculaxSucursal_dataGridView";
            this.PeliculaxSucursal_dataGridView.RowHeadersWidth = 62;
            this.PeliculaxSucursal_dataGridView.RowTemplate.Height = 28;
            this.PeliculaxSucursal_dataGridView.Size = new System.Drawing.Size(605, 332);
            this.PeliculaxSucursal_dataGridView.TabIndex = 21;
            // 
            // Boton_Agregar
            // 
            this.Boton_Agregar.Location = new System.Drawing.Point(371, 100);
            this.Boton_Agregar.Name = "Boton_Agregar";
            this.Boton_Agregar.Size = new System.Drawing.Size(184, 43);
            this.Boton_Agregar.TabIndex = 22;
            this.Boton_Agregar.Text = "Asociar";
            this.Boton_Agregar.UseVisualStyleBackColor = true;
            this.Boton_Agregar.Click += new System.EventHandler(this.Boton_Agregar_Click);
            // 
            // Sucursal_comboBox
            // 
            this.Sucursal_comboBox.FormattingEnabled = true;
            this.Sucursal_comboBox.Location = new System.Drawing.Point(127, 44);
            this.Sucursal_comboBox.Name = "Sucursal_comboBox";
            this.Sucursal_comboBox.Size = new System.Drawing.Size(201, 28);
            this.Sucursal_comboBox.TabIndex = 77;
            // 
            // Pelicula_comboBox
            // 
            this.Pelicula_comboBox.FormattingEnabled = true;
            this.Pelicula_comboBox.Location = new System.Drawing.Point(451, 44);
            this.Pelicula_comboBox.Name = "Pelicula_comboBox";
            this.Pelicula_comboBox.Size = new System.Drawing.Size(240, 28);
            this.Pelicula_comboBox.TabIndex = 76;
            // 
            // Pelicula_Label
            // 
            this.Pelicula_Label.AutoSize = true;
            this.Pelicula_Label.Location = new System.Drawing.Point(369, 48);
            this.Pelicula_Label.Name = "Pelicula_Label";
            this.Pelicula_Label.Size = new System.Drawing.Size(63, 20);
            this.Pelicula_Label.TabIndex = 75;
            this.Pelicula_Label.Text = "Pelicula";
            // 
            // Sucursal_label
            // 
            this.Sucursal_label.AutoSize = true;
            this.Sucursal_label.Location = new System.Drawing.Point(36, 48);
            this.Sucursal_label.Name = "Sucursal_label";
            this.Sucursal_label.Size = new System.Drawing.Size(71, 20);
            this.Sucursal_label.TabIndex = 74;
            this.Sucursal_label.Text = "Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Peliculas por Sucursal";
            // 
            // Cantidad_label
            // 
            this.Cantidad_label.AutoSize = true;
            this.Cantidad_label.Location = new System.Drawing.Point(727, 52);
            this.Cantidad_label.Name = "Cantidad_label";
            this.Cantidad_label.Size = new System.Drawing.Size(73, 20);
            this.Cantidad_label.TabIndex = 79;
            this.Cantidad_label.Text = "Cantidad";
            // 
            // cantidad_textBox
            // 
            this.cantidad_textBox.Location = new System.Drawing.Point(807, 45);
            this.cantidad_textBox.Name = "cantidad_textBox";
            this.cantidad_textBox.Size = new System.Drawing.Size(161, 26);
            this.cantidad_textBox.TabIndex = 80;
            // 
            // Agregar_PeliculaxSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 575);
            this.Controls.Add(this.cantidad_textBox);
            this.Controls.Add(this.Cantidad_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sucursal_comboBox);
            this.Controls.Add(this.Pelicula_comboBox);
            this.Controls.Add(this.Pelicula_Label);
            this.Controls.Add(this.Sucursal_label);
            this.Controls.Add(this.Boton_Agregar);
            this.Controls.Add(this.PeliculaxSucursal_dataGridView);
            this.Name = "Agregar_PeliculaxSucursal";
            this.Text = "PeliculaxSucursal";
            this.Load += new System.EventHandler(this.Agregar_PeliculaxSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeliculaxSucursal_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PeliculaxSucursal_dataGridView;
        private System.Windows.Forms.Button Boton_Agregar;
        private System.Windows.Forms.ComboBox Sucursal_comboBox;
        private System.Windows.Forms.ComboBox Pelicula_comboBox;
        private System.Windows.Forms.Label Pelicula_Label;
        private System.Windows.Forms.Label Sucursal_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cantidad_label;
        private System.Windows.Forms.TextBox cantidad_textBox;
    }
}