namespace Programa.Formularios
{
    partial class Categorias
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
            this.Boton_Agregar_Categoria = new System.Windows.Forms.Button();
            this.Categoria_dataGridView = new System.Windows.Forms.DataGridView();
            this.Categorias_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Categoria_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_Agregar_Categoria
            // 
            this.Boton_Agregar_Categoria.Location = new System.Drawing.Point(353, 427);
            this.Boton_Agregar_Categoria.Name = "Boton_Agregar_Categoria";
            this.Boton_Agregar_Categoria.Size = new System.Drawing.Size(184, 43);
            this.Boton_Agregar_Categoria.TabIndex = 21;
            this.Boton_Agregar_Categoria.Text = "Agregar Categoria";
            this.Boton_Agregar_Categoria.UseVisualStyleBackColor = true;
            this.Boton_Agregar_Categoria.Click += new System.EventHandler(this.Boton_Agregar_Categoria_Click);
            // 
            // Categoria_dataGridView
            // 
            this.Categoria_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Categoria_dataGridView.Location = new System.Drawing.Point(16, 76);
            this.Categoria_dataGridView.Name = "Categoria_dataGridView";
            this.Categoria_dataGridView.RowHeadersWidth = 62;
            this.Categoria_dataGridView.RowTemplate.Height = 28;
            this.Categoria_dataGridView.Size = new System.Drawing.Size(857, 332);
            this.Categoria_dataGridView.TabIndex = 20;
            // 
            // Categorias_label
            // 
            this.Categorias_label.AutoSize = true;
            this.Categorias_label.Location = new System.Drawing.Point(11, 31);
            this.Categorias_label.Name = "Categorias_label";
            this.Categorias_label.Size = new System.Drawing.Size(162, 20);
            this.Categorias_label.TabIndex = 19;
            this.Categorias_label.Text = "Categorias existentes";
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 496);
            this.Controls.Add(this.Boton_Agregar_Categoria);
            this.Controls.Add(this.Categoria_dataGridView);
            this.Controls.Add(this.Categorias_label);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Categoria_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Agregar_Categoria;
        private System.Windows.Forms.DataGridView Categoria_dataGridView;
        private System.Windows.Forms.Label Categorias_label;
    }
}