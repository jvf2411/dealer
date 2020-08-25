namespace dealer1.Formulario
{
    partial class clientereg
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.Apellidotxt = new System.Windows.Forms.TextBox();
            this.cedulatxt = new System.Windows.Forms.TextBox();
            this.correotxt = new System.Windows.Forms.TextBox();
            this.telefonotxt = new System.Windows.Forms.TextBox();
            this.dirrecciontxt = new System.Windows.Forms.TextBox();
            this.registrarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(5, 30);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(100, 20);
            this.nombretxt.TabIndex = 6;
            // 
            // Apellidotxt
            // 
            this.Apellidotxt.Location = new System.Drawing.Point(5, 81);
            this.Apellidotxt.Name = "Apellidotxt";
            this.Apellidotxt.Size = new System.Drawing.Size(100, 20);
            this.Apellidotxt.TabIndex = 7;
            // 
            // cedulatxt
            // 
            this.cedulatxt.Location = new System.Drawing.Point(5, 120);
            this.cedulatxt.Name = "cedulatxt";
            this.cedulatxt.Size = new System.Drawing.Size(100, 20);
            this.cedulatxt.TabIndex = 8;
            // 
            // correotxt
            // 
            this.correotxt.Location = new System.Drawing.Point(5, 163);
            this.correotxt.Name = "correotxt";
            this.correotxt.Size = new System.Drawing.Size(100, 20);
            this.correotxt.TabIndex = 9;
            // 
            // telefonotxt
            // 
            this.telefonotxt.Location = new System.Drawing.Point(5, 253);
            this.telefonotxt.Name = "telefonotxt";
            this.telefonotxt.Size = new System.Drawing.Size(100, 20);
            this.telefonotxt.TabIndex = 10;
            // 
            // dirrecciontxt
            // 
            this.dirrecciontxt.Location = new System.Drawing.Point(5, 202);
            this.dirrecciontxt.Name = "dirrecciontxt";
            this.dirrecciontxt.Size = new System.Drawing.Size(100, 20);
            this.dirrecciontxt.TabIndex = 11;
            // 
            // registrarbtn
            // 
            this.registrarbtn.Location = new System.Drawing.Point(321, 306);
            this.registrarbtn.Name = "registrarbtn";
            this.registrarbtn.Size = new System.Drawing.Size(75, 23);
            this.registrarbtn.TabIndex = 12;
            this.registrarbtn.Text = "Registrar";
            this.registrarbtn.UseVisualStyleBackColor = true;
            this.registrarbtn.Click += new System.EventHandler(this.registrarbtn_Click);
            // 
            // clientereg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrarbtn);
            this.Controls.Add(this.dirrecciontxt);
            this.Controls.Add(this.telefonotxt);
            this.Controls.Add(this.correotxt);
            this.Controls.Add(this.cedulatxt);
            this.Controls.Add(this.Apellidotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "clientereg";
            this.Text = "clientereg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox Apellidotxt;
        private System.Windows.Forms.TextBox cedulatxt;
        private System.Windows.Forms.TextBox correotxt;
        private System.Windows.Forms.TextBox telefonotxt;
        private System.Windows.Forms.TextBox dirrecciontxt;
        private System.Windows.Forms.Button registrarbtn;
    }
}