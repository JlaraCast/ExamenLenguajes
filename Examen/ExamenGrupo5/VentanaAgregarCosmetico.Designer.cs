namespace ExamenGrupo5
{
    partial class VentanaAgregarCosmetico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //JJ se la come con papas

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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.cbCategoría = new System.Windows.Forms.ComboBox();
            this.label_Estado = new System.Windows.Forms.Label();
            this.label_Clave = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioUnitario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.Snow;
            this.txt_Email.Location = new System.Drawing.Point(9, 75);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(560, 39);
            this.txt_Email.TabIndex = 21;
            this.txt_Email.Text = "Nombre producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(11, 231);
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
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.Snow;
            this.txt_Nombre.Location = new System.Drawing.Point(14, 173);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(560, 39);
            this.txt_Nombre.TabIndex = 11;
            this.txt_Nombre.Text = "Nombre marca";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Label.Location = new System.Drawing.Point(3, 30);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(297, 32);
            this.Label.TabIndex = 9;
            this.Label.Text = "Nombre del producto";
            this.Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(14, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(642, 1092);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar cosmético";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtImagen);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxEstado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimePickerFechaVencimiento);
            this.panel2.Controls.Add(this.numericUpDownStock);
            this.panel2.Controls.Add(this.numericUpDownPrecioUnitario);
            this.panel2.Controls.Add(this.cbCategoría);
            this.panel2.Controls.Add(this.label_Estado);
            this.panel2.Controls.Add(this.label_Clave);
            this.panel2.Controls.Add(this.btn_Aceptar);
            this.panel2.Controls.Add(this.txt_Email);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_Cancelar);
            this.panel2.Controls.Add(this.txt_Nombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Label);
            this.panel2.Location = new System.Drawing.Point(25, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 1028);
            this.panel2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(11, 803);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 32);
            this.label6.TabIndex = 38;
            this.label6.Text = "Imagen";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtImagen
            // 
            this.txtImagen.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.ForeColor = System.Drawing.Color.Snow;
            this.txtImagen.Location = new System.Drawing.Point(14, 851);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(560, 39);
            this.txtImagen.TabIndex = 37;
            this.txtImagen.Text = "URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(11, 684);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.comboBoxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.ForeColor = System.Drawing.Color.Snow;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(17, 733);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(548, 40);
            this.comboBoxEstado.TabIndex = 35;
            this.comboBoxEstado.Text = "Seleccione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(11, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Categoría";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerFechaVencimiento
            // 
            this.dateTimePickerFechaVencimiento.CalendarForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dateTimePickerFechaVencimiento.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dateTimePickerFechaVencimiento.CalendarTitleBackColor = System.Drawing.Color.Snow;
            this.dateTimePickerFechaVencimiento.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePickerFechaVencimiento.Location = new System.Drawing.Point(17, 501);
            this.dateTimePickerFechaVencimiento.Name = "dateTimePickerFechaVencimiento";
            this.dateTimePickerFechaVencimiento.Size = new System.Drawing.Size(548, 39);
            this.dateTimePickerFechaVencimiento.TabIndex = 33;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.numericUpDownStock.ForeColor = System.Drawing.Color.Snow;
            this.numericUpDownStock.Location = new System.Drawing.Point(14, 383);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(557, 39);
            this.numericUpDownStock.TabIndex = 32;
            // 
            // numericUpDownPrecioUnitario
            // 
            this.numericUpDownPrecioUnitario.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.numericUpDownPrecioUnitario.ForeColor = System.Drawing.Color.Snow;
            this.numericUpDownPrecioUnitario.Location = new System.Drawing.Point(17, 275);
            this.numericUpDownPrecioUnitario.Name = "numericUpDownPrecioUnitario";
            this.numericUpDownPrecioUnitario.Size = new System.Drawing.Size(557, 39);
            this.numericUpDownPrecioUnitario.TabIndex = 31;
            // 
            // cbCategoría
            // 
            this.cbCategoría.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoría.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoría.ForeColor = System.Drawing.Color.Snow;
            this.cbCategoría.FormattingEnabled = true;
            this.cbCategoría.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbCategoría.Location = new System.Drawing.Point(17, 620);
            this.cbCategoría.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoría.Name = "cbCategoría";
            this.cbCategoría.Size = new System.Drawing.Size(548, 40);
            this.cbCategoría.TabIndex = 30;
            this.cbCategoría.Text = "Seleccione";
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Estado.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_Estado.Location = new System.Drawing.Point(11, 439);
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
            this.label_Clave.Location = new System.Drawing.Point(8, 335);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 1110);
            this.panel1.TabIndex = 4;
            // 
            // VentanaAgregarCosmetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 1106);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaAgregarCosmetico";
            this.Text = "VentanaAgregarCosmetico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioUnitario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCategoría;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.Label label_Clave;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecioUnitario;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaVencimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImagen;
    }
}