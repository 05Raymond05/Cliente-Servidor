namespace Programa.Formularios
{
    partial class Agregar_Cliente
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
            this.Agregar_Boton = new System.Windows.Forms.Button();
            this.Registro_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Nacimiento_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Segundo_Apellido_textBox = new System.Windows.Forms.TextBox();
            this.Primer_Apellido_textBox = new System.Windows.Forms.TextBox();
            this.Identificacion_Box = new System.Windows.Forms.TextBox();
            this.Activo_comboBox = new System.Windows.Forms.ComboBox();
            this.Activo_Label = new System.Windows.Forms.Label();
            this.Registro_label = new System.Windows.Forms.Label();
            this.Nacimiento_label = new System.Windows.Forms.Label();
            this.Segundo_Apellido_label = new System.Windows.Forms.Label();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.Primer_Apellido_label = new System.Windows.Forms.Label();
            this.Identificiacion_label = new System.Windows.Forms.Label();
            this.Nombre_label = new System.Windows.Forms.Label();
            this.Ingresar_label = new System.Windows.Forms.Label();
            this.ID_Cliente_textBox = new System.Windows.Forms.TextBox();
            this.ID_Cliente_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Agregar_Boton
            // 
            this.Agregar_Boton.Location = new System.Drawing.Point(399, 256);
            this.Agregar_Boton.Name = "Agregar_Boton";
            this.Agregar_Boton.Size = new System.Drawing.Size(119, 40);
            this.Agregar_Boton.TabIndex = 34;
            this.Agregar_Boton.Text = "Agregar";
            this.Agregar_Boton.UseVisualStyleBackColor = true;
            this.Agregar_Boton.Click += new System.EventHandler(this.Agregar_Boton_Click);
            // 
            // Registro_dateTimePicker
            // 
            this.Registro_dateTimePicker.Location = new System.Drawing.Point(643, 160);
            this.Registro_dateTimePicker.Name = "Registro_dateTimePicker";
            this.Registro_dateTimePicker.Size = new System.Drawing.Size(266, 26);
            this.Registro_dateTimePicker.TabIndex = 33;
            this.Registro_dateTimePicker.ValueChanged += new System.EventHandler(this.Registro_dateTimePicker_ValueChanged);
            // 
            // Nacimiento_dateTimePicker
            // 
            this.Nacimiento_dateTimePicker.Location = new System.Drawing.Point(643, 120);
            this.Nacimiento_dateTimePicker.Name = "Nacimiento_dateTimePicker";
            this.Nacimiento_dateTimePicker.Size = new System.Drawing.Size(266, 26);
            this.Nacimiento_dateTimePicker.TabIndex = 32;
            this.Nacimiento_dateTimePicker.ValueChanged += new System.EventHandler(this.Nacimiento_dateTimePicker_ValueChanged);
            // 
            // Segundo_Apellido_textBox
            // 
            this.Segundo_Apellido_textBox.Location = new System.Drawing.Point(643, 81);
            this.Segundo_Apellido_textBox.Name = "Segundo_Apellido_textBox";
            this.Segundo_Apellido_textBox.Size = new System.Drawing.Size(161, 26);
            this.Segundo_Apellido_textBox.TabIndex = 31;
            this.Segundo_Apellido_textBox.TextChanged += new System.EventHandler(this.Segundo_Apellido_textBox_TextChanged);
            // 
            // Primer_Apellido_textBox
            // 
            this.Primer_Apellido_textBox.Location = new System.Drawing.Point(149, 197);
            this.Primer_Apellido_textBox.Name = "Primer_Apellido_textBox";
            this.Primer_Apellido_textBox.Size = new System.Drawing.Size(161, 26);
            this.Primer_Apellido_textBox.TabIndex = 30;
            this.Primer_Apellido_textBox.TextChanged += new System.EventHandler(this.Primer_Apellido_textBox_TextChanged);
            // 
            // Identificacion_Box
            // 
            this.Identificacion_Box.Location = new System.Drawing.Point(149, 160);
            this.Identificacion_Box.Name = "Identificacion_Box";
            this.Identificacion_Box.Size = new System.Drawing.Size(161, 26);
            this.Identificacion_Box.TabIndex = 29;
            this.Identificacion_Box.TextChanged += new System.EventHandler(this.Identificacion_Box_TextChanged);
            // 
            // Activo_comboBox
            // 
            this.Activo_comboBox.FormattingEnabled = true;
            this.Activo_comboBox.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.Activo_comboBox.Location = new System.Drawing.Point(643, 202);
            this.Activo_comboBox.Name = "Activo_comboBox";
            this.Activo_comboBox.Size = new System.Drawing.Size(59, 28);
            this.Activo_comboBox.TabIndex = 28;
            this.Activo_comboBox.SelectedIndexChanged += new System.EventHandler(this.Activo_comboBox_SelectedIndexChanged);
            // 
            // Activo_Label
            // 
            this.Activo_Label.AutoSize = true;
            this.Activo_Label.Location = new System.Drawing.Point(557, 202);
            this.Activo_Label.Name = "Activo_Label";
            this.Activo_Label.Size = new System.Drawing.Size(52, 20);
            this.Activo_Label.TabIndex = 27;
            this.Activo_Label.Text = "Activo";
            this.Activo_Label.Click += new System.EventHandler(this.Activo_Label_Click);
            // 
            // Registro_label
            // 
            this.Registro_label.AutoSize = true;
            this.Registro_label.Location = new System.Drawing.Point(475, 160);
            this.Registro_label.Name = "Registro_label";
            this.Registro_label.Size = new System.Drawing.Size(140, 20);
            this.Registro_label.TabIndex = 26;
            this.Registro_label.Text = "Fecha de Registro";
            this.Registro_label.Click += new System.EventHandler(this.Registro_label_Click);
            // 
            // Nacimiento_label
            // 
            this.Nacimiento_label.AutoSize = true;
            this.Nacimiento_label.Location = new System.Drawing.Point(456, 125);
            this.Nacimiento_label.Name = "Nacimiento_label";
            this.Nacimiento_label.Size = new System.Drawing.Size(159, 20);
            this.Nacimiento_label.TabIndex = 25;
            this.Nacimiento_label.Text = "Fecha de Nacimiento";
            this.Nacimiento_label.Click += new System.EventHandler(this.Nacimiento_label_Click);
            // 
            // Segundo_Apellido_label
            // 
            this.Segundo_Apellido_label.AutoSize = true;
            this.Segundo_Apellido_label.Location = new System.Drawing.Point(481, 88);
            this.Segundo_Apellido_label.Name = "Segundo_Apellido_label";
            this.Segundo_Apellido_label.Size = new System.Drawing.Size(134, 20);
            this.Segundo_Apellido_label.TabIndex = 24;
            this.Segundo_Apellido_label.Text = "Segundo Apellido";
            this.Segundo_Apellido_label.Click += new System.EventHandler(this.Segundo_Apellido_label_Click);
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(149, 125);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(252, 26);
            this.Nombre_textBox.TabIndex = 23;
            this.Nombre_textBox.TextChanged += new System.EventHandler(this.Nombre_textBox_TextChanged);
            // 
            // Primer_Apellido_label
            // 
            this.Primer_Apellido_label.AutoSize = true;
            this.Primer_Apellido_label.Location = new System.Drawing.Point(21, 197);
            this.Primer_Apellido_label.Name = "Primer_Apellido_label";
            this.Primer_Apellido_label.Size = new System.Drawing.Size(114, 20);
            this.Primer_Apellido_label.TabIndex = 22;
            this.Primer_Apellido_label.Text = "Primer Apellido";
            this.Primer_Apellido_label.Click += new System.EventHandler(this.Primer_Apellido_label_Click);
            // 
            // Identificiacion_label
            // 
            this.Identificiacion_label.AutoSize = true;
            this.Identificiacion_label.Location = new System.Drawing.Point(29, 160);
            this.Identificiacion_label.Name = "Identificiacion_label";
            this.Identificiacion_label.Size = new System.Drawing.Size(103, 20);
            this.Identificiacion_label.TabIndex = 21;
            this.Identificiacion_label.Text = "Identificacion";
            this.Identificiacion_label.Click += new System.EventHandler(this.Identificiacion_label_Click);
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Location = new System.Drawing.Point(67, 125);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(65, 20);
            this.Nombre_label.TabIndex = 20;
            this.Nombre_label.Text = "Nombre";
            this.Nombre_label.Click += new System.EventHandler(this.Nombre_label_Click);
            // 
            // Ingresar_label
            // 
            this.Ingresar_label.AutoSize = true;
            this.Ingresar_label.Location = new System.Drawing.Point(21, 37);
            this.Ingresar_label.Name = "Ingresar_label";
            this.Ingresar_label.Size = new System.Drawing.Size(187, 20);
            this.Ingresar_label.TabIndex = 19;
            this.Ingresar_label.Text = "Ingresar un nuevo cliente";
            this.Ingresar_label.Click += new System.EventHandler(this.Ingresar_label_Click);
            // 
            // ID_Cliente_textBox
            // 
            this.ID_Cliente_textBox.Location = new System.Drawing.Point(149, 88);
            this.ID_Cliente_textBox.Name = "ID_Cliente_textBox";
            this.ID_Cliente_textBox.Size = new System.Drawing.Size(161, 26);
            this.ID_Cliente_textBox.TabIndex = 36;
            this.ID_Cliente_textBox.TextChanged += new System.EventHandler(this.ID_Cliente_textBox_TextChanged);
            // 
            // ID_Cliente_label
            // 
            this.ID_Cliente_label.AutoSize = true;
            this.ID_Cliente_label.Location = new System.Drawing.Point(48, 88);
            this.ID_Cliente_label.Name = "ID_Cliente_label";
            this.ID_Cliente_label.Size = new System.Drawing.Size(84, 20);
            this.ID_Cliente_label.TabIndex = 35;
            this.ID_Cliente_label.Text = "ID_Cliente";
            this.ID_Cliente_label.Click += new System.EventHandler(this.ID_Cliente_label_Click);
            // 
            // Agregar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 353);
            this.Controls.Add(this.ID_Cliente_textBox);
            this.Controls.Add(this.ID_Cliente_label);
            this.Controls.Add(this.Agregar_Boton);
            this.Controls.Add(this.Registro_dateTimePicker);
            this.Controls.Add(this.Nacimiento_dateTimePicker);
            this.Controls.Add(this.Segundo_Apellido_textBox);
            this.Controls.Add(this.Primer_Apellido_textBox);
            this.Controls.Add(this.Identificacion_Box);
            this.Controls.Add(this.Activo_comboBox);
            this.Controls.Add(this.Activo_Label);
            this.Controls.Add(this.Registro_label);
            this.Controls.Add(this.Nacimiento_label);
            this.Controls.Add(this.Segundo_Apellido_label);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.Primer_Apellido_label);
            this.Controls.Add(this.Identificiacion_label);
            this.Controls.Add(this.Nombre_label);
            this.Controls.Add(this.Ingresar_label);
            this.Name = "Agregar_Cliente";
            this.Text = "Agregar_Cliente";
            this.Load += new System.EventHandler(this.Agregar_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar_Boton;
        private System.Windows.Forms.DateTimePicker Registro_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Nacimiento_dateTimePicker;
        private System.Windows.Forms.TextBox Segundo_Apellido_textBox;
        private System.Windows.Forms.TextBox Primer_Apellido_textBox;
        private System.Windows.Forms.TextBox Identificacion_Box;
        private System.Windows.Forms.ComboBox Activo_comboBox;
        private System.Windows.Forms.Label Activo_Label;
        private System.Windows.Forms.Label Registro_label;
        private System.Windows.Forms.Label Nacimiento_label;
        private System.Windows.Forms.Label Segundo_Apellido_label;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label Primer_Apellido_label;
        private System.Windows.Forms.Label Identificiacion_label;
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.Label Ingresar_label;
        private System.Windows.Forms.TextBox ID_Cliente_textBox;
        private System.Windows.Forms.Label ID_Cliente_label;
    }
}