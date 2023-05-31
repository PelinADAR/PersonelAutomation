using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _01_WF_PersonelListesi
{
    internal class Personel
    {
        private int personelID;

        public int PersonelId
        {
            get { return personelID; }
            set { if (value < 100000 || value > 9999)
                    personelID = value;
                else personelID= 0;
            
                }
        }

        public string PersonelAd { get; set; } 
        public string PersonelSoyad { get; set; } 

        private DateTime doğumTarihi;

        public DateTime DoğumTarihi
        {
            get { return doğumTarihi; }
            set
            {
                int yas = DateTime.Now.Year - value.Year;
                if (yas>=18)
                {
                    doğumTarihi = value; 
                }
                else
                    doğumTarihi=DateTime.Now;//Buraya tekrar bakılacak.
               
            }
        }

        // public DateTime DoğumTarihi { get; set; }
        //?telefon numarası
        public decimal TelefonNumarası { get; set; }
        public string Mail { get; set; } 
        public string Adres { get; set; }

        public DateTime İşeGirişTarihi { get; set; }

        public Unvan Unvan { get; set; }

        public static string MailOluştur(string ad, string soyad)
        {
            string mail = ad.ClearString() + "." + soyad.ClearString() + "@bilgeadam.com";
            return mail;
        }

       
    }

    internal enum Unvan
    {
        Müdür,
        MüdürYardımcısı,
        Öğretmen,
        ZümreBaşkanı,
        Sekreter,
        Memur,
        TemizlikGörevlisi,
        GüvenlikGörevlisi


    }
}
internal static class ExtensionMethod
{
    //Parametrede this keyword'ünü kullandığımızda extension method yazmış oluruz.
    public static string ClearString(this string param)
    {
        param = param.ToLower()
            .Replace("ş", "s")
            .Replace("ğ", "g")
            .Replace("â", "a")
            .Replace("ö", "o")
            .Replace("ı", "i")
            .Replace("ç", "c");

        return CultureInfo.CurrentCulture.TextInfo.ToLower(param); 



    }
}