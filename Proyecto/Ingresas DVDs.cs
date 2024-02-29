using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto
{
    public partial class Ingresas_DVDs : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        string cadenaConexion;

        public Ingresas_DVDs()
        {
            InitializeComponent();
            cadenaConexion = "Server=127.0.0.1;Port=5432;Database=dvdRental;";
            cadenaConexion += "User Id=postgres;";
            cadenaConexion += "Password=darwin;";
            conexion.ConnectionString = cadenaConexion;

            try
            {
                conexion.Open();
                MessageBox.Show("Conexión realizada con éxito");

                MostrarDatosDeTabla("film");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectarse a la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close(); // Asegúrate de cerrar la conexión en cualquier caso (éxito o error).
            }
        }

        private void MostrarDatosDeTabla(string nombreTabla)
        {
            try
            {
                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter($"SELECT * FROM {nombreTabla}", conexion);
                DataSet dataSet = new DataSet();
                adaptador.Fill(dataSet, nombreTabla);
                DataGridView.DataSource = dataSet.Tables[nombreTabla];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar datos de la tabla {nombreTabla}: {ex.Message}");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string query = "INSERT INTO film (title, description, release_year, language_id, rental_duration, rental_rate, length, replacement_cost, rating, last_update, special_features, fulltext) VALUES (@title, @description, @release_year, @language_id, @rental_duration, @rental_rate, @length, @replacement_cost, @rating, @last_update, @special_features, @fulltext)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@title", textBox13.Text);
                    cmd.Parameters.AddWithValue("@description", textBox2.Text);
                    cmd.Parameters.AddWithValue("@release_year", Convert.ToInt32(textBox3.Text));
                    cmd.Parameters.AddWithValue("@language_id", Convert.ToInt32(textBox4.Text));
                    cmd.Parameters.AddWithValue("@rental_duration", Convert.ToInt32(textBox5.Text));
                    cmd.Parameters.AddWithValue("@rental_rate", Convert.ToDecimal(textBox6.Text));
                    cmd.Parameters.AddWithValue("@length", Convert.ToInt32(textBox7.Text));
                    cmd.Parameters.AddWithValue("@replacement_cost", Convert.ToDecimal(textBox8.Text));
                    cmd.Parameters.AddWithValue("@rating", textBox9.Text);
                    cmd.Parameters.AddWithValue("@last_update", Convert.ToDateTime(textBox10.Text));
                    cmd.Parameters.AddWithValue("@special_features", textBox11.Text);
                    cmd.Parameters.AddWithValue("@fulltext", textBox12.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Película agregada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar agregar película: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnElimar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count > 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = DataGridView.SelectedRows[0];

                    // Obtener el valor de la columna "title"
                    string title = selectedRow.Cells["title"].Value.ToString();

                    // Mostrar mensaje de confirmación
                    DialogResult result = MessageBox.Show($"¿Deseas eliminar la película '{title}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Procesar la decisión del usuario
                    if (result == DialogResult.Yes)
                    {
                        // Obtener el valor de la columna "film_id"
                        int filmId = Convert.ToInt32(selectedRow.Cells["film_id"].Value);

                        // Eliminar la película de la base de datos
                        EliminarPelicula(filmId);

                        // Mostrar mensaje de éxito
                        MessageBox.Show("La película se ha eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar los datos en el DataGridView
                        MostrarDatosDeTabla("film");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una película para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar película: " + ex.Message);
            }
        }

        private void EliminarPelicula(int filmId)
        {
            try
            {
                conexion.Open();

                string query = "DELETE FROM film WHERE film_id = @filmId";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@filmId", filmId);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                conexion.Close();
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            // Abre el formulario del menú del administrador
            AdministradorMenuForm adminMenuForm = new AdministradorMenuForm();
            adminMenuForm.ShowDialog();
        }
    }
}
