
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
                MessageBox.Show("Conexi�n realizada con �xito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectarse a la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close(); // Aseg�rate de cerrar la conexi�n en cualquier caso (�xito o error).
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Abre el formulario de men� para administrador
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