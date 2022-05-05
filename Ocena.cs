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
    public partial class Ocena : Form
    {
        DataTable dt_ocena;        

        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            cmb_godina_popuni();

            cmb_predmet.Enabled = false;
            cmb_odeljenje.Enabled = false;
            cmb_ucenik.Enabled = false;
            cmb_ocena.Items.Add(1);
            cmb_ocena.Items.Add(2);
            cmb_ocena.Items.Add(3);
            cmb_ocena.Items.Add(4);
            cmb_ocena.Items.Add(5);
            cmb_ocena.Enabled = false;

            cmb_profesor_popuni();
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
                cmb_profesor_popuni();
            }
        }

        private void cmb_profesor_popuni()
        {            
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT Osoba.id AS id, ime + ' ' + prezime AS naziv FROM Osoba");
            naredba.Append(" JOIN Raspodela ON Osoba.id = nastavnik_id ");
            naredba.Append("WHERE godina_id = " + cmb_godina.SelectedValue.ToString());
            //textBox1.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_profesor = new DataTable();
            adapter.Fill(dt_profesor);
            cmb_profesor.DataSource = dt_profesor;
            cmb_profesor.ValueMember = "id";
            cmb_profesor.DisplayMember = "naziv";
            cmb_profesor.SelectedIndex = -1;
        }

        private void cmb_profesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_profesor.IsHandleCreated && cmb_profesor.Focused)
            {
                cmb_predmet_popuni();
                cmb_predmet.Enabled = true;

                cmb_odeljenje.SelectedValue = -1;
                cmb_odeljenje.Enabled = false;

                cmb_ucenik.SelectedIndex = -1;
                cmb_ucenik.Enabled = false;

                cmb_ocena.SelectedIndex = -1;
                cmb_ocena.Enabled = false;

                dt_ocena = new DataTable();
                grid_ocene.DataSource = dt_ocena;
            }
        }

        private void cmb_predmet_popuni()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT Predmet.id AS id, naziv FROM Predmet");
            naredba.Append(" JOIN Raspodela ON Predmet.id = predmet_id");
            naredba.Append(" WHERE godina_id = " + cmb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_profesor.SelectedValue.ToString());
            //textBox1.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_predmet = new DataTable();
            adapter.Fill(dt_predmet);
            cmb_predmet.DataSource = dt_predmet;
            cmb_predmet.ValueMember = "id";
            cmb_predmet.DisplayMember = "naziv";
            cmb_predmet.SelectedIndex = -1;
        }

        private void cmb_predmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_predmet.IsHandleCreated && cmb_predmet.Focused)
            {
                cmb_odeljenje_popuni();
                cmb_odeljenje.Enabled = true;

                cmb_ucenik.SelectedIndex = -1;
                cmb_ucenik.Enabled = false;

                cmb_ocena.SelectedIndex = -1;
                cmb_ocena.Enabled = false;

                dt_ocena = new DataTable();
                grid_ocene.DataSource = dt_ocena;
            }
        }

        private void cmb_odeljenje_popuni()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT Odeljenje.id AS id, CAST(razred AS CHAR(1)) + '/' + CAST(indeks AS CHAR(1)) naziv FROM Odeljenje");
            naredba.Append(" JOIN Raspodela ON Odeljenje.id = odeljenje_id");
            naredba.Append(" WHERE Raspodela.godina_id = " + cmb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmb_predmet.SelectedValue.ToString());
            //textBox1.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_odeljenje = new DataTable();
            adapter.Fill(dt_odeljenje);
            cmb_odeljenje.DataSource = dt_odeljenje;
            cmb_odeljenje.ValueMember = "id";
            cmb_odeljenje.DisplayMember = "naziv";
            cmb_odeljenje.SelectedIndex = -1;
        }

        private void cmb_odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_odeljenje.IsHandleCreated && cmb_odeljenje.Focused)
            {
                cmb_ucenik_popuni();
                cmb_ucenik.Enabled = true;
                cmb_ocena.Enabled = true;
                grid_popuni();
                Ucenik_Ocena_Id_Postavi(0);
            }
        }

        private void cmb_ucenik_popuni()
        {
            StringBuilder naredba = new StringBuilder("SELECT Osoba.id AS id, ime + ' ' + prezime AS naziv FROM Osoba");
            naredba.Append(" JOIN Upisnica ON Osoba.id = osoba_id");
            naredba.Append(" WHERE Upisnica.odeljenje_id = " + cmb_odeljenje.SelectedValue.ToString());
            //textBox1.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_ucenik = new DataTable();
            adapter.Fill(dt_ucenik);
            cmb_ucenik.DataSource = dt_ucenik;
            cmb_ucenik.ValueMember = "id";
            cmb_ucenik.DisplayMember = "naziv";
            cmb_ucenik.SelectedIndex = -1;
        }

        private void grid_popuni()
        {
            StringBuilder naredba = new StringBuilder("SELECT Ocena.id AS id, ime + ' ' + prezime AS naziv, ocena, ucenik_id, datum FROM Osoba");
            naredba.Append(" JOIN Ocena ON Osoba.id = ucenik_id");
            naredba.Append(" JOIN Raspodela ON raspodela_id = Raspodela.id");
            naredba.Append(" WHERE raspodela_id = ");
            naredba.Append(" (SELECT id FROM raspodela");
            naredba.Append(" WHERE godina_id = " + cmb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmb_predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id = " + cmb_odeljenje.SelectedValue.ToString() + ")");
            //textBox1.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            dt_ocena = new DataTable();
            adapter.Fill(dt_ocena);
            grid_ocene.DataSource = dt_ocena;
            grid_ocene.AllowUserToAddRows = false;
            grid_ocene.Columns["ucenik_id"].Visible = false;
        }

        private void grid_ocene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Ucenik_Ocena_Id_Postavi(e.RowIndex);
            }
        }

        private void Ucenik_Ocena_Id_Postavi(int broj_sloga)
        {
            cmb_ucenik.SelectedValue = dt_ocena.Rows[broj_sloga]["ucenik_id"];
            cmb_ocena.SelectedItem = dt_ocena.Rows[broj_sloga]["ocena"];
            txt_id.Text = dt_ocena.Rows[broj_sloga]["id"].ToString();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("SELECT id FROM Raspodela");
            naredba.Append(" WHERE godina_id = " + cmb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmb_predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id = " + cmb_odeljenje.SelectedValue.ToString());

            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            int id_raspodele = 0;

            try
            {
                veza.Open();
                id_raspodele = (int) komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            if (id_raspodele > 0)
            {
                naredba = new StringBuilder("INSERT INTO Ocena (datum, raspodela_id, ucenik_id, ocena) VALUES ('");
                DateTime datum = cmb_datum.Value;
                naredba.Append(datum.ToString("yyyy-MM-dd") + "', '");
                naredba.Append(id_raspodele.ToString() + "', '");
                naredba.Append(cmb_ucenik.SelectedValue.ToString() + "', '");
                naredba.Append(cmb_ocena.SelectedItem.ToString() + "')");
                komanda = new SqlCommand(naredba.ToString(), veza);

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
            }

            grid_popuni();
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) > 0)
            {
                DateTime datum = cmb_datum.Value;
                StringBuilder naredba = new StringBuilder("UPDATE Ocena SET");
                naredba.Append(" ucenik_id = " + cmb_ucenik.SelectedValue.ToString() + ", ");
                naredba.Append(" ocena = " + cmb_ocena.SelectedItem.ToString() + ", ");
                naredba.Append(" datum = '" + datum.ToString("yyyy-MM-dd") + "' ");
                naredba.Append(" WHERE id = " + txt_id.Text);

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

                grid_popuni();
            }
        }

        private void btn_brisi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) > 0)
            {
                string naredba = "DELETE FROM Ocena WHERE id = " + txt_id.Text;
                SqlConnection veza = Konekcija.Povezi();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                    grid_popuni();
                    Ucenik_Ocena_Id_Postavi(0);
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }                
            }
        }
    }
}