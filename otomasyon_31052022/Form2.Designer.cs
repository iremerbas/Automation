
namespace otomasyon_31052022
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_goster = new System.Windows.Forms.Button();
            this.SIRA = new System.Windows.Forms.Label();
            this.txt_sıra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sınıf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cinsiyet = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad_guncel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_numara_guncel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sınıf_guncel = new System.Windows.Forms.TextBox();
            this.txt_cinsiyet_guncel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_sıra_guncel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_not = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_goster
            // 
            this.btn_goster.BackColor = System.Drawing.Color.Silver;
            this.btn_goster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_goster.Location = new System.Drawing.Point(30, 594);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(245, 74);
            this.btn_goster.TabIndex = 3;
            this.btn_goster.Text = "Sınıf Listesi";
            this.btn_goster.UseVisualStyleBackColor = false;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // SIRA
            // 
            this.SIRA.AutoSize = true;
            this.SIRA.Location = new System.Drawing.Point(35, 24);
            this.SIRA.Name = "SIRA";
            this.SIRA.Size = new System.Drawing.Size(39, 17);
            this.SIRA.TabIndex = 4;
            this.SIRA.Text = "SIRA";
            // 
            // txt_sıra
            // 
            this.txt_sıra.Location = new System.Drawing.Point(126, 21);
            this.txt_sıra.Multiline = true;
            this.txt_sıra.Name = "txt_sıra";
            this.txt_sıra.Size = new System.Drawing.Size(222, 27);
            this.txt_sıra.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMARA";
            // 
            // txt_numara
            // 
            this.txt_numara.Location = new System.Drawing.Point(126, 75);
            this.txt_numara.Multiline = true;
            this.txt_numara.Name = "txt_numara";
            this.txt_numara.Size = new System.Drawing.Size(222, 27);
            this.txt_numara.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "AD SOYAD";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(126, 126);
            this.txt_ad.Multiline = true;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(222, 27);
            this.txt_ad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "SINIF";
            // 
            // txt_sınıf
            // 
            this.txt_sınıf.Location = new System.Drawing.Point(126, 173);
            this.txt_sınıf.Multiline = true;
            this.txt_sınıf.Name = "txt_sınıf";
            this.txt_sınıf.Size = new System.Drawing.Size(222, 27);
            this.txt_sınıf.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CİNSİYET";
            // 
            // txt_cinsiyet
            // 
            this.txt_cinsiyet.Location = new System.Drawing.Point(126, 220);
            this.txt_cinsiyet.Multiline = true;
            this.txt_cinsiyet.Name = "txt_cinsiyet";
            this.txt_cinsiyet.Size = new System.Drawing.Size(222, 27);
            this.txt_cinsiyet.TabIndex = 5;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(37, 273);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(145, 39);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(199, 273);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(159, 39);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "AD SOYAD";
            // 
            // txt_ad_guncel
            // 
            this.txt_ad_guncel.Location = new System.Drawing.Point(136, 132);
            this.txt_ad_guncel.Multiline = true;
            this.txt_ad_guncel.Name = "txt_ad_guncel";
            this.txt_ad_guncel.Size = new System.Drawing.Size(222, 27);
            this.txt_ad_guncel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "NUMARA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "SINIF";
            // 
            // txt_numara_guncel
            // 
            this.txt_numara_guncel.Location = new System.Drawing.Point(136, 81);
            this.txt_numara_guncel.Multiline = true;
            this.txt_numara_guncel.Name = "txt_numara_guncel";
            this.txt_numara_guncel.Size = new System.Drawing.Size(222, 27);
            this.txt_numara_guncel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "CİNSİYET";
            // 
            // txt_sınıf_guncel
            // 
            this.txt_sınıf_guncel.Location = new System.Drawing.Point(136, 179);
            this.txt_sınıf_guncel.Multiline = true;
            this.txt_sınıf_guncel.Name = "txt_sınıf_guncel";
            this.txt_sınıf_guncel.Size = new System.Drawing.Size(222, 27);
            this.txt_sınıf_guncel.TabIndex = 5;
            // 
            // txt_cinsiyet_guncel
            // 
            this.txt_cinsiyet_guncel.Location = new System.Drawing.Point(136, 226);
            this.txt_cinsiyet_guncel.Multiline = true;
            this.txt_cinsiyet_guncel.Name = "txt_cinsiyet_guncel";
            this.txt_cinsiyet_guncel.Size = new System.Drawing.Size(222, 27);
            this.txt_cinsiyet_guncel.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sıra);
            this.groupBox1.Controls.Add(this.SIRA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_cinsiyet);
            this.groupBox1.Controls.Add(this.txt_numara);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_sınıf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(531, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 319);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Ekleme";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Silver;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(38, 267);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(310, 37);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_sıra_guncel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_numara_guncel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.txt_ad_guncel);
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_cinsiyet_guncel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_sınıf_guncel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(531, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 325);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncelle / Sil";
            // 
            // txt_sıra_guncel
            // 
            this.txt_sıra_guncel.Location = new System.Drawing.Point(136, 31);
            this.txt_sıra_guncel.Multiline = true;
            this.txt_sıra_guncel.Name = "txt_sıra_guncel";
            this.txt_sıra_guncel.Size = new System.Drawing.Size(222, 27);
            this.txt_sıra_guncel.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "SIRA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 576);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 715);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_not
            // 
            this.btn_not.BackColor = System.Drawing.Color.Silver;
            this.btn_not.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_not.Location = new System.Drawing.Point(281, 594);
            this.btn_not.Name = "btn_not";
            this.btn_not.Size = new System.Drawing.Size(244, 74);
            this.btn_not.TabIndex = 11;
            this.btn_not.Text = "Not Girişi Yapınız";
            this.btn_not.UseVisualStyleBackColor = false;
            this.btn_not.Click += new System.EventHandler(this.btn_not_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 690);
            this.Controls.Add(this.btn_not);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_goster);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınıf Listesi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.Label SIRA;
        private System.Windows.Forms.TextBox txt_sıra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sınıf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cinsiyet;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad_guncel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_numara_guncel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sınıf_guncel;
        private System.Windows.Forms.TextBox txt_cinsiyet_guncel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_sıra_guncel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_not;
        private System.Windows.Forms.Button btn_ekle;
    }
}