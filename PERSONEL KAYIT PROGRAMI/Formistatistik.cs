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
namespace PERSONEL_KAYIT_PROGRAMI
{
    public partial class Formistatistik : Form
    {
        public Formistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-H333VG89;Initial Catalog=personel;Integrated Security=True");
        private void Formistatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from tbl_personel", baglanti);
            
            SqlDataReader dr = komut1.ExecuteReader();
            
            
            while (dr.Read()) 
            {
                lbltoplam.Text = dr[0].ToString();
                               
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select count(*) from tbl_personel where per_medeni_d = 0", baglanti);
            SqlDataReader dr1 = komut2.ExecuteReader();

            while (dr1.Read())
            {
                lblbekar.Text = dr1[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from tbl_personel where per_medeni_d = 1", baglanti);
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                lblevli.Text = dr2[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(per_Sehir)) from tbl_personel", baglanti);
            SqlDataReader dr3 = komut4.ExecuteReader();
            while (dr3.Read())
            {
                lblsehir.Text = dr3[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(per_maas) from tbl_personel", baglanti);
            SqlDataReader dr4 = komut5.ExecuteReader();
            while(dr4.Read())
            {
                lbltplmaas.Text = dr4[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(per_maas) from tbl_personel", baglanti);
            SqlDataReader dr5 = komut6.ExecuteReader();
            while(dr5.Read())
            {
                lblortmaas.Text = dr5[0].ToString();
            }
            baglanti.Close();
        }
    }
}
