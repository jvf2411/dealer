namespace dealer1.Formulario
{
    partial class ventareg
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
            this.Precio = new System.Windows.Forms.Label();
            this.clientetxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.pagotxt = new System.Windows.Forms.TextBox();
            this.vehiculotxt = new System.Windows.Forms.TextBox();
            this.registrarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metodo de pago";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(13, 148);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 3;
            this.Precio.Text = "Precio";
            // 
            // clientetxt
            // 
            this.clientetxt.Location = new System.Drawing.Point(16, 30);
            this.clientetxt.Name = "clientetxt";
            this.clientetxt.Size = new System.Drawing.Size(100, 20);
            this.clientetxt.TabIndex = 4;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(12, 164);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(100, 20);
            this.preciotxt.TabIndex = 5;
            // 
            // pagotxt
            // 
            this.pagotxt.Location = new System.Drawing.Point(16, 119);
            this.pagotxt.Name = "pagotxt";
            this.pagotxt.Size = new System.Drawing.Size(100, 20);
            this.pagotxt.TabIndex = 6;
            // 
            // vehiculotxt
            // 
            this.vehiculotxt.Location = new System.Drawing.Point(16, 69);
            this.vehiculotxt.Name = "vehiculotxt";
            this.vehiculotxt.Size = new System.Drawing.Size(100, 20);
            this.vehiculotxt.TabIndex = 7;
            // 
            // registrarbtn
            // 
            this.registrarbtn.Location = new System.Drawing.Point(12, 210);
            this.registrarbtn.Name = "registrarbtn";
            this.registrarbtn.Size = new System.Drawing.Size(75, 23);
            this.registrarbtn.TabIndex = 8;
            this.registrarbtn.Text = "Registrar";
            this.registrarbtn.UseVisualStyleBackColor = true;
            this.registrarbtn.Click += new System.EventHandler(this.registrarbtn_Click);
            // 
            // ventareg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrarbtn);
            this.Controls.Add(this.vehiculotxt);
            this.Controls.Add(this.pagotxt);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.clientetxt);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ventareg";
            this.Text = "ventareg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox clientetxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.TextBox pagotxt;
        private System.Windows.Forms.TextBox vehiculotxt;
        private System.Windows.Forms.Button registrarbtn;
    }
}