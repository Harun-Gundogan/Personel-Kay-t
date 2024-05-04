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
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace Personel_Kayıt
{
    public partial class Frm_Grafik : Form
    {
        public Frm_Grafik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=HARUN\\SQLEXPRESS;Initial Catalog=PersonelProje;Integrated Security=True;");
       
        private void Frm_Grafik_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("Select Per_Sehir, Count(*) from Tbl_Personel Group By Per_Sehir", baglanti);
                SqlDataReader dr1 = komut1.ExecuteReader();
                while (dr1.Read())
                {
                    chart1.Series["Şehirler"].Points.AddXY(dr1[0], dr1[1]);
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Select Per_Meslek, Avg(Per_Maas) From Tbl_Personel Group By Per_Meslek", baglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    chart2.Series["Meslek Maaş"].Points.AddXY(dr2[0], dr2[1]);
                }
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir sorun oluştu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

                    
        }

    }
}
