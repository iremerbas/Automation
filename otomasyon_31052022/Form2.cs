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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace otomasyon_31052022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        SqlConnection baglanti = new SqlConnection("data source=YAHYA\\SQLEXPRESS; initial catalog=Sınıf_Listesi; user Id=sa; password=123456;");
      
        SqlCommand komut = new SqlCommand();
        DataSet ds;
        SqlDataAdapter da;
       


       
        private void btn_goster_Click(object sender, EventArgs e)
        {

            da = new SqlDataAdapter("Select id,No,Adı_Soyadı,Sınıfı,Cinsiyet from Liste", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Liste");
            dataGridView1.DataSource = ds.Tables["liste"];
            baglanti.Close();

        }

        private void verilerigoster()
        {
            da = new SqlDataAdapter("Select id,No,Adı_Soyadı,Sınıfı,Cinsiyet from Liste", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Liste");
            dataGridView1.DataSource = ds.Tables["liste"]; 
            baglanti.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  liste (id , No , Adı_Soyadı, Sınıfı, Cinsiyet) values ('" + txt_sıra.Text.ToString() + "','" + txt_numara.Text.ToString() + "','" + txt_ad.Text.ToString() + "','" + txt_sınıf.Text.ToString() + "','" + txt_cinsiyet.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            
            txt_sıra.Text = "";
            txt_numara.Text = "";
            txt_ad.Text = "";
            txt_sınıf.Text = "";
            txt_cinsiyet.Text = "";
        }


        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from liste where id ='" + txt_sıra_guncel.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            txt_sıra_guncel.Text = "";
            txt_numara_guncel.Text = "";
            txt_ad_guncel.Text = "";
            txt_sınıf_guncel.Text = "";
            txt_cinsiyet_guncel.Text = "";

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update  liste set No='" + txt_numara_guncel.Text.ToString() + "',Adı_Soyadı='" + txt_ad_guncel.Text.ToString() + "',Sınıfı='" + txt_sınıf_guncel.Text.ToString() + "',Cinsiyet='" + txt_cinsiyet_guncel.Text.ToString() + "'  where id='" + txt_sıra_guncel.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            txt_sıra_guncel.Text = "";
            txt_numara_guncel.Text = "";
            txt_ad_guncel.Text = "";
            txt_sınıf_guncel.Text = "";
            txt_cinsiyet_guncel.Text = "";

        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_sıra_guncel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_numara_guncel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ad_guncel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_sınıf_guncel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_cinsiyet_guncel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_not_Click(object sender, EventArgs e)
        {
            Not_Girisi not = new Not_Girisi();
            not.Show();
            this.Hide();

        }

    }
}
