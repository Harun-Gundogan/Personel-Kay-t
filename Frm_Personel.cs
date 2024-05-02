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

namespace Personel_Kayıt
{
    public partial class Frm_Personel : Form
    {
        public Frm_Personel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=HARUN\\SQLEXPRESS;Initial Catalog=PersonelProje;Integrated Security=True;");
        
        void temizle()
        {
            txt_Id.Text = "";
            txt_Ad.Text = "";
            txt_Soyad.Text = "";
            txt_Meslek.Text = "";
            cmb_Sehir.Text = "";
            rd_Erkek.Checked = false;
            rd_Kadin.Checked = false;
            mtxt_Maas.Text = "";
            txt_Ad.Focus();

        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Tbl_Personel where Per_Id=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",txt_Id.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            temizle();
            this.tbl_PersonelTableAdapter.Fill(this.personelProjeDataSet1.Tbl_Personel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.tbl_PersonelTableAdapter.Fill(this.personelProjeDataSet1.Tbl_Personel);
            

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelProjeDataSet1.Tbl_Personel);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_Ad.Text == "" || txt_Soyad.Text == "" || cmb_Sehir.Text == "" || mtxt_Maas.Text == "" || txt_Meslek.Text =="")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into Tbl_Personel (Per_Ad, Per_Soyad, Per_Sehir, Per_Maas, Per_Cinsiyet, Per_Meslek) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
                    komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
                    komut.Parameters.AddWithValue("@p3", cmb_Sehir.Text);
                    komut.Parameters.AddWithValue("@p4", mtxt_Maas.Text);
                    komut.Parameters.AddWithValue("@p5", lbl_Rd.Text);
                    komut.Parameters.AddWithValue("@p6", txt_Meslek.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Personel Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    temizle();
                    this.tbl_PersonelTableAdapter.Fill(this.personelProjeDataSet1.Tbl_Personel);
                }
                catch (Exception)
                {

                    MessageBox.Show("Program bir hata ile karşılaştı. Lütfen IT ekibine haber veriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
           
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txt_Id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_Sehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtxt_Maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lbl_Rd.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txt_Meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void lbl_Rd_TextChanged(object sender, EventArgs e)
        {
            if (lbl_Rd.Text == "True")
            {
                rd_Kadin.Checked = true;
            }
            if(lbl_Rd.Text == "False")
            {
                rd_Erkek.Checked = true;
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Tbl_Personel set Per_Ad=@p1, Per_Soyad=@p2, Per_Sehir=@p3, Per_Maas=@p4, Per_Cinsiyet=@p5, Per_Meslek=@p6 where Per_Id=@p7", baglanti);
                komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
                komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
                komut.Parameters.AddWithValue("@p3", cmb_Sehir.Text);
                komut.Parameters.AddWithValue("@p4", mtxt_Maas.Text);
                komut.Parameters.AddWithValue("@p5", lbl_Rd.Text);
                komut.Parameters.AddWithValue("@p6", txt_Meslek.Text);
                komut.Parameters.AddWithValue("@p7", txt_Id.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel Kayıdı Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                temizle();
                this.tbl_PersonelTableAdapter.Fill(this.personelProjeDataSet1.Tbl_Personel);
            }
            catch (Exception)
            {

                MessageBox.Show("Program bir hata ile karşılaştı. Lütfen IT ekibine haber veriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_Istatislik_Click(object sender, EventArgs e)
        {
            Frm_Istatislik fr = new Frm_Istatislik();
            fr.Show();
        }

        private void btn_Grafik_Click(object sender, EventArgs e)
        {
            Frm_Grafik fr = new Frm_Grafik();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Raporlar fr = new Frm_Raporlar();
            fr.Show();
        }

        private void rd_Evli_CheckedChanged(object sender, EventArgs e)
        {
           
            lbl_Rd.TextChanged -= lbl_Rd_TextChanged;
            lbl_Rd.Text = "True";
            lbl_Rd.TextChanged += lbl_Rd_TextChanged;
        }

        private void rd_Bekar_CheckedChanged(object sender, EventArgs e)
        {
           
            lbl_Rd.TextChanged -= lbl_Rd_TextChanged;
            lbl_Rd.Text = "False";
            lbl_Rd.TextChanged += lbl_Rd_TextChanged;
        }
                
    }
}
