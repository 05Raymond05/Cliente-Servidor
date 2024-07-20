namespace Programa.Formularios
{
    partial class Clientes
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
            this.Clientes_label = new System.Windows.Forms.Label();
            this.Cliente_dataGridView = new System.Windows.Forms.DataGridView();
            this.Boton_Agregar_Cliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Clientes_label
            // 
            this.Clientes_label.AutoSize = true;
            this.Clientes_label.Location = new System.Drawing.Point(37, 34);
            this.Clientes_label.Name = "Clientes_label";
            this.Clientes_label.Size = new System.Drawing.Size(142, 20);
            this.Clientes_label.TabIndex = 1;
            this.Clientes_label.Text = "Clientes existentes";
            this.Clientes_label.Click += new System.EventHandler(this.Clientes_label_Click);
            // 
            // Cliente_dataGridView
            // 
            this.Cliente_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cliente_dataGridView.Location = new System.Drawing.Point(41, 71);
            this.Cliente_dataGridView.Name = "Cliente_dataGridView";
            this.Cliente_dataGridView.RowHeadersWidth = 62;
            this.Cliente_dataGridView.RowTemplate.Height = 28;
            this.Cliente_dataGridView.Size = new System.Drawing.Size(857, 332);
            this.Cliente_dataGridView.TabIndex = 17;
            this.Cliente_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cliente_dataGridView_CellContentClick);
            // 
            // Boton_Agregar_Cliente
            // 
            this.Boton_Agregar_Cliente.Location = new System.Drawing.Point(372, 448);
            this.Boton_Agregar_Cliente.Name = "Boton_Agregar_Cliente";
            this.Boton_Agregar_Cliente.Size = new System.Drawing.Size(184, 43);
            this.Boton_Agregar_Cliente.TabIndex = 18;
            this.Boton_Agregar_Cliente.Text = "Agregar Cliente";
            this.Boton_Agregar_Cliente.UseVisualStyleBackColor = true;
            this.Boton_Agregar_Cliente.Click += new System.EventHandler(this.Boton_Agregar_Cliente_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 552);
            this.Controls.Add(this.Boton_Agregar_Cliente);
            this.Controls.Add(this.Cliente_dataGridView);
            this.Controls.Add(this.Clientes_label);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Clientes_label;
        private System.Windows.Forms.DataGridView Cliente_dataGridView;
        private System.Windows.Forms.Button Boton_Agregar_Cliente;
    }
}