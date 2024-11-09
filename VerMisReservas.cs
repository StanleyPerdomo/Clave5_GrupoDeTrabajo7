using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace Clave5_GrupoDeTrabajo7
{
    
    public partial class VerMisReservas : Form
    {
        private int idUsuario;
        //Conexion a base de datos
        private string connectionString = "Server=localhost;Database=workoffice;Uid=root;Pwd=root;";
        public VerMisReservas(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            MessageBox.Show(idUsuario.ToString());

            CargarReservas();
        }

        private void CargarReservas()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                   r.idReservacion, 
                                    r.fecha, 
                                    u.nombre AS nombre, 
                                    s.nombreSalon AS nombreSalon, 
                                    h.descripcionHorarios AS descripcionHorarios
                                FROM
                                    reservaciones r
                                JOIN
                                    usuarios u ON r.idUsuario = u.idUsuario
                                JOIN
                                    salones s ON r.idSalon = s.idSalon
                                JOIN
                                    horarios h ON r.idHorario = h.idHorario
                                WHERE
                                    r.idUsuario = @idUsuario; ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                        // Cargar los datos en un DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable reservacionesTable = new DataTable();
                            adapter.Fill(reservacionesTable);

                            // Asignar el DataTable al DataGridView
                            dgvReservas.DataSource = reservacionesTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void btnAtras_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form frMain
            frMain frMain   = new frMain(idUsuario);

            // Mostrar Form  frMain y cerrar VerMisReservas
            frMain.Show(); // Abre frMain 
            this.Close(); //  Cierra VerMisReservas
        }
    }
}
