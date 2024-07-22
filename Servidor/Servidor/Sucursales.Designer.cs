namespace Programa.Formularios
{
    partial class Sucursales
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
            this.Boton_Agregar_Sucursal = new System.Windows.Forms.Button();
            this.Sucursales_dataGridView = new System.Windows.Forms.DataGridView();
            this.Sucursales_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sucursales_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_Agregar_Sucursal
            // 
            this.Boton_Agregar_Sucursal.Location = new System.Drawing.Point(358, 415);
            this.Boton_Agregar_Sucursal.Name = "Boton_Agregar_Sucursal";
            this.Boton_Agregar_Sucursal.Size = new System.Drawing.Size(184, 43);
            this.Boton_Agregar_Sucursal.TabIndex = 21;
            this.Boton_Agregar_Sucursal.Text = "Agregar Sucursal";
            this.Boton_Agregar_Sucursal.UseVisualStyleBackColor = true;
            this.Boton_Agregar_Sucursal.Click += new System.EventHandler(this.Boton_Agregar_Sucursal_Click);
            // 
            // Sucursales_dataGridView
            // 
            this.Sucursales_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sucursales_dataGridView.Location = new System.Drawing.Point(12, 60);
            this.Sucursales_dataGridView.Name = "Sucursales_dataGridView";
            this.Sucursales_dataGridView.RowHeadersWidth = 62;
            this.Sucursales_dataGridView.RowTemplate.Height = 28;
            this.Sucursales_dataGridView.Size = new System.Drawing.Size(857, 332);
            this.Sucursales_dataGridView.TabIndex = 20;
            // 
            // Sucursales_label
            // 
            this.Sucursales_label.AutoSize = true;
            this.Sucursales_label.Location = new System.Drawing.Point(7, 15);
            this.Sucursales_label.Name = "Sucursales_label";
            this.Sucursales_label.Size = new System.Drawing.Size(197, 24);
            this.Sucursales_label.TabIndex = 19;
            this.Sucursales_label.Text = "Sucursales existentes";
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 499);
            this.Controls.Add(this.Boton_Agregar_Sucursal);
            this.Controls.Add(this.Sucursales_dataGridView);
            this.Controls.Add(this.Sucursales_label);
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.Sucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sucursales_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Agregar_Sucursal;
        private System.Windows.Forms.DataGridView Sucursales_dataGridView;
        private System.Windows.Forms.Label Sucursales_label;
    }
}