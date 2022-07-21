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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-H333VG89;Initial Catalog=personel;Integrated Security=True");

        void temizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            maskedtxtmaas.Text = "";
            radiob.Checked = false;
            radioe.Checked = false;
            combosehir.Text = "";
            textmeslek.Text = "";
            txtad.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDataSet.tbl_personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_personelTableAdapter.Fill(this.personelDataSet.tbl_personel);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //VERİ TABANINA KAYDETME
            baglanti.Open();
            SqlCommand taban = new SqlCommand("insert into tbl_personel (per_ad,per_soyad,per_sehir,per_maas,per_meslek,per_medeni_d) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            taban.Parameters.AddWithValue("@p1", txtad.Text);
            taban.Parameters.AddWithValue("@p2", txtsoyad.Text);
            taban.Parameters.AddWithValue("@p3", combosehir.Text);
            taban.Parameters.AddWithValue("@p4", maskedtxtmaas.Text);
            taban.Parameters.AddWithValue("@p5", textmeslek.Text);
            taban.Parameters.AddWithValue("@p6", lblmedeni.Text);
            taban.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("PERSONEL BİLGİSİ EKLENDİ!");
        }

        private void radioe_CheckedChanged(object sender, EventArgs e)
        {
            lblmedeni.Text = "true";
        }

        private void radiob_CheckedChanged(object sender, EventArgs e)
        {
            lblmedeni.Text = "false";
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textper_id.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            combosehir.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            maskedtxtmaas.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            lblmedeni.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            textmeslek.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();  

            if(lblmedeni.Text == "True")
            {
                radioe.Checked = true;
            }
            if(lblmedeni.Text == "False")
            {
                radiob.Checked = true;
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from tbl_personel where per_id = @a1", baglanti);
            sil.Parameters.AddWithValue("@a1", textper_id.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgisi Silindi!");       
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand update = new SqlCommand("update tbl_personel set per_ad = @u1, per_soyad = @u2, per_sehir = @u3, per_maas = @u4, per_medeni_d = @u5, per_meslek = @u6 where per_id = @u7", baglanti);
            update.Parameters.AddWithValue("@u1", txtad.Text);
            update.Parameters.AddWithValue("@u2", txtsoyad.Text);
            update.Parameters.AddWithValue("@u3", combosehir.Text);
            update.Parameters.AddWithValue("@u4", maskedtxtmaas.Text);
            update.Parameters.AddWithValue("@u5", lblmedeni.Text);
            update.Parameters.AddWithValue("@u6", textmeslek.Text);
            update.Parameters.AddWithValue("@u7", textper_id.Text);
            update.ExecuteNonQuery();    
            baglanti.Close();
            MessageBox.Show("Personel Bilgisi Güncellendi!");
        }

        private void btnist_Click(object sender, EventArgs e)
        {
            Formistatistik frm = new Formistatistik();
            frm.Show();
        }

        private void btngraphic_Click(object sender, EventArgs e)
        {
            FormGrafik fg = new FormGrafik();
            fg.Show();
        }
    }
}
