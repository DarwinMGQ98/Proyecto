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
    public partial class Pagar_por_el_alquiler : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        string cadenaConexion;
        public Pagar_por_el_alquiler()
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

                    MostrarDatosDeTabla("payment");
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
                    dataPago.DataSource = dataSet.Tables[nombreTabla];
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al mostrar datos de la tabla {nombreTabla}: {ex.Message}");
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataPago.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataPago.SelectedRows[0];

                // Verificar la existencia de la columna "amount"
                if (selectedRow.Cells["amount"].Value != null)
                {
                    // Obtener el valor de la columna "amount"
                    string amount = selectedRow.Cells["amount"].Value.ToString();

                    // Mostrar mensaje de pago
                    MessageBox.Show($"Usted debe pagar por el alquiler: {amount} $");

                    // Cambiar el color de la celda a verde
                    selectedRow.Cells["amount"].Style.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("La columna 'amount' no tiene un valor en la fila seleccionada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para realizar el pago.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            this.Close();

            ClienteMenu clienteMenuForm = new ClienteMenu();
            clienteMenuForm.ShowDialog(); 
        }
    }
}
    
