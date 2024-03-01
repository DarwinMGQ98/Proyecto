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
    public partial class Ordenados_Por_Genero : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        string cadenaConexion;

        public Ordenados_Por_Genero()
        {
            
                InitializeComponent();
                cadenaConexion = "Server=127.0.0.1;Port=5432;Database=dvdRental;";
                cadenaConexion += "User Id=postgres;";
                cadenaConexion += "Password=root;";
                conexion.ConnectionString = cadenaConexion;

                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexión realizada con éxito");

                    MostrarDatosDeTabla("category");
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
                    dataGenero.DataSource = dataSet.Tables[nombreTabla];
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al mostrar datos de la tabla {nombreTabla}: {ex.Message}");
                }
            }

     }
}
    
