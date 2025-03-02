namespace ExamenGrupo5
{
    partial class VentanaCompras
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCompras));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.PictureBox();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.groupBoxBuscador = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxBuscador.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(3, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 724);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBoxBuscador);
            this.panel1.Location = new System.Drawing.Point(10, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 695);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btn_Editar);
            this.panel2.Controls.Add(this.btn_Volver);
            this.panel2.Controls.Add(this.btn_Imprimir);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btn_agregar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Label);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(32, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 599);
            this.panel2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBox1.ForeColor = System.Drawing.Color.Snow;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pendiente",
            "Completada",
            "Cancelada"});
            this.comboBox1.Location = new System.Drawing.Point(25, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 45);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.EstadoCompraChanged);
            // 
            // btn_Editar
            // 
            this.btn_Editar.AutoSize = true;
            this.btn_Editar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.Snow;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Editar.Location = new System.Drawing.Point(431, 11);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(151, 58);
            this.btn_Editar.TabIndex = 27;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_Volver.Image")));
            this.btn_Volver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Volver.Location = new System.Drawing.Point(904, 15);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(48, 48);
            this.btn_Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Volver.TabIndex = 25;
            this.btn_Volver.TabStop = false;
            this.btn_Volver.Click += new System.EventHandler(this.Salir);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.AutoSize = true;
            this.btn_Imprimir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.ForeColor = System.Drawing.Color.Snow;
            this.btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Imprimir.Location = new System.Drawing.Point(588, 11);
            this.btn_Imprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(152, 58);
            this.btn_Imprimir.TabIndex = 24;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel5.Controls.Add(this.dtgDatos);
            this.panel5.Location = new System.Drawing.Point(1, 129);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(958, 471);
            this.panel5.TabIndex = 23;
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.BackgroundColor = System.Drawing.Color.Snow;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDatos.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgDatos.Location = new System.Drawing.Point(0, 0);
            this.dtgDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.RowHeadersWidth = 51;
            this.dtgDatos.Size = new System.Drawing.Size(958, 471);
            this.dtgDatos.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 80);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // btn_agregar
            // 
            this.btn_agregar.AutoSize = true;
            this.btn_agregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Snow;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_agregar.Location = new System.Drawing.Point(744, 11);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(151, 58);
            this.btn_agregar.TabIndex = 22;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(391, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resultados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.AliceBlue;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Label.Location = new System.Drawing.Point(33, 25);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(335, 38);
            this.Label.TabIndex = 9;
            this.Label.Text = "Estado de la compra";
            this.Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxBuscador
            // 
            this.groupBoxBuscador.Controls.Add(this.panel4);
            this.groupBoxBuscador.Controls.Add(this.label1);
            this.groupBoxBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscador.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxBuscador.Location = new System.Drawing.Point(14, 4);
            this.groupBoxBuscador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBuscador.Name = "groupBoxBuscador";
            this.groupBoxBuscador.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBuscador.Size = new System.Drawing.Size(998, 670);
            this.groupBoxBuscador.TabIndex = 6;
            this.groupBoxBuscador.TabStop = false;
            this.groupBoxBuscador.Text = "Buscador";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(21, 221);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 419);
            this.panel4.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(18, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(4, -15);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1049, 725);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Location = new System.Drawing.Point(10, 15);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1017, 695);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.AliceBlue;
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.txt_Nombre_Producto);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(32, 49);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(947, 598);
            this.panel8.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(377, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 68);
            this.button1.TabIndex = 26;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(842, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(502, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 68);
            this.button2.TabIndex = 24;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel9.Controls.Add(this.dataGridView1);
            this.panel9.Location = new System.Drawing.Point(2, 178);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(945, 420);
            this.panel9.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(945, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.MidnightBlue;
            this.contextMenuStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(201, 80);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 38);
            this.toolStripMenuItem1.Text = "Editar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Snow;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 38);
            this.toolStripMenuItem2.Text = "Eliminar";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(659, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 68);
            this.button3.TabIndex = 22;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txt_Nombre_Producto
            // 
            this.txt_Nombre_Producto.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Nombre_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre_Producto.ForeColor = System.Drawing.Color.Snow;
            this.txt_Nombre_Producto.Location = new System.Drawing.Point(17, 89);
            this.txt_Nombre_Producto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_Nombre_Producto.Name = "txt_Nombre_Producto";
            this.txt_Nombre_Producto.Size = new System.Drawing.Size(903, 39);
            this.txt_Nombre_Producto.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(10, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado de la compra";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(982, 669);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.Location = new System.Drawing.Point(21, 222);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(161, 418);
            this.panel10.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 38);
            this.label5.TabIndex = 9;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VentanaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 694);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VentanaCompras";
            this.Text = "VentanaCompras";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxBuscador.ResumeLayout(false);
            this.groupBoxBuscador.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btn_Volver;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.GroupBox groupBoxBuscador;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_Nombre_Producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
    }
}