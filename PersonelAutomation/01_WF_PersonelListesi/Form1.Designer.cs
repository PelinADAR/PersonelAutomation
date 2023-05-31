namespace _01_WF_PersonelListesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDBilgi = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTelNo = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtpIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txbAdres = new System.Windows.Forms.TextBox();
            this.txbSoyad = new System.Windows.Forms.TextBox();
            this.txbAd = new System.Windows.Forms.TextBox();
            this.txbPersonelID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblYaş = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblYaş);
            this.groupBox1.Controls.Add(this.lblIDBilgi);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txbTelNo);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.pbResim);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.dtpIseGirisTarihi);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnResimSec);
            this.groupBox1.Controls.Add(this.cmbUnvan);
            this.groupBox1.Controls.Add(this.dtpDogumTarihi);
            this.groupBox1.Controls.Add(this.txbAdres);
            this.groupBox1.Controls.Add(this.txbSoyad);
            this.groupBox1.Controls.Add(this.txbAd);
            this.groupBox1.Controls.Add(this.txbPersonelID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 564);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL BİLGİLERİ";
            // 
            // lblIDBilgi
            // 
            this.lblIDBilgi.AutoSize = true;
            this.lblIDBilgi.Location = new System.Drawing.Point(147, 62);
            this.lblIDBilgi.Name = "lblIDBilgi";
            this.lblIDBilgi.Size = new System.Drawing.Size(0, 15);
            this.lblIDBilgi.TabIndex = 28;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(148, 265);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(153, 23);
            this.txbEmail.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "@bilgeadam.com";
            // 
            // txbTelNo
            // 
            this.txbTelNo.Location = new System.Drawing.Point(147, 223);
            this.txbTelNo.Mask = "(999) 000-0000";
            this.txbTelNo.Name = "txbTelNo";
            this.txbTelNo.Size = new System.Drawing.Size(215, 23);
            this.txbTelNo.TabIndex = 24;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 314);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 249);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personel ID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşe Giriş Tarihi";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mail Adresi";
            this.columnHeader5.Width = 150;
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Location = new System.Drawing.Point(444, 199);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(100, 109);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 22;
            this.pbResim.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(562, 280);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(215, 23);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(562, 251);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(215, 23);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // dtpIseGirisTarihi
            // 
            this.dtpIseGirisTarihi.Location = new System.Drawing.Point(562, 123);
            this.dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            this.dtpIseGirisTarihi.Size = new System.Drawing.Size(215, 23);
            this.dtpIseGirisTarihi.TabIndex = 19;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(562, 222);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(215, 23);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(562, 193);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(215, 23);
            this.btnResimSec.TabIndex = 17;
            this.btnResimSec.Text = "RESİM SEÇ";
            this.btnResimSec.UseVisualStyleBackColor = true;
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.BackColor = System.Drawing.SystemColors.Window;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Yönetici",
            "Takım Lideri",
            "Kıdemli Uzman",
            "Uzman",
            "Uzman Yardımcısı",
            "Formen",
            "Tekniker"});
            this.cmbUnvan.Location = new System.Drawing.Point(562, 158);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(215, 23);
            this.cmbUnvan.TabIndex = 16;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(148, 175);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(215, 23);
            this.dtpDogumTarihi.TabIndex = 15;
            // 
            // txbAdres
            // 
            this.txbAdres.Location = new System.Drawing.Point(532, 42);
            this.txbAdres.Multiline = true;
            this.txbAdres.Name = "txbAdres";
            this.txbAdres.Size = new System.Drawing.Size(245, 63);
            this.txbAdres.TabIndex = 14;
            // 
            // txbSoyad
            // 
            this.txbSoyad.Location = new System.Drawing.Point(147, 128);
            this.txbSoyad.Name = "txbSoyad";
            this.txbSoyad.Size = new System.Drawing.Size(215, 23);
            this.txbSoyad.TabIndex = 11;
            // 
            // txbAd
            // 
            this.txbAd.Location = new System.Drawing.Point(148, 87);
            this.txbAd.Name = "txbAd";
            this.txbAd.Size = new System.Drawing.Size(215, 23);
            this.txbAd.TabIndex = 10;
            // 
            // txbPersonelID
            // 
            this.txbPersonelID.Location = new System.Drawing.Point(147, 39);
            this.txbPersonelID.Name = "txbPersonelID";
            this.txbPersonelID.Size = new System.Drawing.Size(215, 23);
            this.txbPersonelID.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "UNVAN :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "İŞE GİRİŞ TARİHİ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "ADRES :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-MAİL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFON NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOĞUM TARİHİ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL ID :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblYaş
            // 
            this.lblYaş.AutoSize = true;
            this.lblYaş.Location = new System.Drawing.Point(147, 197);
            this.lblYaş.Name = "lblYaş";
            this.lblYaş.Size = new System.Drawing.Size(0, 15);
            this.lblYaş.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 587);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listView1;
        private PictureBox pbResim;
        private Button btnSil;
        private Button btnGuncelle;
        private DateTimePicker dtpIseGirisTarihi;
        private Button btnKaydet;
        private Button btnResimSec;
        private ComboBox cmbUnvan;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txbAdres;
        private TextBox txbSoyad;
        private TextBox txbAd;
        private TextBox txbPersonelID;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private MaskedTextBox txbTelNo;
        private Label label10;
        private TextBox txbEmail;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblIDBilgi;
        private Label lblYaş;
    }
}