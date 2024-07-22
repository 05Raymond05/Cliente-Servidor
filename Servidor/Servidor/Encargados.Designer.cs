namespace Programa.Formularios
{
    partial class Encargados
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
            this.Boton_Agregar_Encargado = new System.Windows.Forms.Button();
            this.Encargado_dataGridView = new System.Windows.Forms.DataGridView();
            this.Encargados_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Encargado_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_Agregar_Encargado
            // 
            this.Boton_Agregar_Encargado.Location = new System.Drawing.Point(339, 424);
            this.Boton_Agregar_Encargado.Name = "Boton_Agregar_Encargado";
            this.Boton_Agregar_Encargado.Size = new System.Drawing.Size(184, 43);
            this.Boton_Agregar_Encargado.TabIndex = 21;
            this.Boton_Agregar_Encargado.Text = "Agregar Encargado";
            this.Boton_Agregar_Encargado.UseVisualStyleBackColor = true;
            this.Boton_Agregar_Encargado.Click += new System.EventHandler(this.Boton_Agregar_Encargado_Click);
            // 
            // Encargado_dataGridView
            // 
            this.Encargado_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Encargado_dataGridView.Location = new System.Drawing.Point(27, 58);
            this.Encargado_dataGridView.Name = "Encargado_dataGridView";
            this.Encargado_dataGridView.RowHeadersWidth = 62;
            this.Encargado_dataGridView.RowTemplate.Height = 28;
            this.Encargado_dataGridView.Size = new System.Drawing.Size(857, 332);
            this.Encargado_dataGridView.TabIndex = 20;
            // 
            // Encargados_label
            // 
            this.Encargados_label.AutoSize = true;
            this.Encargados_label.Location = new System.Drawing.Point(22, 13);
            this.Encargados_label.Name = "Encargados_label";
            this.Encargados_label.Size = new System.Drawing.Size(205, 24);
            this.Encargados_label.TabIndex = 19;
            this.Encargados_label.Text = "Encargados existentes";
            // 
            // Encargados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 565);
            this.Controls.Add(this.Boton_Agregar_Encargado);
            this.Controls.Add(this.Encargado_dataGridView);
            this.Controls.Add(this.Encargados_label);
            this.Name = "Encargados";
            this.Text = "Encargados";
            ((System.ComponentModel.ISupportInitialize)(this.Encargado_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Agregar_Encargado;
        private System.Windows.Forms.DataGridView Encargado_dataGridView;
        private System.Windows.Forms.Label Encargados_label;
    }
}