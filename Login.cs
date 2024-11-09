using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clave5_GrupoDeTrabajo7
{
   
    public partial class frLogin : Form
    {    //Conexion a base de datos
        private string connectionString = "Server=localhost;Database=workoffice;Uid=root;Pwd=root;";
        public frLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Definir Variables
           
            string username = tbUsuario.Text;
            string password = tbPassword.Text;

            VerificarUsuario(username, password);
        }
        private void VerificarUsuario(string username, string password)
        {
            try
            {
                // Crear la conexión con la base de datos
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT tipoUsuario, idUsuario FROM usuarios WHERE username = @username AND pasword = @pasword";
                    using (MySqlCommand cPass = new MySqlCommand(query, conn))
                    {
                        // Pasar parámetros
                        cPass.Parameters.AddWithValue("@username", username);
                        cPass.Parameters.AddWithValue("@pasword", password);

                        // Ejecutar la consulta
                        using (MySqlDataReader reader = cPass.ExecuteReader())

                            if (reader.Read())
                        {
                            // Obtener el tipo de usuario
                            //obtener el id usuario
                            string tipoUsuario = reader["tipoUsuario"].ToString();
                            int idUsuario = Convert.ToInt32(reader["idUsuario"]);
                                


                                // Dependiendo del tipo de usuario, abrir el formulario correspondiente
                                if (tipoUsuario == "usuario")
                            {
                                
                                
                                frMain userForm = new frMain(idUsuario);
                                userForm.Show();
                            }
                            else if (tipoUsuario == "administrador")
                            {
                                frGestionUsuarios adminForm = new frGestionUsuarios();
                                adminForm.Show();
                            }

                            // Cerrar el formulario de login después de iniciar sesión
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }
    }
}
