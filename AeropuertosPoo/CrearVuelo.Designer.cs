namespace AeropuertosPoo
{
    partial class CrearVuelo
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
            this.cmboAerolinea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboAvion = new System.Windows.Forms.ComboBox();
            this.gridAviones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblturista = new System.Windows.Forms.Label();
            this.lblejecutivo = new System.Windows.Forms.Label();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Vuelo";
            // 
            // cmboAerolinea
            // 
            this.cmboAerolinea.FormattingEnabled = true;
            this.cmboAerolinea.Location = new System.Drawing.Point(18, 64);
            this.cmboAerolinea.Name = "cmboAerolinea";
            this.cmboAerolinea.Size = new System.Drawing.Size(121, 21);
            this.cmboAerolinea.TabIndex = 1;
            this.cmboAerolinea.SelectedIndexChanged += new System.EventHandler(this.cmboAerolinea_SelectedIndexChanged);
            this.cmboAerolinea.SelectionChangeCommitted += new System.EventHandler(this.cmboAerolinea_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compañia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aeronave";
            // 
            // comboAvion
            // 
            this.comboAvion.Enabled = false;
            this.comboAvion.FormattingEnabled = true;
            this.comboAvion.Location = new System.Drawing.Point(18, 151);
            this.comboAvion.Name = "comboAvion";
            this.comboAvion.Size = new System.Drawing.Size(121, 21);
            this.comboAvion.TabIndex = 4;
            this.comboAvion.SelectedIndexChanged += new System.EventHandler(this.comboAvion_SelectedIndexChanged);
            this.comboAvion.SelectionChangeCommitted += new System.EventHandler(this.comboAvion_SelectionChangeCommitted);
            // 
            // gridAviones
            // 
            this.gridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAviones.Location = new System.Drawing.Point(161, 64);
            this.gridAviones.Name = "gridAviones";
            this.gridAviones.Size = new System.Drawing.Size(374, 108);
            this.gridAviones.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capacidad";
            // 
            // lblturista
            // 
            this.lblturista.AutoSize = true;
            this.lblturista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblturista.Location = new System.Drawing.Point(20, 249);
            this.lblturista.Name = "lblturista";
            this.lblturista.Size = new System.Drawing.Size(39, 13);
            this.lblturista.TabIndex = 7;
            this.lblturista.Text = "Turista";
            // 
            // lblejecutivo
            // 
            this.lblejecutivo.AutoSize = true;
            this.lblejecutivo.Location = new System.Drawing.Point(23, 285);
            this.lblejecutivo.Name = "lblejecutivo";
            this.lblejecutivo.Size = new System.Drawing.Size(51, 13);
            this.lblejecutivo.TabIndex = 8;
            this.lblejecutivo.Text = "Ejecutivo";
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(199, 246);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(121, 21);
            this.comboDestino.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Destino";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de partida";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Crear Vuelo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrearVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.lblejecutivo);
            this.Controls.Add(this.lblturista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridAviones);
            this.Controls.Add(this.comboAvion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboAerolinea);
            this.Controls.Add(this.label1);
            this.Name = "CrearVuelo";
            this.Text = "CrearVuelo";
            this.Load += new System.EventHandler(this.CrearVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboAerolinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboAvion;
        private System.Windows.Forms.DataGridView gridAviones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblturista;
        private System.Windows.Forms.Label lblejecutivo;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}