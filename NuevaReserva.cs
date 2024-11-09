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
using Microsoft.VisualBasic;

namespace Clave5_GrupoDeTrabajo7
{
    public partial class NuevaReserva : Form
    {
        //defnirvariables globales
        private int idUsuario;
        int nAsistentes;
        string horario;
        int idHorario;
        DateTime fechaReserva;
        double total = 0.0;
        string salonSeleccionado;
        int idSalon;
        string nombreAsistente;
        int idMenu;

        //Conexion a base de datos
        private string connectionString = "Server=localhost;Database=workoffice;Uid=root;Pwd=root;";
        public NuevaReserva(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            MessageBox.Show(idUsuario.ToString());

        }

        private void NuevaReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form frMain
            frMain frMain = new frMain(idUsuario);

            // Mostrar Form frMain y cerrar NuevasReservas
            frMain.Show(); // Abre frMain 
            this.Close(); //  Cierra NuevasReservas
        }




        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string salonSeleccionado = cbSalon.SelectedItem.ToString();
            idSalon = ObteneridSalon(salonSeleccionado);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                //query de mysql
                conn.Open();
                string query = "SELECT capacidad FROM salones WHERE nombreSalon = @nombreSalon";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombreSalon", salonSeleccionado);
                    nAsistentes = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show(nAsistentes.ToString(),idSalon.ToString());
                }
            }

            
        }

        // Método para obtener el ID en base al valor seleccionado en el ComboBox salon
        public int ObteneridSalon(string salonSeleccionado)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idSalon FROM salones WHERE nombreSalon = @nombreSalon";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreSalon", salonSeleccionado);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idSalon = reader.GetInt32("idSalon");
                        }
                    }
                }
            }

            return idSalon;
        }

        private void cbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            horario = cbHorario.Text;
            idHorario = ObteneridHorario(horario);

            MessageBox.Show(horario,idHorario.ToString());
        }
        // Método para obtener el ID en base al valor seleccionado en el ComboBox horario
        public int ObteneridHorario(string horario)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idHorario FROM horarios WHERE descripcionHorarios = @descripcionHorarios";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@descripcionHorarios", horario);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idHorario = reader.GetInt32("idHorario");
                        }
                    }
                }
            }

            return idHorario;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaReserva = dtpFecha.Value;
            MessageBox.Show(fechaReserva.ToShortDateString());
        }


        private void btnAgregarAsistentes_Click(object sender, EventArgs e)
        {
            int contarAsistentes = 0;

            try
            {
                while (contarAsistentes < nAsistentes)
                {
                    // Usar InputBox para obtener nombre del invitado y el número de menú
                    nombreAsistente = Interaction.InputBox("Ingrese el nombre del invitado:", "Nombre del Invitado");
                    string numeroMenuStr = Interaction.InputBox("Ingrese el número de menú: Opciones 1,2 o 3", "Menú");
                    int numeroMenu = int.Parse(numeroMenuStr);

                    // Consultar el precio del menú desde la base de datos
                    double precioMenu = 0;
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT precio FROM menu WHERE idMenu = @idMenu";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@idMenu", numeroMenu);
                            precioMenu = Convert.ToDouble(cmd.ExecuteScalar());
                        }
                    }

                    // Añadir a DataGridView
                    dgvAsistentes.Rows.Add(nombreAsistente, numeroMenu, precioMenu);

                    // Acumular total
                    total += precioMenu;
                    contarAsistentes++;
                }

                // Mostrar total en Label
                lblTotal.Text = $"Total: ${total}";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Guardar en la tabla de reservaciones
                    string insertReservacion = "INSERT INTO reservaciones (fecha, idUsuario, idSalon, idHorario, totalPagar) " +
                                               "VALUES (@fecha, @idUsuario, @idSalon, @idHorario, @totalPagar)";
                    using (MySqlCommand cmd = new MySqlCommand(insertReservacion, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fechaReserva);
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@idSalon", idSalon);
                        cmd.Parameters.AddWithValue("@idHorario", idHorario);
                        cmd.Parameters.AddWithValue("@totalPagar", total);
                        cmd.ExecuteNonQuery();
                    }
                    // Confirmar la transacción si todo sale bien
                    transaction.Commit();
                    MessageBox.Show("Reservación guardada con éxito.");
                }
                catch (Exception ex)
                {
                    // Hacer rollback si ocurre algún error
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }

            //    using (MySqlConnection conn = new MySqlConnection(connectionString))
            //    {
            //        conn.Open();
            //        MySqlTransaction transaction = conn.BeginTransaction();

            //        try
            //        {
            //            // Guardar en la tabla de reservaciones
            //            string insertReservacion = "INSERT INTO reservaciones (fecha, idUsuario, idSalon, idHorario, totalPagar) " +
            //                                       "VALUES (@fecha, @idUsuario, @idSalon, @idHorario, @totalPagar)";
            //            using (MySqlCommand cmd = new MySqlCommand(insertReservacion, conn, transaction))
            //            {
            //                cmd.Parameters.AddWithValue("@fecha", fechaReserva);
            //                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            //                cmd.Parameters.AddWithValue("@idSalon", idSalon);
            //                cmd.Parameters.AddWithValue("@idHorario", idHorario);
            //                cmd.Parameters.AddWithValue("@totalPagar", total);
            //                cmd.ExecuteNonQuery();
            //            }

            //            ////foreach (DataGridViewRow row in dgvAsistentes.Rows)
            //            ////{
            //            ////    nombreAsistente = row.Cells["Invitado"].Value.ToString();
            //            ////    idMenu = Convert.ToInt32(row.Cells["Menu"].Value);


            //            ////    string insertAsistente = "INSERT INTO asistentes ( nombreAsistente, idMenu, idUsuario) " +
            //            ////                             "VALUES (@nombreAsistente, @idMenu,@idUsuario)";
            //            ////    using (MySqlCommand cmd = new MySqlCommand(insertAsistente, conn, transaction))
            //            ////    {
            //            ////        cmd.Parameters.AddWithValue("@nombreAsistente", nombreAsistente);
            //            ////        cmd.Parameters.AddWithValue("@idMenu", idMenu);
            //            ////        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            //            ////        cmd.ExecuteNonQuery();
            //            ////    }

            //            //}
            //        }
            //        catch (Exception ex)
            //        {
            //            transaction.Rollback();
            //            MessageBox.Show("Error al guardar: " + ex.Message);
            //        }   



            //    }

        }

    }
}

