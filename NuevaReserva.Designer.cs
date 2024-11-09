
namespace Clave5_GrupoDeTrabajo7
{
    partial class NuevaReserva
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarAsistentes = new System.Windows.Forms.Button();
            this.dgvAsistentes = new System.Windows.Forms.DataGridView();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Invitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horario:";
            // 
            // btnAgregarAsistentes
            // 
            this.btnAgregarAsistentes.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarAsistentes.Name = "btnAgregarAsistentes";
            this.btnAgregarAsistentes.Size = new System.Drawing.Size(228, 23);
            this.btnAgregarAsistentes.TabIndex = 3;
            this.btnAgregarAsistentes.Text = "Agregar asistentes";
            this.btnAgregarAsistentes.UseVisualStyleBackColor = true;
            this.btnAgregarAsistentes.Click += new System.EventHandler(this.btnAgregarAsistentes_Click);
            // 
            // dgvAsistentes
            // 
            this.dgvAsistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invitado,
            this.Menu,
            this.Precio});
            this.dgvAsistentes.Location = new System.Drawing.Point(6, 48);
            this.dgvAsistentes.Name = "dgvAsistentes";
            this.dgvAsistentes.Size = new System.Drawing.Size(348, 370);
            this.dgvAsistentes.TabIndex = 4;
            // 
            // cbSalon
            // 
            this.cbSalon.FormattingEnabled = true;
            this.cbSalon.Items.AddRange(new object[] {
            "Salon A",
            "Salon B",
            "Salon C"});
            this.cbSalon.Location = new System.Drawing.Point(60, 19);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(181, 21);
            this.cbSalon.TabIndex = 5;
            this.cbSalon.SelectedIndexChanged += new System.EventHandler(this.cbSalon_SelectedIndexChanged);
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Items.AddRange(new object[] {
            "07:00 am a 10:00 am",
            "11:00 am a 02:00 pm",
            "03:00 pm a 05:00 pm",
            "06:00 pm a 9:00 pm"});
            this.cbHorario.Location = new System.Drawing.Point(60, 50);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(181, 21);
            this.cbHorario.TabIndex = 6;
            this.cbHorario.SelectedIndexChanged += new System.EventHandler(this.cbHorario_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarAsistentes);
            this.groupBox1.Controls.Add(this.dgvAsistentes);
            this.groupBox1.Location = new System.Drawing.Point(279, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 433);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de asistentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total a cancelar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.cbSalon);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbHorario);
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 131);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservar";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(13, 91);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(228, 20);
            this.dtpFecha.TabIndex = 7;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(83, 211);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 42);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "00.00";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(25, 323);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(228, 44);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(25, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(228, 44);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Invitado
            // 
            this.Invitado.HeaderText = "Invitado";
            this.Invitado.Name = "Invitado";
            this.Invitado.ReadOnly = true;
            // 
            // Menu
            // 
            this.Menu.HeaderText = "Menu";
            this.Menu.Name = "Menu";
            this.Menu.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // NuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevaReserva";
            this.Text = "Nueva reservación";
            this.Load += new System.EventHandler(this.NuevaReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarAsistentes;
        private System.Windows.Forms.DataGridView dgvAsistentes;
        private System.Windows.Forms.ComboBox cbSalon;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}