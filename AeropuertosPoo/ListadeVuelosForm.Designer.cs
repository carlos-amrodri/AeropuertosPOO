namespace AeropuertosPoo
{
    partial class ListadeVuelosForm
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
            this.gridVuelos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVuelos
            // 
            this.gridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVuelos.Location = new System.Drawing.Point(114, 47);
            this.gridVuelos.Name = "gridVuelos";
            this.gridVuelos.Size = new System.Drawing.Size(611, 273);
            this.gridVuelos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vuelos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListadeVuelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridVuelos);
            this.Name = "ListadeVuelosForm";
            this.Text = "ListadeVuelosForm";
            this.Load += new System.EventHandler(this.ListadeVuelosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVuelos;
        private System.Windows.Forms.Label label1;
    }
}