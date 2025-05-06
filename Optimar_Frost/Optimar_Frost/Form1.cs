using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Optimar_Frost
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;password=Milgause-59;"; 
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            PictureBox pictureBoxBackground = new PictureBox();
            pictureBoxBackground.Dock = DockStyle.Fill;  
            pictureBoxBackground.Image = Properties.Resources.Fondo1;  
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBoxBackground);
            pictureBoxBackground.SendToBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (Connect())
            {
                MessageBox.Show("Conexión Exitosa", "Optimar Frost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEntrar.Visible=true;
                btnCrearBase.Visible = true;
            }
            else
            {
                MessageBox.Show("Error al conectar", "Optimar Frost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
                
        }

        private void btnCrearBase_Click(object sender, EventArgs e)
        {
            if (Connect())
            {
                try
                {
                    CreateDatabaseAndTables();
                    MessageBox.Show("Base de datos y tablas creadas exitosamente", "Optimar Frost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear la base de datos: {ex.Message}", "Optimar Frost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private bool Connect()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar: {ex.Message}");
                return false;
            }
        }

        private void CreateDatabaseAndTables()
        {
            string queryDB = "CREATE DATABASE IF NOT EXISTS Optimar_Frost;";
            string queryUse = "USE Optimar_Frost;";

            string queryProductos = @"
        CREATE TABLE IF NOT EXISTS Productos (
            id_producto INT PRIMARY KEY AUTO_INCREMENT,
            nombre VARCHAR(100) NOT NULL,
            categoria VARCHAR(50) NOT NULL,
            unidad_medida VARCHAR(20) NOT NULL,
            cantidad_maxima FLOAT CHECK (cantidad_maxima >= 0)
        );";

            string queryProveedores = @"
        CREATE TABLE IF NOT EXISTS Proveedores (
            id_proveedor INT PRIMARY KEY AUTO_INCREMENT,
            nombre VARCHAR(100) NOT NULL,
            contacto VARCHAR(100) NOT NULL
        );";

            string queryStock = @"
        CREATE TABLE IF NOT EXISTS Stock (
            id_stock INT PRIMARY KEY AUTO_INCREMENT,
            id_producto INT NOT NULL,
            cantidad_actual FLOAT NOT NULL CHECK (cantidad_actual >= 0),
            fecha_actualizacion DATETIME NOT NULL,
            FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
        );";

            string queryPedidos = @"
        CREATE TABLE IF NOT EXISTS Pedidos (
            id_pedido INT PRIMARY KEY AUTO_INCREMENT,
            id_producto INT,
            cantidad_pedida FLOAT CHECK (cantidad_pedida > 0),
            fecha_pedido DATETIME,
            estado VARCHAR(20) NOT NULL CHECK (estado IN ('Pendiente', 'Procesado', 'Entregado', 'Cancelado')),
            id_proveedor INT NOT NULL,
            fecha_programada DATETIME,
            FOREIGN KEY (id_producto) REFERENCES Productos(id_producto),
            FOREIGN KEY (id_proveedor) REFERENCES Proveedores(id_proveedor)
        );";

            MySqlCommand cmd = new MySqlCommand("", connection);
            cmd.CommandText = queryDB;
            cmd.ExecuteNonQuery();
            cmd.CommandText = queryUse;
            cmd.ExecuteNonQuery();
            cmd.CommandText = queryProductos;
            cmd.ExecuteNonQuery();
            cmd.CommandText = queryProveedores;
            cmd.ExecuteNonQuery();
            cmd.CommandText = queryStock;
            cmd.ExecuteNonQuery();
            cmd.CommandText = queryPedidos;
            cmd.ExecuteNonQuery();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

             producto.Show();

            this.Hide();
        }
    }
}
