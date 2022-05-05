namespace EDnevnik
{
    partial class Login
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_dobrodoslica = new System.Windows.Forms.Label();
            this.btn_ulogujSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(28, 107);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(200, 35);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(91, 1560);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(135, 32);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Lozinka:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(235, 102);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(440, 38);
            this.txt_email.TabIndex = 10;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(235, 156);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(440, 38);
            this.txt_pass.TabIndex = 11;
            // 
            // lbl_dobrodoslica
            // 
            this.lbl_dobrodoslica.AutoSize = true;
            this.lbl_dobrodoslica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dobrodoslica.Location = new System.Drawing.Point(12, 24);
            this.lbl_dobrodoslica.Name = "lbl_dobrodoslica";
            this.lbl_dobrodoslica.Size = new System.Drawing.Size(701, 32);
            this.lbl_dobrodoslica.TabIndex = 12;
            this.lbl_dobrodoslica.Text = "Uneiste podatke ovde:";
            // 
            // btn_ulogujSe
            // 
            this.btn_ulogujSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ulogujSe.Location = new System.Drawing.Point(256, 225);
            this.btn_ulogujSe.Name = "btn_ulogujSe";
            this.btn_ulogujSe.Size = new System.Drawing.Size(219, 64);
            this.btn_ulogujSe.TabIndex = 22;
            this.btn_ulogujSe.Text = "Login";
            this.btn_ulogujSe.UseVisualStyleBackColor = true;
            this.btn_ulogujSe.Click += new System.EventHandler(this.btn_ulogujSe_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 327);
            this.Controls.Add(this.btn_ulogujSe);
            this.Controls.Add(this.lbl_dobrodoslica);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_email);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_dobrodoslica;
        private System.Windows.Forms.Button btn_ulogujSe;
    }
}