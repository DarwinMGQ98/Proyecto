
using Npgsql;

namespace Proyecto

{
    public partial class Form1 : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        string cadenaConexion;

        public Form1()
        {
            InitializeComponent();
            /*cadenaConexion = "Server=127.0.0.1;Port=5432;Database=dvdRental;";
            cadenaConexion += "User Id=postgres;";
            cadenaConexion += "Password=darwin;";
            conexion.ConnectionString = cadenaConexion;

            try
            {
                conexion.Open();
                MessageBox.Show("Conexión realizada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectarse a la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close(); // Asegúrate de cerrar la conexión en cualquier caso (éxito o error).
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Abre el formulario de menú para administrador
            AdministradorMenuForm adminMenuForm = new AdministradorMenuForm();
            adminMenuForm.ShowDialog(); // Usa ShowDialog para bloquear el formulario principal
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClienteMenu clienteMenuForm = new ClienteMenu();
            clienteMenuForm.ShowDialog(); // Usa ShowDialog para bloquear el formulario principal
        }
    }
}