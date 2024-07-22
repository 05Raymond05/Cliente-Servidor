namespace Programa.Formularios
{
    partial class Agregar_Sucursal
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
            this.ID_Encargado_textBox = new System.Windows.Forms.TextBox();
            this.ID_Sucursal_label = new System.Windows.Forms.Label();
            this.Agregar_Boton = new System.Windows.Forms.Button();
            this.Telefono_textBox = new System.Windows.Forms.TextBox();
            this.EcargadoID_label = new System.Windows.Forms.Label();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.Telefono_label = new System.Windows.Forms.Label();
            this.Nombre_label = new System.Windows.Forms.Label();
            this.sucursal_label = new System.Windows.Forms.Label();
            this.direccion_label = new System.Windows.Forms.Label();
            this.direccion_textBox = new System.Windows.Forms.TextBox();
            this.Activo_comboBox = new System.Windows.Forms.ComboBox();
            this.Activo_Label = new System.Windows.Forms.Label();
            this.Encargado_comboBox = new System.Windows.Forms.ComboBox();
            this.Encargado_Informacion_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_Encargado_textBox
            // 
            this.ID_Encargado_textBox.Location = new System.Drawing.Point(159, 76);
            this.ID_Encargado_textBox.Name = "ID_Encargado_textBox";
            this.ID_Encargado_textBox.Size = new System.Drawing.Size(161, 26);
            this.ID_Encargado_textBox.TabIndex = 70;
            // 
            // ID_Sucursal_label
            // 
            this.ID_Sucursal_label.AutoSize = true;
            this.ID_Sucursal_label.Location = new System.Drawing.Point(29, 76);
            this.ID_Sucursal_label.Name = "ID_Sucursal_label";
            this.ID_Sucursal_label.Size = new System.Drawing.Size(97, 20);
            this.ID_Sucursal_label.TabIndex = 69;
            this.ID_Sucursal_label.Text = "ID_Sucursal";
            // 
            // Agregar_Boton
            // 
            this.Agregar_Boton.Location = new System.Drawing.Point(371, 245);
            this.Agregar_Boton.Name = "Agregar_Boton";
            this.Agregar_Boton.Size = new System.Drawing.Size(119, 40);
            this.Agregar_Boton.TabIndex = 68;
            this.Agregar_Boton.Text = "Agregar";
            this.Agregar_Boton.UseVisualStyleBackColor = true;
            this.Agregar_Boton.Click += new System.EventHandler(this.Agregar_Boton_Click);
            // 
            // Telefono_textBox
            // 
            this.Telefono_textBox.Location = new System.Drawing.Point(543, 76);
            this.Telefono_textBox.Name = "Telefono_textBox";
            this.Telefono_textBox.Size = new System.Drawing.Size(161, 26);
            this.Telefono_textBox.TabIndex = 64;
            // 
            // EcargadoID_label
            // 
            this.EcargadoID_label.AutoSize = true;
            this.EcargadoID_label.Location = new System.Drawing.Point(19, 174);
            this.EcargadoID_label.Name = "EcargadoID_label";
            this.EcargadoID_label.Size = new System.Drawing.Size(113, 20);
            this.EcargadoID_label.TabIndex = 60;
            this.EcargadoID_label.Text = "Encargado_ID";
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(119, 126);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(201, 26);
            this.Nombre_textBox.TabIndex = 59;
            // 
            // Telefono_label
            // 
            this.Telefono_label.AutoSize = true;
            this.Telefono_label.Location = new System.Drawing.Point(452, 79);
            this.Telefono_label.Name = "Telefono_label";
            this.Telefono_label.Size = new System.Drawing.Size(71, 20);
            this.Telefono_label.TabIndex = 58;
            this.Telefono_label.Text = "Telefono";
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Location = new System.Drawing.Point(48, 132);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(65, 20);
            this.Nombre_label.TabIndex = 56;
            this.Nombre_label.Text = "Nombre";
            // 
            // sucursal_label
            // 
            this.sucursal_label.AutoSize = true;
            this.sucursal_label.Location = new System.Drawing.Point(16, 9);
            this.sucursal_label.Name = "sucursal_label";
            this.sucursal_label.Size = new System.Drawing.Size(209, 40);
            this.sucursal_label.TabIndex = 55;
            this.sucursal_label.Text = "Ingresar una nueva sucursal\r\n\r\n";
            // 
            // direccion_label
            // 
            this.direccion_label.AutoSize = true;
            this.direccion_label.Location = new System.Drawing.Point(452, 126);
            this.direccion_label.Name = "direccion_label";
            this.direccion_label.Size = new System.Drawing.Size(72, 20);
            this.direccion_label.TabIndex = 57;
            this.direccion_label.Text = "direccion";
            // 
            // direccion_textBox
            // 
            this.direccion_textBox.Location = new System.Drawing.Point(543, 126);
            this.direccion_textBox.Name = "direccion_textBox";
            this.direccion_textBox.Size = new System.Drawing.Size(161, 26);
            this.direccion_textBox.TabIndex = 63;
            // 
            // Activo_comboBox
            // 
            this.Activo_comboBox.FormattingEnabled = true;
            this.Activo_comboBox.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.Activo_comboBox.Location = new System.Drawing.Point(543, 174);
            this.Activo_comboBox.Name = "Activo_comboBox";
            this.Activo_comboBox.Size = new System.Drawing.Size(59, 28);
            this.Activo_comboBox.TabIndex = 72;
            // 
            // Activo_Label
            // 
            this.Activo_Label.AutoSize = true;
            this.Activo_Label.Location = new System.Drawing.Point(466, 179);
            this.Activo_Label.Name = "Activo_Label";
            this.Activo_Label.Size = new System.Drawing.Size(52, 20);
            this.Activo_Label.TabIndex = 71;
            this.Activo_Label.Text = "Activo";
            // 
            // Encargado_comboBox
            // 
            this.Encargado_comboBox.FormattingEnabled = true;
            this.Encargado_comboBox.Location = new System.Drawing.Point(130, 170);
            this.Encargado_comboBox.Name = "Encargado_comboBox";
            this.Encargado_comboBox.Size = new System.Drawing.Size(201, 28);
            this.Encargado_comboBox.TabIndex = 73;
            this.Encargado_comboBox.SelectedIndexChanged += new System.EventHandler(this.Encargado_comboBox_SelectedIndexChanged);
            // 
            // Encargado_Informacion_label
            // 
            this.Encargado_Informacion_label.AutoSize = true;
            this.Encargado_Informacion_label.Location = new System.Drawing.Point(16, 220);
            this.Encargado_Informacion_label.Name = "Encargado_Informacion_label";
            this.Encargado_Informacion_label.Size = new System.Drawing.Size(201, 20);
            this.Encargado_Informacion_label.TabIndex = 74;
            this.Encargado_Informacion_label.Text = "Informacion de Encargado:";
            // 
            // Agregar_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 408);
            this.Controls.Add(this.Encargado_Informacion_label);
            this.Controls.Add(this.Encargado_comboBox);
            this.Controls.Add(this.Activo_comboBox);
            this.Controls.Add(this.Activo_Label);
            this.Controls.Add(this.ID_Encargado_textBox);
            this.Controls.Add(this.ID_Sucursal_label);
            this.Controls.Add(this.Agregar_Boton);
            this.Controls.Add(this.Telefono_textBox);
            this.Controls.Add(this.direccion_textBox);
            this.Controls.Add(this.EcargadoID_label);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.Telefono_label);
            this.Controls.Add(this.direccion_label);
            this.Controls.Add(this.Nombre_label);
            this.Controls.Add(this.sucursal_label);
            this.Name = "Agregar_Sucursal";
            this.Text = "Agregar_Sucursal";
            this.Load += new System.EventHandler(this.Agregar_Sucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Encargado_textBox;
        private System.Windows.Forms.Label ID_Sucursal_label;
        private System.Windows.Forms.Button Agregar_Boton;
        private System.Windows.Forms.TextBox Telefono_textBox;
        private System.Windows.Forms.Label EcargadoID_label;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label Telefono_label;
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.Label sucursal_label;
        private System.Windows.Forms.Label direccion_label;
        private System.Windows.Forms.TextBox direccion_textBox;
        private System.Windows.Forms.ComboBox Activo_comboBox;
        private System.Windows.Forms.Label Activo_Label;
        private System.Windows.Forms.ComboBox Encargado_comboBox;
        private System.Windows.Forms.Label Encargado_Informacion_label;
    }
}