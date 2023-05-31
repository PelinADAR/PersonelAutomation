namespace _01_WF_PersonelListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Listeden bir seçim yapmalýsýnýz.");
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool kontrol = int.TryParse(txbPersonelID.Text, out int Id);

            if (kontrol == false)
            {
                lblIDBilgi.Text = "personel Id 5 basamaklý olmalýdýr. lütfen tekrar giriniz.";
                txbPersonelID.Text = "";
            }
            else if (dtpDogumTarihi.Value.Year - DateTime.Now.Year==0)
            {
                lblYaþ.Text = "Personel yaþý 18'den küçük olamaz!";
            }
            else
            {
                if (txbPersonelID.Text != "" && txbAd.Text != "" && txbSoyad.Text != "" && dtpIseGirisTarihi.Text != "")
                {

                    string personelID = txbPersonelID.Text;
                    string ad = txbAd.Text;
                    string soyad = txbSoyad.Text;
                    string email = Personel.MailOluþtur(ad,soyad);
                    string iseGirisTarihi = dtpIseGirisTarihi.Text;

                    string[] personelBilgileri = { personelID, ad, soyad, iseGirisTarihi, email };

                        ListViewItem kayit = new ListViewItem(personelBilgileri);

                        listView1.Items.Add(kayit);

                        MessageBox.Show("Personel bilgileri kaydedildi.");


                    }
                    else
                        MessageBox.Show("Personel bilgileri kaydedilmedi, bilgilerini tam ve eksiksiz giriniz.");
                }
                Temizle();
            }

        private void Temizle()
        {
            txbAd.Text = "";
            txbPersonelID.Text = "";
            txbSoyad.Text = "";
            txbTelNo.Text = "";
            txbEmail.Text = "";
            txbAdres.Text = "";
            cmbUnvan.Text = "";
            dtpDogumTarihi.Value = DateTime.Now;
            dtpIseGirisTarihi.Value = DateTime.Now;
            pbResim.Image = null;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                // item.Tag
                txbPersonelID.Text = item.SubItems[0].Text;
                txbAd.Text = item.SubItems[1].Text;
                txbSoyad.Text = item.SubItems[2].Text;

            }
        }
    }

    //private void txbPersonelID_TextChanged(object sender, EventArgs e)
    //{

    //}


    //public void btnResimSec_Click(object sender, EventArgs e)
    //{

    //    OpenFileDialog fd = new OpenFileDialog();
    //    fd.Filter = "Metin Dosyalarý (*.png)|*.png |Tüm Dosyalar (*.*)|*.*";
    //    fd.ShowDialog();
    //    string fileP = fd.FileName;
    //    pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
    //    pbResim.ImageLocation = fileP;
    //}


    




    //private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
    //{
    //    txbPersonelID.Text = listView1.SelectedItems[0].Text;
    //    txbAd.Text = listView1.SelectedItems[1].Text;
    //    txbSoyad.Text = listView1.SelectedItems[2].Text;
    //    dtpIseGirisTarihi.Text = listView1.SelectedItems[3].Text;
    //    txbEmail.Text = listView1.SelectedItems[4].Text;

    //}


}

