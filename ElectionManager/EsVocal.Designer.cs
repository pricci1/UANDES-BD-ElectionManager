namespace ElectionManager
{
    partial class EsVocal
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
            this.dataGridViewElecciones = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una elección:";
            // 
            // dataGridViewElecciones
            // 
            this.dataGridViewElecciones.AllowUserToAddRows = false;
            this.dataGridViewElecciones.AllowUserToDeleteRows = false;
            this.dataGridViewElecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElecciones.Location = new System.Drawing.Point(16, 48);
            this.dataGridViewElecciones.Name = "dataGridViewElecciones";
            this.dataGridViewElecciones.ReadOnly = true;
            this.dataGridViewElecciones.Size = new System.Drawing.Size(248, 186);
            this.dataGridViewElecciones.TabIndex = 1;
            this.dataGridViewElecciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewElecciones_CellContentClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(189, 250);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // EsVocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 285);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dataGridViewElecciones);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EsVocal";
            this.Text = "Verificar si es local";
            this.Load += new System.EventHandler(this.EsVocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElecciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewElecciones;
        private System.Windows.Forms.Button btnConsultar;
    }
}