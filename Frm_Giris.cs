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
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=HARUN\\SQLEXPRESS;Initial Catalog=PersonelProje;Integrated Security=True;");
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_Kullanici.Text == "" || txt_Sifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Select * From Tbl_Admin where Kullanici_Adi=@p1 and Sifre=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_Kullanici.Text);
                    komut.Parameters.AddWithValue("@p2", txt_Sifre.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Frm_Personel frm = new Frm_Personel();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Program bir hata ile karşılaştı. Lütfen IT ekibine haber veriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
          
            
        }

    }
}
