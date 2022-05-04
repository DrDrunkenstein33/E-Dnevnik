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
    public partial class Upisnica : Form
    {
        DataTable dt_upisnica;

        public Upisnica()
        {
            InitializeComponent();
        }

        private void cmb_godina_popuni()
        {
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Skolska_godina", veza);
            DataTable dt_godina = new DataTable();
            adapter.Fill(dt_godina);

            cmb_godina.DataSource = dt_godina;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = 5;
        }

        private void cmb_godina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_godina.IsHandleCreated && cmb_godina.Focused)
            {
                cmb_odeljenje_popuni();
                cmb_odeljenje.SelectedIndex = -1;                                
                while (grid_upisnica.Rows.Count > 0)
                {
                    grid_upisnica.Rows.Remove(grid_upisnica.Rows[0]);
                }
                txt_id.Text = "";
                cmb_ucenik.SelectedIndex = -1;
                cmb_ucenik.Enabled = false;
            }            
        }

        private void cmb_odeljenje_popuni()
        {
            string godina = cmb_godina.SelectedValue.ToString();
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, CAST(razred AS CHAR(1)) + '/' + CAST(indeks AS CHAR(1)) AS 'naziv' FROM Odeljenje WHERE godina_id = " + godina, veza);
            DataTable dt_odeljenje = new DataTable();
            adapter.Fill(dt_odeljenje);

            cmb_odeljenje.DataSource = dt_odeljenje;
            cmb_odeljenje.ValueMember = "id";
            cmb_odeljenje.DisplayMember = "naziv";            
        }

        private void cmb_odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_odeljenje.IsHandleCreated && cmb_odeljenje.Focused)
            {
                cmb_ucenik_popuni();
                cmb_ucenik.Enabled = true;
                grid_popuni();
            }
        }

        private void cmb_ucenik_popuni()
        {
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS 'naziv' FROM Osoba WHERE uloga = 'ucenik'", veza);
            DataTable dt_ucenik = new DataTable();
            adapter.Fill(dt_ucenik);

            cmb_ucenik.DataSource = dt_ucenik;
            cmb_ucenik.ValueMember = "id";
            cmb_ucenik.DisplayMember = "naziv";
        }

        private void grid_popuni()
        {
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Upisnica.id AS 'id', ime + ' ' + prezime AS 'naziv', osoba.id AS ucenik FROM Upisnica JOIN Osoba ON Osoba.id = Upisnica.osoba_id WHERE odeljenje_id = " + cmb_odeljenje.SelectedValue.ToString(), veza);
            dt_upisnica = new DataTable();
            adapter.Fill(dt_upisnica);            

            grid_upisnica.DataSource = dt_upisnica;
            grid_upisnica.AllowUserToAddRows = false;
            grid_upisnica.Columns["ucenik"].Visible = false;
        }

        private void Upisnica_Load(object sender, EventArgs e)
        {            
            cmb_godina_popuni();
            cmb_odeljenje_popuni();
            cmb_odeljenje.SelectedIndex = -1;
            cmb_ucenik.Enabled = false;
        }

        private void grid_upisnica_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grid_upisnica.Focused)
            {
                if (grid_upisnica.CurrentRow != null)
                {
                    int broj_sloga = grid_upisnica.CurrentRow.Index;
                    if (dt_upisnica.Rows.Count != 0 && broj_sloga >= 0)
                    {
                        cmb_ucenik.SelectedValue = grid_upisnica.Rows[broj_sloga].Cells["ucenik"].Value.ToString();
                        txt_id.Text = grid_upisnica.Rows[broj_sloga].Cells["id"].Value.ToString();
                    }
                }                
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("INSERT INTO upisnica (odeljenje_id, osoba_id) VALUES (' ");
            naredba.Append(cmb_odeljenje.SelectedValue.ToString() + "', '");
            naredba.Append(cmb_ucenik.SelectedValue.ToString() + "')");

            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                grid_popuni();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
                throw;
            }
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE upisnica SET ");
            naredba.Append("osoba_id = '" + cmb_ucenik.SelectedValue.ToString() + "' ");
            naredba.Append("WHERE id = " + txt_id.Text);

            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                grid_popuni();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
                throw;
            }
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM upisnica WHERE id = " + txt_id.Text;

            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                grid_popuni();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
                throw;
            }
        }
    }
}