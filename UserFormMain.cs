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
    public partial class frMain : Form
    {
        private int idUsuario;
        public frMain(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            MessageBox.Show(idUsuario.ToString());
           
        }
        
        
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Crear una instancia de frLogin
            frLogin frLogin = new frLogin();

            // Mostrar Form frLogin y cerrar UserFormMain
            frLogin.Show(); // Abre frLogin 
            this.Close(); //  Cierra UserFormMain
        }

        public void btnVerMisReservas_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form VerMisReservas
            VerMisReservas VerMisReservas = new VerMisReservas(idUsuario);

            // Mostrar Form VerMisReservas y cerrar UserFormMain
            VerMisReservas.Show(); // Abre VerMisReservas 
            this.Close(); //  Cierra UserFormMain
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form VerMisReservas
            NuevaReserva NuevaReserva = new NuevaReserva(idUsuario);

            // Mostrar Form VerMisReservas y cerrar UserFormMain
            NuevaReserva.Show(); // Abre NuevaReserva 
            this.Close(); //  Cierra UserFormMain
        }
    }
}
