using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDnevnik
{
    public partial class Raspodela : Form
    {
        int broj_sloga = 0;
        DataTable raspodela;

        public Raspodela()
        {
            InitializeComponent();
        }

        private void Ucitaj_Podatke()
        {
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Raspodela", veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
        }

        private void Cmb_Ucitaj()
        {
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter;
            DataTable dt_nastavnik, dt_godina, dt_predmet, dt_odeljenje;

            adapter = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS 'naziv' FROM Osoba WHERE uloga = 'profesor'", veza);
            dt_nastavnik = new DataTable();
            adapter.Fill(dt_nastavnik);

            adapter = new SqlDataAdapter("SELECT * FROM Skolska_godina", veza);
            dt_godina = new DataTable();
            adapter.Fill(dt_godina);

            adapter = new SqlDataAdapter("SELECT id, naziv FROM Predmet", veza);
            dt_predmet = new DataTable();
            adapter.Fill(dt_predmet);

            adapter = new SqlDataAdapter("SELECT id, CAST(razred AS CHAR(1)) + '/' + CAST(indeks AS CHAR(1)) AS 'naziv' FROM Odeljenje", veza);
            dt_odeljenje = new DataTable();
            adapter.Fill(dt_odeljenje);

            cmb_nastavnik.DataSource = dt_nastavnik;
            cmb_nastavnik.ValueMember = "id";
            cmb_nastavnik.DisplayMember = "naziv";
            

            cmb_godina.DataSource = dt_godina;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            

            cmb_predmet.DataSource = dt_predmet;
            cmb_predmet.ValueMember = "id";
            cmb_predmet.DisplayMember = "naziv";
            

            cmb_odeljenje.DataSource = dt_odeljenje;
            cmb_odeljenje.ValueMember = "id";
            cmb_odeljenje.DisplayMember = "naziv";

            if (raspodela.Rows.Count != 0)
            {
                txt_id.Text = raspodela.Rows[broj_sloga]["id"].ToString();
                cmb_nastavnik.SelectedValue = raspodela.Rows[broj_sloga]["nastavnik_id"];
                cmb_godina.SelectedValue = raspodela.Rows[broj_sloga]["godina_id"];
                cmb_predmet.SelectedValue = raspodela.Rows[broj_sloga]["predmet_id"];
                cmb_odeljenje.SelectedValue = raspodela.Rows[broj_sloga]["odeljenje_id"];
                
                txt_pozicija.Text = (broj_sloga + 1) + "/" + raspodela.Rows.Count;

                btn_izmeni.Enabled = true;
                btn_obrisi.Enabled = true;
                if (broj_sloga == 0)
                {
                    btn_prvi.Enabled = false;
                    btn_prethodni.Enabled = false;
                }
                else
                {
                    btn_prvi.Enabled = true;
                    btn_prethodni.Enabled = true;
                }

                if (broj_sloga == raspodela.Rows.Count - 1)
                {
                    btn_poslednji.Enabled = false;
                    btn_sledeci.Enabled = false;
                }
                else
                {
                    btn_poslednji.Enabled = true;
                    btn_sledeci.Enabled = true;
                }
            }
            else
            {                
                txt_id.Text = "";
                cmb_nastavnik.SelectedValue = -1;
                cmb_godina.SelectedValue = -1;
                cmb_predmet.SelectedValue = -1;
                cmb_odeljenje.SelectedValue = -1;
                txt_pozicija.Text = "0";

                btn_prvi.Enabled = false;
                btn_prethodni.Enabled = false;
                btn_poslednji.Enabled = false;
                btn_sledeci.Enabled = false;
                btn_izmeni.Enabled = false;
                btn_obrisi.Enabled = false;
            }            
        }

        private void Raspodela_Load(object sender, EventArgs e)
        {
            Ucitaj_Podatke();
            Cmb_Ucitaj();
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Ucitaj_Podatke();
            Cmb_Ucitaj();
        }

        private void btn_prvi_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Cmb_Ucitaj();
        }

        private void btn_poslednji_Click(object sender, EventArgs e)
        {
            broj_sloga = raspodela.Rows.Count - 1;
            Cmb_Ucitaj();
        }

        private void btn_prethodni_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Cmb_Ucitaj();
        }

        private void btn_sledeci_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Cmb_Ucitaj();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            /*INSERT INTO Raspodela(nastavnik_id, godina_id, predmet_id, odeljenje_id)
            VALUES(7, 2, 2, 1)*/
            StringBuilder naredba = new StringBuilder("INSERT INTO Raspodela(nastavnik_id, godina_id, predmet_id, odeljenje_id) VALUES (");
            naredba.Append(cmb_nastavnik.SelectedValue + ", ");
            naredba.Append(cmb_godina.SelectedValue + ", ");
            naredba.Append(cmb_predmet.SelectedValue + ", ");
            naredba.Append(cmb_odeljenje.SelectedValue + ")");            
            //MessageBox.Show(naredba.ToString());
            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            Ucitaj_Podatke();
            broj_sloga = raspodela.Rows.Count - 1;
            Cmb_Ucitaj();
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            /*UPDATE Raspodela SET nastavnik_id = 1, godina_id = 2,
            predmet_id = 3, odeljenje_id = 4 WHERE id = 3*/
            StringBuilder naredba = new StringBuilder("UPDATE Raspodela SET ");
            naredba.Append("nastavnik_id = " + cmb_nastavnik.SelectedValue + ", ");
            naredba.Append("godina_id = " + cmb_godina.SelectedValue + ", ");
            naredba.Append("predmet_id = " + cmb_predmet.SelectedValue + ", ");
            naredba.Append("odeljenje_id = " + cmb_odeljenje.SelectedValue + " ");            
            naredba.Append("WHERE id = " + txt_id.Text);
            //MessageBox.Show(naredba.ToString());
            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            Ucitaj_Podatke();
            Cmb_Ucitaj();
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM Raspodela WHERE id = " + txt_id.Text;
            //MessageBox.Show(naredba.ToString());
            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            Boolean brisano = false;
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            if (brisano)
            {
                Ucitaj_Podatke();
                if (broj_sloga > 0) broj_sloga--;

                Cmb_Ucitaj();
            }
        }
    }
}