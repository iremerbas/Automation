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


namespace otomasyon_31052022
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader reader;
        SqlCommand com;


        public Form1()
        {
            InitializeComponent();         
        }
       
      
        public void btn_giris_Click(object sender, EventArgs e)
        {
            string user = txt_kullanici_adi.Text;
            string password = txt_sifre.Text;

            con = new SqlConnection("data source=YAHYA\\SQLEXPRESS; initial catalog=Sınıf_Listesi; user Id=sa; password=123456;");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kullanıcı_Bilgileri where KullaniciAdi='" + txt_kullanici_adi.Text +
                "'And Sifre='" + txt_sifre.Text + "'";
            reader = com.ExecuteReader();
            if(reader.Read())
            {
               
                Form2 form = new Form2();
                form.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya hatalı şifre girişi yaptınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kullanici_adi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
