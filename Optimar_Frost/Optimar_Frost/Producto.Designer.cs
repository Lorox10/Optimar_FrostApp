namespace Optimar_Frost
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.listBoxBuscar = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtCantidadMax = new System.Windows.Forms.TextBox();
            this.grpAgregar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpProductos = new System.Windows.Forms.GroupBox();
            this.radioEliminar = new System.Windows.Forms.RadioButton();
            this.radioAgregar = new System.Windows.Forms.RadioButton();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkPedidos = new System.Windows.Forms.CheckBox();
            this.checkProductos = new System.Windows.Forms.CheckBox();
            this.checkProveedores = new System.Windows.Forms.CheckBox();
            this.checkStock = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAgregar.SuspendLayout();
            this.grpProductos.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 348);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1094, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Crimson;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(13, 13);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // listBoxBuscar
            // 
            this.listBoxBuscar.BackColor = System.Drawing.SystemColors.ControlText;
            this.listBoxBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxBuscar.FormattingEnabled = true;
            this.listBoxBuscar.Items.AddRange(new object[] {
            "pedidos",
            "productos",
            "proveedores",
            "stock"});
            this.listBoxBuscar.Location = new System.Drawing.Point(968, 253);
            this.listBoxBuscar.Name = "listBoxBuscar";
            this.listBoxBuscar.Size = new System.Drawing.Size(120, 56);
            this.listBoxBuscar.TabIndex = 4;
            this.listBoxBuscar.Visible = false;
            this.listBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.listBoxBuscar_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(985, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar Tabla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(102, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(99, 68);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(102, 20);
            this.txtCategoria.TabIndex = 8;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(99, 94);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(33, 20);
            this.txtUnidad.TabIndex = 9;
            // 
            // txtCantidadMax
            // 
            this.txtCantidadMax.Location = new System.Drawing.Point(100, 122);
            this.txtCantidadMax.Name = "txtCantidadMax";
            this.txtCantidadMax.Size = new System.Drawing.Size(32, 20);
            this.txtCantidadMax.TabIndex = 10;
            this.txtCantidadMax.TextChanged += new System.EventHandler(this.txtCantidadMax_TextChanged);
            // 
            // grpAgregar
            // 
            this.grpAgregar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.grpAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpAgregar.Controls.Add(this.label4);
            this.grpAgregar.Controls.Add(this.label3);
            this.grpAgregar.Controls.Add(this.label2);
            this.grpAgregar.Controls.Add(this.label1);
            this.grpAgregar.Controls.Add(this.btnGuardar);
            this.grpAgregar.Controls.Add(this.txtNombre);
            this.grpAgregar.Controls.Add(this.txtCantidadMax);
            this.grpAgregar.Controls.Add(this.txtCategoria);
            this.grpAgregar.Controls.Add(this.txtUnidad);
            this.grpAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgregar.Location = new System.Drawing.Point(497, 147);
            this.grpAgregar.Name = "grpAgregar";
            this.grpAgregar.Size = new System.Drawing.Size(210, 180);
            this.grpAgregar.TabIndex = 11;
            this.grpAgregar.TabStop = false;
            this.grpAgregar.Text = "AGREGAR";
            this.grpAgregar.Visible = false;
            this.grpAgregar.Enter += new System.EventHandler(this.grpAgregar_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad Max.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Unidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGuardar.Location = new System.Drawing.Point(65, 148);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpProductos
            // 
            this.grpProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpProductos.Controls.Add(this.radioEliminar);
            this.grpProductos.Controls.Add(this.radioAgregar);
            this.grpProductos.Controls.Add(this.grpEliminar);
            this.grpProductos.Controls.Add(this.radioButton2);
            this.grpProductos.Controls.Add(this.grpAgregar);
            this.grpProductos.Controls.Add(this.pictureBox2);
            this.grpProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProductos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grpProductos.Location = new System.Drawing.Point(215, 146);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(713, 422);
            this.grpProductos.TabIndex = 16;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "PRODUCTOS";
            this.grpProductos.Visible = false;
            // 
            // radioEliminar
            // 
            this.radioEliminar.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioEliminar.AutoSize = true;
            this.radioEliminar.BackColor = System.Drawing.Color.Transparent;
            this.radioEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEliminar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioEliminar.Location = new System.Drawing.Point(326, 19);
            this.radioEliminar.Name = "radioEliminar";
            this.radioEliminar.Size = new System.Drawing.Size(87, 26);
            this.radioEliminar.TabIndex = 14;
            this.radioEliminar.Text = "ELIMINAR";
            this.radioEliminar.UseVisualStyleBackColor = false;
            this.radioEliminar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioAgregar
            // 
            this.radioAgregar.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioAgregar.AutoSize = true;
            this.radioAgregar.BackColor = System.Drawing.Color.Transparent;
            this.radioAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAgregar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioAgregar.Location = new System.Drawing.Point(221, 18);
            this.radioAgregar.Name = "radioAgregar";
            this.radioAgregar.Size = new System.Drawing.Size(91, 26);
            this.radioAgregar.TabIndex = 13;
            this.radioAgregar.Text = "AGREGAR";
            this.radioAgregar.UseVisualStyleBackColor = false;
            this.radioAgregar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grpEliminar
            // 
            this.grpEliminar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.grpEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpEliminar.Controls.Add(this.label6);
            this.grpEliminar.Controls.Add(this.btnEliminarProducto);
            this.grpEliminar.Controls.Add(this.txtEliminar);
            this.grpEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grpEliminar.Location = new System.Drawing.Point(532, 137);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(141, 117);
            this.grpEliminar.TabIndex = 18;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "ELIMINAR";
            this.grpEliminar.Visible = false;
            this.grpEliminar.Enter += new System.EventHandler(this.grpEliminar_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProducto.Location = new System.Drawing.Point(44, 78);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 1;
            this.btnEliminarProducto.Text = "ELIMINAR";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(33, 39);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton2.Location = new System.Drawing.Point(433, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 26);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Optimar_Frost.Properties.Resources.Q2Es;
            this.pictureBox2.Location = new System.Drawing.Point(0, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(713, 403);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(155, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "ELIGE LA TABLA QUE QUIERES UTILIZAR";
            // 
            // checkPedidos
            // 
            this.checkPedidos.AutoSize = true;
            this.checkPedidos.BackColor = System.Drawing.Color.Black;
            this.checkPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPedidos.ForeColor = System.Drawing.Color.Orange;
            this.checkPedidos.Location = new System.Drawing.Point(168, 56);
            this.checkPedidos.Name = "checkPedidos";
            this.checkPedidos.Size = new System.Drawing.Size(86, 22);
            this.checkPedidos.TabIndex = 17;
            this.checkPedidos.Text = "Pedidos";
            this.checkPedidos.UseVisualStyleBackColor = false;
            this.checkPedidos.CheckedChanged += new System.EventHandler(this.checkPedidos_CheckedChanged);
            // 
            // checkProductos
            // 
            this.checkProductos.AutoSize = true;
            this.checkProductos.BackColor = System.Drawing.Color.Black;
            this.checkProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkProductos.ForeColor = System.Drawing.Color.Orange;
            this.checkProductos.Location = new System.Drawing.Point(168, 88);
            this.checkProductos.Name = "checkProductos";
            this.checkProductos.Size = new System.Drawing.Size(103, 22);
            this.checkProductos.TabIndex = 18;
            this.checkProductos.Text = "Productos";
            this.checkProductos.UseVisualStyleBackColor = false;
            this.checkProductos.CheckedChanged += new System.EventHandler(this.checkProductos_CheckedChanged);
            // 
            // checkProveedores
            // 
            this.checkProveedores.AutoSize = true;
            this.checkProveedores.BackColor = System.Drawing.Color.Black;
            this.checkProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkProveedores.ForeColor = System.Drawing.Color.Orange;
            this.checkProveedores.Location = new System.Drawing.Point(365, 56);
            this.checkProveedores.Name = "checkProveedores";
            this.checkProveedores.Size = new System.Drawing.Size(121, 22);
            this.checkProveedores.TabIndex = 19;
            this.checkProveedores.Text = "Proveedores";
            this.checkProveedores.UseVisualStyleBackColor = false;
            this.checkProveedores.CheckedChanged += new System.EventHandler(this.checkProveedores_CheckedChanged);
            // 
            // checkStock
            // 
            this.checkStock.AutoSize = true;
            this.checkStock.BackColor = System.Drawing.Color.Black;
            this.checkStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStock.ForeColor = System.Drawing.Color.Orange;
            this.checkStock.Location = new System.Drawing.Point(365, 88);
            this.checkStock.Name = "checkStock";
            this.checkStock.Size = new System.Drawing.Size(69, 22);
            this.checkStock.TabIndex = 20;
            this.checkStock.Text = "Stock";
            this.checkStock.UseVisualStyleBackColor = false;
            this.checkStock.CheckedChanged += new System.EventHandler(this.checkStock_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::Optimar_Frost.Properties.Resources._4Cb2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1153, 667);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 654);
            this.ControlBox = false;
            this.Controls.Add(this.checkStock);
            this.Controls.Add(this.checkProveedores);
            this.Controls.Add(this.checkProductos);
            this.Controls.Add(this.checkPedidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpProductos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxBuscar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPTIMAR FROST";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAgregar.ResumeLayout(false);
            this.grpAgregar.PerformLayout();
            this.grpProductos.ResumeLayout(false);
            this.grpProductos.PerformLayout();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ListBox listBoxBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtCantidadMax;
        private System.Windows.Forms.GroupBox grpAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkPedidos;
        private System.Windows.Forms.CheckBox checkProductos;
        private System.Windows.Forms.CheckBox checkProveedores;
        private System.Windows.Forms.CheckBox checkStock;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioEliminar;
        private System.Windows.Forms.RadioButton radioAgregar;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}