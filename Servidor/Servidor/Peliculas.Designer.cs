namespace Programa.Formularios
{
    partial class Peliculas
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
            this.Boton_Agregar_Pelicula = new System.Windows.Forms.Button();
            this.Pelicula_dataGridView = new System.Windows.Forms.DataGridView();
            this.Peliculas_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pelicula_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_Agregar_Pelicula
            // 
            this.Boton_Agregar_Pelicula.Location = new System.Drawing.Point(323, 414);
            this.Boton_Agregar_Pelicula.Name = "Boton_Agregar_Pelicula";
            this.Boton_Agregar_Pelicula.Size = new System.Drawing.Size(184, 43);
            this.Boton_Agregar_Pelicula.TabIndex = 24;
            this.Boton_Agregar_Pelicula.Text = "Agregar Pelicula";
            this.Boton_Agregar_Pelicula.UseVisualStyleBackColor = true;
            this.Boton_Agregar_Pelicula.Click += new System.EventHandler(this.Boton_Agregar_Pelicula_Click);
            // 
            // Pelicula_dataGridView
            // 
            this.Pelicula_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pelicula_dataGridView.Location = new System.Drawing.Point(6, 61);
            this.Pelicula_dataGridView.Name = "Pelicula_dataGridView";
            this.Pelicula_dataGridView.RowHeadersWidth = 62;
            this.Pelicula_dataGridView.RowTemplate.Height = 28;
            this.Pelicula_dataGridView.Size = new System.Drawing.Size(857, 332);
            this.Pelicula_dataGridView.TabIndex = 23;
            // 
            // Peliculas_label
            // 
            this.Peliculas_label.AutoSize = true;
            this.Peliculas_label.Location = new System.Drawing.Point(0, 7);
            this.Peliculas_label.Name = "Peliculas_label";
            this.Peliculas_label.Size = new System.Drawing.Size(176, 24);
            this.Peliculas_label.TabIndex = 22;
            this.Peliculas_label.Text = "Peliculas existentes";
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 545);
            this.Controls.Add(this.Boton_Agregar_Pelicula);
            this.Controls.Add(this.Pelicula_dataGridView);
            this.Controls.Add(this.Peliculas_label);
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.Peliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pelicula_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Agregar_Pelicula;
        private System.Windows.Forms.DataGridView Pelicula_dataGridView;
        private System.Windows.Forms.Label Peliculas_label;
    }
}