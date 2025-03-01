namespace ExamenGrupo5
{
    partial class VentanaEditarCosmetico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        // Josue se la re come con papas
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
            this.pb_salir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.spStock = new System.Windows.Forms.NumericUpDown();
            this.spPrecio = new System.Windows.Forms.NumericUpDown();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label_Estado = new System.Windows.Forms.Label();
            this.label_Clave = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_salir)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_salir
            // 
            this.pb_salir.Image = global::ExamenGrupo5.Properties.Resources.icons8_logout_48;
            this.pb_salir.Location = new System.Drawing.Point(507, 3);
            this.pb_salir.Name = "pb_salir";
            this.pb_salir.Size = new System.Drawing.Size(67, 65);
            this.pb_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_salir.TabIndex = 42;
            this.pb_salir.TabStop = false;
            this.pb_salir.Click += new System.EventHandler(this.pbSalir);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.gb);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 1107);
            this.panel1.TabIndex = 5;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.panel2);
            this.gb.Controls.Add(this.label1);
            this.gb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.ForeColor = System.Drawing.Color.Snow;
            this.gb.Location = new System.Drawing.Point(14, 2);
            this.gb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb.Name = "gb";
            this.gb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb.Size = new System.Drawing.Size(642, 1092);
            this.gb.TabIndex = 6;
            this.gb.TabStop = false;
            this.gb.Text = "Editar cosmético";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.pbImagen);
            this.panel2.Controls.Add(this.pb_salir);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbEstado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.spStock);
            this.panel2.Controls.Add(this.spPrecio);
            this.panel2.Controls.Add(this.cbCategoria);
            this.panel2.Controls.Add(this.label_Estado);
            this.panel2.Controls.Add(this.label_Clave);
            this.panel2.Controls.Add(this.btn_Aceptar);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_Cancelar);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Label);
            this.panel2.Location = new System.Drawing.Point(25, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 1028);
            this.panel2.TabIndex = 7;
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::ExamenGrupo5.Properties.Resources.icons8_add_48;
            this.pbImagen.Location = new System.Drawing.Point(231, 16);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(110, 86);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 43;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbEditImg);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(16, 768);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.Snow;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(22, 817);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(548, 40);
            this.cbEstado.TabIndex = 35;
            this.cbEstado.Text = "Seleccione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(16, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Categoría";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.Snow;
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpFecha.Location = new System.Drawing.Point(22, 585);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(548, 39);
            this.dtpFecha.TabIndex = 33;
            // 
            // spStock
            // 
            this.spStock.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.spStock.ForeColor = System.Drawing.Color.Snow;
            this.spStock.Location = new System.Drawing.Point(19, 467);
            this.spStock.Name = "spStock";
            this.spStock.Size = new System.Drawing.Size(557, 39);
            this.spStock.TabIndex = 32;
            // 
            // spPrecio
            // 
            this.spPrecio.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.spPrecio.ForeColor = System.Drawing.Color.Snow;
            this.spPrecio.Location = new System.Drawing.Point(22, 359);
            this.spPrecio.Name = "spPrecio";
            this.spPrecio.Size = new System.Drawing.Size(557, 39);
            this.spPrecio.TabIndex = 31;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.ForeColor = System.Drawing.Color.Snow;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Maquillaje",
            "Cuidado de la piel",
            "Fragancias",
            "Cabello",
            "Uñas"});
            this.cbCategoria.Location = new System.Drawing.Point(22, 704);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(548, 40);
            this.cbCategoria.TabIndex = 30;
            this.cbCategoria.Text = "Seleccione";
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Estado.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_Estado.Location = new System.Drawing.Point(16, 523);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(312, 32);
            this.label_Estado.TabIndex = 29;
            this.label_Estado.Text = "Fecha de vencimiento";
            this.label_Estado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Clave
            // 
            this.label_Clave.AutoSize = true;
            this.label_Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clave.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_Clave.Location = new System.Drawing.Point(13, 419);
            this.label_Clave.Name = "label_Clave";
            this.label_Clave.Size = new System.Drawing.Size(239, 32);
            this.label_Clave.TabIndex = 26;
            this.label_Clave.Text = "Stock disponible";
            this.label_Clave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.ForeColor = System.Drawing.Color.Snow;
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Aceptar.Location = new System.Drawing.Point(17, 944);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(180, 52);
            this.btn_Aceptar.TabIndex = 25;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btnAceptar);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DarkCyan;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Snow;
            this.txtNombre.Location = new System.Drawing.Point(14, 159);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(560, 39);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Text = "Nombre producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(16, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Precio Unitario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Snow;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(385, 944);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(180, 52);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btnCancelar);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.Snow;
            this.txtMarca.Location = new System.Drawing.Point(19, 257);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(560, 39);
            this.txtMarca.TabIndex = 11;
            this.txtMarca.Text = "Nombre marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(16, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Label.Location = new System.Drawing.Point(8, 114);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(297, 32);
            this.Label.TabIndex = 9;
            this.Label.Text = "Nombre del producto";
            this.Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(18, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VentanaEditarCosmetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 1106);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaEditarCosmetico";
            this.Text = "VentanaEditarCosmetico";
            ((System.ComponentModel.ISupportInitialize)(this.pb_salir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown spStock;
        private System.Windows.Forms.NumericUpDown spPrecio;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.Label label_Clave;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
    }
}