namespace ExamenGrupo5
{
    partial class VentanaConsumidor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImprimirBTN = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelDerecha = new System.Windows.Forms.Panel();
            this.labelConsumidor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxAccesos = new System.Windows.Forms.GroupBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonGestion = new System.Windows.Forms.Button();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelDerecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxAccesos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.ImprimirBTN);
            this.panel1.Location = new System.Drawing.Point(267, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 82);
            this.panel1.TabIndex = 21;
            // 
            // ImprimirBTN
            // 
            this.ImprimirBTN.BackColor = System.Drawing.Color.Goldenrod;
            this.ImprimirBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ImprimirBTN.ForeColor = System.Drawing.Color.Black;
            this.ImprimirBTN.Location = new System.Drawing.Point(637, 17);
            this.ImprimirBTN.Margin = new System.Windows.Forms.Padding(4);
            this.ImprimirBTN.Name = "ImprimirBTN";
            this.ImprimirBTN.Size = new System.Drawing.Size(149, 39);
            this.ImprimirBTN.TabIndex = 1;
            this.ImprimirBTN.Text = "Imprimir";
            this.ImprimirBTN.UseVisualStyleBackColor = false;
            this.ImprimirBTN.Click += new System.EventHandler(this.ImprimirBTN_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Snow;
            this.panelPrincipal.Location = new System.Drawing.Point(263, 80);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(815, 480);
            this.panelPrincipal.TabIndex = 20;
            // 
            // panelDerecha
            // 
            this.panelDerecha.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelDerecha.Controls.Add(this.labelConsumidor);
            this.panelDerecha.Controls.Add(this.pictureBox1);
            this.panelDerecha.Controls.Add(this.groupBoxAccesos);
            this.panelDerecha.Location = new System.Drawing.Point(-5, -2);
            this.panelDerecha.Margin = new System.Windows.Forms.Padding(4);
            this.panelDerecha.Name = "panelDerecha";
            this.panelDerecha.Size = new System.Drawing.Size(273, 566);
            this.panelDerecha.TabIndex = 19;
            // 
            // labelConsumidor
            // 
            this.labelConsumidor.AutoSize = true;
            this.labelConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelConsumidor.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelConsumidor.Location = new System.Drawing.Point(80, 129);
            this.labelConsumidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConsumidor.Name = "labelConsumidor";
            this.labelConsumidor.Size = new System.Drawing.Size(109, 20);
            this.labelConsumidor.TabIndex = 3;
            this.labelConsumidor.Text = "Consumidor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxAccesos
            // 
            this.groupBoxAccesos.Controls.Add(this.buttonVolver);
            this.groupBoxAccesos.Controls.Add(this.buttonGestion);
            this.groupBoxAccesos.Controls.Add(this.buttonReporte);
            this.groupBoxAccesos.Controls.Add(this.buttonMostrar);
            this.groupBoxAccesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxAccesos.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBoxAccesos.Location = new System.Drawing.Point(29, 175);
            this.groupBoxAccesos.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAccesos.Name = "groupBoxAccesos";
            this.groupBoxAccesos.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAccesos.Size = new System.Drawing.Size(227, 346);
            this.groupBoxAccesos.TabIndex = 0;
            this.groupBoxAccesos.TabStop = false;
            this.groupBoxAccesos.Text = "Accesos Rápidos";
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonVolver.ForeColor = System.Drawing.Color.Black;
            this.buttonVolver.Location = new System.Drawing.Point(40, 273);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(149, 33);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            // 
            // buttonGestion
            // 
            this.buttonGestion.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGestion.ForeColor = System.Drawing.Color.Black;
            this.buttonGestion.Location = new System.Drawing.Point(40, 121);
            this.buttonGestion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGestion.Name = "buttonGestion";
            this.buttonGestion.Size = new System.Drawing.Size(149, 33);
            this.buttonGestion.TabIndex = 3;
            this.buttonGestion.Text = "Gestión";
            this.buttonGestion.UseVisualStyleBackColor = false;
            // 
            // buttonReporte
            // 
            this.buttonReporte.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonReporte.ForeColor = System.Drawing.Color.Black;
            this.buttonReporte.Location = new System.Drawing.Point(40, 197);
            this.buttonReporte.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(149, 33);
            this.buttonReporte.TabIndex = 1;
            this.buttonReporte.Text = "Reporte";
            this.buttonReporte.UseVisualStyleBackColor = false;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMostrar.ForeColor = System.Drawing.Color.Black;
            this.buttonMostrar.Location = new System.Drawing.Point(40, 49);
            this.buttonMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(149, 33);
            this.buttonMostrar.TabIndex = 0;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            // 
            // VentanaConsumidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelDerecha);
            this.Name = "VentanaConsumidor";
            this.Text = "VentanaConsumidor";
            this.panel1.ResumeLayout(false);
            this.panelDerecha.ResumeLayout(false);
            this.panelDerecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxAccesos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ImprimirBTN;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelDerecha;
        private System.Windows.Forms.Label labelConsumidor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxAccesos;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonGestion;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Button buttonMostrar;
    }
}