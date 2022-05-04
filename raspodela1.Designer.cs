namespace EDnevnik
{
    partial class Raspodela
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
            this.cmb_nastavnik = new System.Windows.Forms.ComboBox();
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.lbl_nastavnik = new System.Windows.Forms.Label();
            this.lbl_godina = new System.Windows.Forms.Label();
            this.lbl_predmet = new System.Windows.Forms.Label();
            this.lbl_odeljenje = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_osvezi = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_poslednji = new System.Windows.Forms.Button();
            this.btn_sledeci = new System.Windows.Forms.Button();
            this.btn_prethodni = new System.Windows.Forms.Button();
            this.btn_prvi = new System.Windows.Forms.Button();
            this.txt_pozicija = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_nastavnik
            // 
            this.cmb_nastavnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nastavnik.FormattingEnabled = true;
            this.cmb_nastavnik.Location = new System.Drawing.Point(261, 98);
            this.cmb_nastavnik.Name = "cmb_nastavnik";
            this.cmb_nastavnik.Size = new System.Drawing.Size(473, 39);
            this.cmb_nastavnik.TabIndex = 0;
            // 
            // cmb_godina
            // 
            this.cmb_godina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(261, 157);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(473, 39);
            this.cmb_godina.TabIndex = 1;
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(261, 218);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(473, 39);
            this.cmb_predmet.TabIndex = 2;
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(261, 277);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(473, 39);
            this.cmb_odeljenje.TabIndex = 3;
            // 
            // lbl_nastavnik
            // 
            this.lbl_nastavnik.AutoSize = true;
            this.lbl_nastavnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nastavnik.Location = new System.Drawing.Point(84, 101);
            this.lbl_nastavnik.Name = "lbl_nastavnik";
            this.lbl_nastavnik.Size = new System.Drawing.Size(163, 32);
            this.lbl_nastavnik.TabIndex = 4;
            this.lbl_nastavnik.Text = "Nastavnik:";
            // 
            // lbl_godina
            // 
            this.lbl_godina.AutoSize = true;
            this.lbl_godina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_godina.Location = new System.Drawing.Point(12, 160);
            this.lbl_godina.Name = "lbl_godina";
            this.lbl_godina.Size = new System.Drawing.Size(235, 32);
            this.lbl_godina.TabIndex = 5;
            this.lbl_godina.Text = "Skolska godina:";
            // 
            // lbl_predmet
            // 
            this.lbl_predmet.AutoSize = true;
            this.lbl_predmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_predmet.Location = new System.Drawing.Point(107, 221);
            this.lbl_predmet.Name = "lbl_predmet";
            this.lbl_predmet.Size = new System.Drawing.Size(140, 32);
            this.lbl_predmet.TabIndex = 6;
            this.lbl_predmet.Text = "Predmet:";
            // 
            // lbl_odeljenje
            // 
            this.lbl_odeljenje.AutoSize = true;
            this.lbl_odeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_odeljenje.Location = new System.Drawing.Point(99, 280);
            this.lbl_odeljenje.Name = "lbl_odeljenje";
            this.lbl_odeljenje.Size = new System.Drawing.Size(156, 32);
            this.lbl_odeljenje.TabIndex = 7;
            this.lbl_odeljenje.Text = "Odeljenje:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(205, 22);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(50, 32);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(261, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(109, 38);
            this.txt_id.TabIndex = 9;
            // 
            // btn_osvezi
            // 
            this.btn_osvezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_osvezi.Location = new System.Drawing.Point(637, 422);
            this.btn_osvezi.Name = "btn_osvezi";
            this.btn_osvezi.Size = new System.Drawing.Size(109, 64);
            this.btn_osvezi.TabIndex = 31;
            this.btn_osvezi.Text = "Osvezi";
            this.btn_osvezi.UseVisualStyleBackColor = true;
            this.btn_osvezi.Click += new System.EventHandler(this.btn_osvezi_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi.Location = new System.Drawing.Point(448, 422);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(109, 64);
            this.btn_obrisi.TabIndex = 30;
            this.btn_obrisi.Text = "Brisi";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(321, 422);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(109, 64);
            this.btn_izmeni.TabIndex = 29;
            this.btn_izmeni.Text = "Izmeni";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(194, 422);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(109, 64);
            this.btn_dodaj.TabIndex = 28;
            this.btn_dodaj.Text = "Add";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_poslednji
            // 
            this.btn_poslednji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_poslednji.Location = new System.Drawing.Point(637, 341);
            this.btn_poslednji.Name = "btn_poslednji";
            this.btn_poslednji.Size = new System.Drawing.Size(109, 64);
            this.btn_poslednji.TabIndex = 27;
            this.btn_poslednji.Text = ">>";
            this.btn_poslednji.UseVisualStyleBackColor = true;
            this.btn_poslednji.Click += new System.EventHandler(this.btn_poslednji_Click);
            // 
            // btn_sledeci
            // 
            this.btn_sledeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sledeci.Location = new System.Drawing.Point(437, 341);
            this.btn_sledeci.Name = "btn_sledeci";
            this.btn_sledeci.Size = new System.Drawing.Size(109, 64);
            this.btn_sledeci.TabIndex = 26;
            this.btn_sledeci.Text = ">";
            this.btn_sledeci.UseVisualStyleBackColor = true;
            this.btn_sledeci.Click += new System.EventHandler(this.btn_sledeci_Click);
            // 
            // btn_prethodni
            // 
            this.btn_prethodni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prethodni.Location = new System.Drawing.Point(204, 341);
            this.btn_prethodni.Name = "btn_prethodni";
            this.btn_prethodni.Size = new System.Drawing.Size(109, 64);
            this.btn_prethodni.TabIndex = 25;
            this.btn_prethodni.Text = "<";
            this.btn_prethodni.UseVisualStyleBackColor = true;
            this.btn_prethodni.Click += new System.EventHandler(this.btn_prethodni_Click);
            // 
            // btn_prvi
            // 
            this.btn_prvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prvi.Location = new System.Drawing.Point(11, 341);
            this.btn_prvi.Name = "btn_prvi";
            this.btn_prvi.Size = new System.Drawing.Size(109, 64);
            this.btn_prvi.TabIndex = 24;
            this.btn_prvi.Text = "<<";
            this.btn_prvi.UseVisualStyleBackColor = true;
            this.btn_prvi.Click += new System.EventHandler(this.btn_prvi_Click);
            // 
            // txt_pozicija
            // 
            this.txt_pozicija.Enabled = false;
            this.txt_pozicija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pozicija.Location = new System.Drawing.Point(677, 16);
            this.txt_pozicija.Name = "txt_pozicija";
            this.txt_pozicija.Size = new System.Drawing.Size(85, 38);
            this.txt_pozicija.TabIndex = 32;
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 511);
            this.Controls.Add(this.txt_pozicija);
            this.Controls.Add(this.btn_osvezi);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_poslednji);
            this.Controls.Add(this.btn_sledeci);
            this.Controls.Add(this.btn_prethodni);
            this.Controls.Add(this.btn_prvi);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_odeljenje);
            this.Controls.Add(this.lbl_predmet);
            this.Controls.Add(this.lbl_godina);
            this.Controls.Add(this.lbl_nastavnik);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.cmb_godina);
            this.Controls.Add(this.cmb_nastavnik);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_nastavnik;
        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.Label lbl_nastavnik;
        private System.Windows.Forms.Label lbl_godina;
        private System.Windows.Forms.Label lbl_predmet;
        private System.Windows.Forms.Label lbl_odeljenje;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_osvezi;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_poslednji;
        private System.Windows.Forms.Button btn_sledeci;
        private System.Windows.Forms.Button btn_prethodni;
        private System.Windows.Forms.Button btn_prvi;
        private System.Windows.Forms.TextBox txt_pozicija;
    }
}