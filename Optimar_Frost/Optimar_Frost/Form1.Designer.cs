namespace Optimar_Frost
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnCrearBase = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConectar.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnConectar.Location = new System.Drawing.Point(239, 190);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConectar.Size = new System.Drawing.Size(96, 30);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnCrearBase
            // 
            this.btnCrearBase.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCrearBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCrearBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearBase.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearBase.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnCrearBase.Location = new System.Drawing.Point(360, 256);
            this.btnCrearBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCrearBase.Name = "btnCrearBase";
            this.btnCrearBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearBase.Size = new System.Drawing.Size(75, 34);
            this.btnCrearBase.TabIndex = 1;
            this.btnCrearBase.Text = "Crear base de datos";
            this.btnCrearBase.UseVisualStyleBackColor = false;
            this.btnCrearBase.Visible = false;
            this.btnCrearBase.Click += new System.EventHandler(this.btnCrearBase_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Green;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnEntrar.Location = new System.Drawing.Point(360, 190);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEntrar.Size = new System.Drawing.Size(75, 30);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Visible = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnSalir.Location = new System.Drawing.Point(239, 256);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalir.Size = new System.Drawing.Size(96, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImage = global::Optimar_Frost.Properties.Resources.Fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 292);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnCrearBase);
            this.Controls.Add(this.btnConectar);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPTIMAR FROST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnCrearBase;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSalir;
    }
}

