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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto
{
    public partial class Historial_del_Cliente : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        string cadenaConexion;
        public Historial_del_Cliente()
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

                MostrarDatosDeTabla("customer");
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
                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter($"SELECT * FROM  {nombreTabla}", conexion);
                DataSet dataSet = new DataSet();

                // Llenar el conjunto de datos con los datos de la tabla
                adaptador.Fill(dataSet, nombreTabla);

                // Asignar el conjunto de datos a un control (puedes usar un DataGridView por ejemplo)
                dataHistorial.DataSource = dataSet.Tables[nombreTabla];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar datos de la tabla {nombreTabla}: {ex.Message}");
            }
        }
        
        private void MostrarDatosRental()
        {
            try
            {
                
                if(textBox1.Text != "")
                {
                    int idCustomer = Convert.ToInt32(textBox1.Text);
                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter($"select r.rental_id, r.customer_id, c.first_name, c.last_name, f.title, f.description, f.replacement_cost  from rental r  " +
                    $"inner join inventory i on r.inventory_id = i.inventory_id " +
                    $"inner join film f on i.film_id = f.film_id " +
                    $"inner join customer c on c.customer_id = r.customer_id " +
                    $"where r.customer_id = {idCustomer}", conexion);
                    DataSet dataSet = new DataSet();

                    // Llenar el conjunto de datos con los datos de la tabla
                    adaptador.Fill(dataSet, "rental");
                    dataGridView1.DataSource = dataSet.Tables["rental"];
                } else
                {
                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter($"select * from rental where customer_id = -1", conexion);
                    DataSet dataSet = new DataSet();

                    // Llenar el conjunto de datos con los datos de la tabla
                    adaptador.Fill(dataSet, "rental");
                    dataGridView1.DataSource = dataSet.Tables["rental"];
                }
          
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar datos de la tabla rental: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreTabla = "customer";
            int idCustomer = Convert.ToInt32(textBox1.Text);
            conexion.Open();
            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter($"SELECT * FROM customer where customer_id = {idCustomer}", conexion);
            DataSet dataSet = new DataSet();

            // Llenar el conjunto de datos con los datos de la tabla
            adaptador.Fill(dataSet, nombreTabla);

            // Asignar el conjunto de datos a un control (puedes usar un DataGridView por ejemplo)
            dataHistorial.DataSource = dataSet.Tables[nombreTabla];
            MostrarDatosRental();
            conexion.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MostrarDatosDeTabla("customer");
            textBox1.Text = "";
            MostrarDatosRental();
            conexion.Close();
        }
    }
}
