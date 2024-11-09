using System;
namespace Clave5_GrupoDeTrabajo7
{
    partial class frMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnVerMisReservas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de reserva de salas de reuniones";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(17, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(521, 72);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Bienvenido al sistema de reservacion AWOffice,\ncontamos con 3 salones disponibles" +
    " para hacer de tus meetings una experiencia, comoda,\nagradable y diferente.\n\nNue" +
    "stros salones disponibles son:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(17, 150);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(358, 96);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Salon A\n\nCapacidad para 8 personas.\nEdificio Insigne, Av. Las Magnolias 206, San " +
    "Salvador.\nPiso 2, Room #12.\nTamaño: 6  x 8 m.\nMesa tipo rectangular, Sillas ejec" +
    "utivas, Oasis. ";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(17, 252);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(358, 96);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "Salon B\n\nCapacidad para 8 personas.\nEdificio Insigne, Av. Las Magnolias 206, San " +
    "Salvador.\nPiso 5, Room #7.\nTamaño: 8  x 8 m.\nMesa tipo rectangular, Sillas ejecu" +
    "tivas, Oasis, Proyector/ Pantalla. ";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(17, 354);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(358, 96);
            this.richTextBox4.TabIndex = 4;
            this.richTextBox4.Text = "Salon C\n\nCapacidad para 12 personas.\nEdificio Insigne, Av. Las Magnolias 206, San" +
    " Salvador.\nPiso 17, Room #3.\nTamaño: 10  x 12 m.\nMesa tipo rectangular, Sillas e" +
    "jecutivas, Oasis, Pantalla, cafetera. ";
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Location = new System.Drawing.Point(6, 19);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(188, 44);
            this.btnNuevaReserva.TabIndex = 8;
            this.btnNuevaReserva.Text = "Nueva reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // btnVerMisReservas
            // 
            this.btnVerMisReservas.Location = new System.Drawing.Point(6, 69);
            this.btnVerMisReservas.Name = "btnVerMisReservas";
            this.btnVerMisReservas.Size = new System.Drawing.Size(188, 44);
            this.btnVerMisReservas.TabIndex = 9;
            this.btnVerMisReservas.Text = "Ver mis reservas";
            this.btnVerMisReservas.UseVisualStyleBackColor = true;
            this.btnVerMisReservas.Click += new System.EventHandler(this.btnVerMisReservas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(556, 412);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 38);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevaReserva);
            this.groupBox1.Controls.Add(this.btnVerMisReservas);
            this.groupBox1.Location = new System.Drawing.Point(556, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 345);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Clave5_GrupoDeTrabajo7.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(381, 354);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Clave5_GrupoDeTrabajo7.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(381, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clave5_GrupoDeTrabajo7.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(381, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "frMain";
            this.Text = "Alquiler Work Office S.A de C.V";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnVerMisReservas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

