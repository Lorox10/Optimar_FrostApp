using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Optimar_Frost
{
    public partial class Producto : Form
    {
        private string connStr = "server=localhost;user=root;password=Milgause-59;database=Optimar_Frost;";

        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            CargarTablasEnListBox();
        }

        private void CargarTablasEnListBox()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    DataTable tables = conn.GetSchema("Tables");
                    listBoxBuscar.Items.Clear();

                    foreach (DataRow row in tables.Rows)
                    {
                        string tableName = row[2].ToString();
                        listBoxBuscar.Items.Add(tableName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron cargar las tablas: " + ex.Message);
                }
            }
        }

        private void listBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreTabla = listBoxBuscar.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombreTabla))
            {
                MessageBox.Show("Por favor selecciona una tabla.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM `{nombreTabla}`"; 

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al consultar la tabla:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkProductos.Checked==true|| checkPedidos.Checked == true || checkProveedores.Checked == true || checkStock.Checked == true)
            {
                dataGridView1.Visible = false;
            }
            else
            {
                listBoxBuscar.Visible = true;
                dataGridView1.Visible = true;
                grpProductos.Visible = false;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            grpAgregar.Visible=true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string categoria = txtCategoria.Text.Trim();
            string unidad = txtUnidad.Text.Trim();
            string cantidadStr = txtCantidadMax.Text.Trim();

            if (nombre == "" || categoria == "" || unidad == "" || cantidadStr == "")
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            if (!float.TryParse(cantidadStr, out float cantidadMaxima))
            {
                MessageBox.Show("La cantidad máxima debe ser un número válido.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Productos (nombre, categoria, unidad_medida, cantidad_maxima) " +
                                   "VALUES (@nombre, @categoria, @unidad, @cantidadMaxima)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@unidad", unidad);
                    cmd.Parameters.AddWithValue("@cantidadMaxima", cantidadMaxima);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar producto: " + ex.Message);
                }
            }
        }

        private void txtCantidadMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAgregar.Checked == true)
            {
                grpAgregar.Visible = true;
                grpEliminar.Visible = false;
                grpAgregar.BackColor = Color.Transparent;
            }
            else
            {
                grpAgregar.Visible = false;
            }
            
        }

        private void checkProductos_CheckedChanged(object sender, EventArgs e)
        {
            if(checkProductos.Checked == true){

                checkPedidos.Checked = false;
                checkProveedores.Checked = false;
                checkStock.Checked = false;
                dataGridView1.Enabled = false;

                grpProductos.Visible = true;
                dataGridView1.Visible = false;
                listBoxBuscar.Visible = false;

            }
            else {
                grpProductos.Visible = false;

            }
            

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioEliminar.Checked == true)
            {
                grpEliminar.Visible = true;
                grpAgregar.Visible = false;
            }
            else
            {
                grpEliminar.Visible = false;
            }
            
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEliminar.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingresa un ID válido.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Productos WHERE id_producto = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                        MessageBox.Show("Producto eliminado.");
                    else
                        MessageBox.Show("No se encontró el producto.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

       

        private void grpEliminar_Enter(object sender, EventArgs e)
        {

        }

        private void grpAgregar_Enter(object sender, EventArgs e)
        {
           

        }

        private void checkPedidos_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void checkProveedores_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void checkStock_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
    }
}
