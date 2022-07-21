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
    public partial class FormGrafik : Form
    {
        public FormGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-H333VG89;Initial Catalog=personel;Integrated Security=True");
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FormGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1g = new SqlCommand("select per_sehir, count(*) from tbl_personel group by per_sehir", baglanti);
            SqlDataReader dr1 = komut1g.ExecuteReader();

            while(dr1.Read())
            {
                chart1.Series["ŞEHİRLER"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2g = new SqlCommand("select per_meslek, avg(per_maas) from tbl_personel group by per_meslek", baglanti);
            SqlDataReader dr2 = komut2g.ExecuteReader();

            while (dr2.Read())
            {
                chart2.Series["MAAŞLAR"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
        }
    }
}
