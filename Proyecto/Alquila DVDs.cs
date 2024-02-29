using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto
{
    public partial class Alquila_DVDs : Form

    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        string cadenaConexion;
        public Alquila_DVDs()
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

                // Crear un adaptador de datos y un conjunto de datos
                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter($"SELECT * FROM {nombreTabla}", conexion);
                DataSet dataSet = new DataSet();

                // Llenar el conjunto de datos con los datos de la tabla
                adaptador.Fill(dataSet, nombreTabla);

                // Asignar el conjunto de datos a un control (puedes usar un DataGridView por ejemplo)
                dataAlquiler.DataSource = dataSet.Tables[nombreTabla];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar datos de la tabla {nombreTabla}: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataAlquiler.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataAlquiler.SelectedRows[0];

                // Verificar la existencia de la columna "title"
                if (selectedRow.Cells["title"].Value != null)
                {
                    // Obtener el valor de la columna "title"
                    string title = selectedRow.Cells["title"].Value.ToString();

                    // Mostrar mensaje de alquiler
                    MessageBox.Show($"La película '{title}' será alquilada.");

                    // Cambiar el color de la fila a rojo
                    selectedRow.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("La columna 'title' no tiene un valor en la fila seleccionada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una película para alquilar.");
            }

        }
    }
}
