namespace ElectionManager
{
    partial class Inicio
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnInfoGeneral = new System.Windows.Forms.Button();
            this.btnElecciones = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(101, 202);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnInfoGeneral
            // 
            this.btnInfoGeneral.Location = new System.Drawing.Point(12, 12);
            this.btnInfoGeneral.Name = "btnInfoGeneral";
            this.btnInfoGeneral.Size = new System.Drawing.Size(109, 23);
            this.btnInfoGeneral.TabIndex = 1;
            this.btnInfoGeneral.Text = "Consultar por RUT";
            this.btnInfoGeneral.UseVisualStyleBackColor = true;
            this.btnInfoGeneral.Click += new System.EventHandler(this.btnInfoGeneral_Click);
            // 
            // btnElecciones
            // 
            this.btnElecciones.Location = new System.Drawing.Point(12, 62);
            this.btnElecciones.Name = "btnElecciones";
            this.btnElecciones.Size = new System.Drawing.Size(75, 23);
            this.btnElecciones.TabIndex = 2;
            this.btnElecciones.Text = "Elecciónes";
            this.btnElecciones.UseVisualStyleBackColor = true;
            this.btnElecciones.Click += new System.EventHandler(this.btnElecciones_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.Location = new System.Drawing.Point(13, 110);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(75, 23);
            this.btnPersonas.TabIndex = 3;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPersonas);
            this.Controls.Add(this.btnElecciones);
            this.Controls.Add(this.btnInfoGeneral);
            this.Controls.Add(this.btnTest);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnInfoGeneral;
        private System.Windows.Forms.Button btnElecciones;
        private System.Windows.Forms.Button btnPersonas;
    }
}