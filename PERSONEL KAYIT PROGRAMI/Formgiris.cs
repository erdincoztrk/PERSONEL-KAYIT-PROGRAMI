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
    public partial class Formgiris : Form
    {
        public Formgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-H333VG89;Initial Catalog=personel;Integrated Security=True");
        private void Formgiris_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from dbo.giristablo where [KULLANICI ADI] = @p1 and ŞİFRE = @p2", baglanti);
            komut.Parameters.AddWithValue("p1", txtk_Adi.Text);
            komut.Parameters.AddWithValue("p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KULLANICI ADI: admin1" + "\n" + "ŞİFRE: 135790");
        }
    }
}
