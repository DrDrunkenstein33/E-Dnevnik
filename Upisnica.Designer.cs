namespace EDnevnik
{
    partial class Upisnica
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_godina = new System.Windows.Forms.Label();
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.lbl_odeljenje = new System.Windows.Forms.Label();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.lbl_ucenik = new System.Windows.Forms.Label();
            this.cmb_ucenik = new System.Windows.Forms.ComboBox();
            this.grid_upisnica = new System.Windows.Forms.DataGridView();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_upisnica)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(34, 61);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(109, 38);
            this.txt_id.TabIndex = 11;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(68, 25);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(42, 32);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "ID";
            // 
            // lbl_godina
            // 
            this.lbl_godina.AutoSize = true;
            this.lbl_godina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_godina.Location = new System.Drawing.Point(171, 25);
            this.lbl_godina.Name = "lbl_godina";
            this.lbl_godina.Size = new System.Drawing.Size(227, 32);
            this.lbl_godina.TabIndex = 13;
            this.lbl_godina.Text = "Skolska godina";
            // 
            // cmb_godina
            // 
            this.cmb_godina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(177, 60);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(221, 39);
            this.cmb_godina.TabIndex = 12;
            this.cmb_godina.SelectedValueChanged += new System.EventHandler(this.cmb_godina_SelectedValueChanged);
            // 
            // lbl_odeljenje
            // 
            this.lbl_odeljenje.AutoSize = true;
            this.lbl_odeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_odeljenje.Location = new System.Drawing.Point(432, 25);
            this.lbl_odeljenje.Name = "lbl_odeljenje";
            this.lbl_odeljenje.Size = new System.Drawing.Size(148, 32);
            this.lbl_odeljenje.TabIndex = 15;
            this.lbl_odeljenje.Text = "Odeljenje";
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(438, 61);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(142, 39);
            this.cmb_odeljenje.TabIndex = 14;
            this.cmb_odeljenje.SelectedValueChanged += new System.EventHandler(this.cmb_odeljenje_SelectedValueChanged);
            // 
            // lbl_ucenik
            // 
            this.lbl_ucenik.AutoSize = true;
            this.lbl_ucenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ucenik.Location = new System.Drawing.Point(738, 25);
            this.lbl_ucenik.Name = "lbl_ucenik";
            this.lbl_ucenik.Size = new System.Drawing.Size(110, 32);
            this.lbl_ucenik.TabIndex = 17;
            this.lbl_ucenik.Text = "Ucenik";
            // 
            // cmb_ucenik
            // 
            this.cmb_ucenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ucenik.FormattingEnabled = true;
            this.cmb_ucenik.Location = new System.Drawing.Point(613, 60);
            this.cmb_ucenik.Name = "cmb_ucenik";
            this.cmb_ucenik.Size = new System.Drawing.Size(362, 39);
            this.cmb_ucenik.TabIndex = 16;
            // 
            // grid_upisnica
            // 
            this.grid_upisnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_upisnica.Location = new System.Drawing.Point(12, 288);
            this.grid_upisnica.Name = "grid_upisnica";
            this.grid_upisnica.RowHeadersWidth = 51;
            this.grid_upisnica.RowTemplate.Height = 24;
            this.grid_upisnica.Size = new System.Drawing.Size(982, 411);
            this.grid_upisnica.TabIndex = 18;
            this.grid_upisnica.CurrentCellChanged += new System.EventHandler(this.grid_upisnica_CurrentCellChanged);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi.Location = new System.Drawing.Point(565, 158);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(109, 64);
            this.btn_obrisi.TabIndex = 33;
            this.btn_obrisi.Text = "Brisi";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(435, 158);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(109, 64);
            this.btn_izmeni.TabIndex = 32;
            this.btn_izmeni.Text = "Izmeni";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(311, 158);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(109, 64);
            this.btn_dodaj.TabIndex = 31;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // Upisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 711);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.grid_upisnica);
            this.Controls.Add(this.lbl_ucenik);
            this.Controls.Add(this.cmb_ucenik);
            this.Controls.Add(this.lbl_odeljenje);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.lbl_godina);
            this.Controls.Add(this.cmb_godina);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "Upisnica";
            this.Text = "Upisnica";
            this.Load += new System.EventHandler(this.Upisnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_upisnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_godina;
        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.Label lbl_odeljenje;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.Label lbl_ucenik;
        private System.Windows.Forms.ComboBox cmb_ucenik;
        private System.Windows.Forms.DataGridView grid_upisnica;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Button btn_dodaj;
    }
}