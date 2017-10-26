namespace ElectionManager
{
    partial class InfoGeneral
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
            this.txtRut = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblHabil = new System.Windows.Forms.Label();
            this.btnEsVocal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese RUT:";
            // 
            // txtRut
            // 
            this.txtRut.AccessibleDescription = "";
            this.txtRut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRut.Location = new System.Drawing.Point(155, 10);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 1;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(262, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Local de votación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Habilitado para votar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mesa:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(130, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 9;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(130, 111);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(0, 13);
            this.lblDir.TabIndex = 10;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(130, 140);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(0, 13);
            this.lblLocal.TabIndex = 11;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(130, 167);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(0, 13);
            this.lblMesa.TabIndex = 12;
            // 
            // lblHabil
            // 
            this.lblHabil.AutoSize = true;
            this.lblHabil.Location = new System.Drawing.Point(130, 196);
            this.lblHabil.Name = "lblHabil";
            this.lblHabil.Size = new System.Drawing.Size(0, 13);
            this.lblHabil.TabIndex = 13;
            // 
            // btnEsVocal
            // 
            this.btnEsVocal.Location = new System.Drawing.Point(155, 37);
            this.btnEsVocal.Name = "btnEsVocal";
            this.btnEsVocal.Size = new System.Drawing.Size(123, 23);
            this.btnEsVocal.TabIndex = 14;
            this.btnEsVocal.Text = "Verificar si es vocal";
            this.btnEsVocal.UseVisualStyleBackColor = true;
            this.btnEsVocal.Visible = false;
            this.btnEsVocal.Click += new System.EventHandler(this.btnEsVocal_Click);
            // 
            // InfoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 226);
            this.Controls.Add(this.btnEsVocal);
            this.Controls.Add(this.lblHabil);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoGeneral";
            this.Text = "InfoGeneral";
            this.Load += new System.EventHandler(this.InfoGeneral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblHabil;
        private System.Windows.Forms.Button btnEsVocal;
    }
}