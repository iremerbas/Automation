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
using Microsoft.Office.Interop.Excel;



namespace otomasyon_31052022
{
    public partial class Not_Girisi : Form
    {
        public Not_Girisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("data source=YAHYA\\SQLEXPRESS; initial catalog=Sınıf_Listesi; user Id=sa; password=123456;");

        SqlCommand komut = new SqlCommand();
        DataSet ds;
        SqlDataAdapter da;

        private void BTN_lİSTELE_Click(object sender, EventArgs e)
        {
            //verilerigoster();
            da = new SqlDataAdapter("Select  id,No,Adı_Soyadı,Sınıfı,Cinsiyet,quiz1,quiz2,vize,proje,final from Liste", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Liste");
            dataGridView1.DataSource = ds.Tables["liste"];
            baglanti.Close();
        }

        private void verilerigoster()
        {

            da = new SqlDataAdapter("Select * from liste", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "liste");
            dataGridView1.DataSource = ds.Tables["liste"]; ;
            baglanti.Close();
        }


        public void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update  liste set Quiz1='" + txt_quiz1.Text.ToString() + "',Quiz2='" + txt_qıiz2.Text.ToString() + "',Vize='" + txt_vize.Text.ToString() + "',Proje='" + txt_proje.Text.ToString() + "',Final='" + txt_final.Text.ToString() + "'  where id='" + txt_sıra_not.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            txt_sıra_not.Text = "";
            txt_numara_not.Text = "";
            txt_ad_not.Text = "";
            txt_sınıf_not.Text = "";
            txt_cinsiyet_not.Text = "";
            txt_quiz1.Text = "";
            txt_qıiz2.Text = "";
            txt_vize.Text = "";
            txt_proje.Text = "";
            txt_final.Text = "";

        }

       public void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update  liste set Quiz1=0, Quiz2=0, Vize=0,Proje=0,Final=0 where id='" + txt_sıra_not.Text + "'";
            komut.ExecuteNonQuery();
            
            baglanti.Close();
            verilerigoster();
            txt_sıra_not.Text = "";
            txt_numara_not.Text = "";
            txt_ad_not.Text = "";
            txt_sınıf_not.Text = "";
            txt_cinsiyet_not.Text = "";
            txt_quiz1.Text = "";
            txt_qıiz2.Text = "";
            txt_vize.Text = "";
            txt_proje.Text = "";
            txt_final.Text = "";


        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update  liste set Quiz1='" + txt_quiz1.Text.ToString() + "',Quiz2='" + txt_qıiz2.Text.ToString() + "',Vize='" + txt_vize.Text.ToString() + "',Proje='" + txt_proje.Text.ToString() + "',Final='" + txt_final.Text.ToString() + "'  where id='" + txt_sıra_not.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            txt_sıra_not.Text = "";
            txt_numara_not.Text = "";
            txt_ad_not.Text = "";
            txt_sınıf_not.Text = "";
            txt_cinsiyet_not.Text = "";
            txt_quiz1.Text = "";
            txt_qıiz2.Text = "";
            txt_vize.Text = "";
            txt_proje.Text = "";
            txt_final.Text = "";

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sıra_not.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_numara_not.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ad_not.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_sınıf_not.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_cinsiyet_not.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_quiz1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_qıiz2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_vize.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_proje.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_final.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }


        private void btn_excell_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap1 = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap1.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }

        private void Not_Girisi_Load(object sender, EventArgs e)
        {
            dt_veri_aktar();
        }

        public void dt_veri_aktar()
        {
            da = new SqlDataAdapter("select * from Liste", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Liste");
            dataGridView1.DataSource = ds.Tables["Liste"];
            baglanti.Close();
        }

      
    }

}