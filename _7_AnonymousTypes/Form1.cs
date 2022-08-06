namespace _7_AnonymousTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Anonymous Types => (Anonim) tipler
            // C# dilinde açýkca tip belirlemeden deðiþken oluþturmamýzý saðlayan yapýladýr...
            // anonim = var
            var num = 1; // int tipinde deðiþken
            var name = "bt akademi"; // string tipinde deðiþken
            var cinsiyet = 'e'; // char tipinde deðiþken
            num = 10;
            // anomim tipli deðiþkenlerin tipleri deðer atandýðýnda oluþur...bu yüzden anonim tiplerde ilk deðer atamasý zorunludur...
            //var durum;
            var durum = true;
            durum = false;
            // eðer ilk deðer yoksa
            // default özelliði => anonim tipin deðer ataamsý yapýlmadýðý yerde tip belirlemek için kullanýlýr
            var maas = default(decimal);
            // var genellikle kullandýðýmýz bir tiptir..ancak value typle iþlemlerde çok tercih etmeyiniz..
            // bazý durumlarda özel anlýk tipler oluþturmaýz gerekir. bu durumlarda sýnýf oluþturmak yerine anonim tipleri tercih ediliriz..

            // new ifadesi aþaðýdaki gibi kullanýlýrsa bu anonim deðer atamasýdýr..
            var kisi = new
            {
                Adi = "Ziya",
                SoyAdi = "Erdoðdu",
                Yas = 33
            };
            var ogrenci = new { Vize = 40, Final = 55.1d };

            // kisi.Adi = "Ýsmail"; // => anonim tipli bir nesnenin propertyleri readonly'dir. yani sadece okunabilir...
            MessageBox.Show($"{kisi.Adi} {kisi.SoyAdi} {kisi.Yas}");
            // Anonim tipler dizi veya deðiþken olarkta kullanýlabilir..
            // özellikle ileride linq yapýlarý ile tercih edelir ve ciddi kolaylýklarý vardýr...
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<string> isimler = new List<string>();
            isimler.Add("Ziya");
            isimler.Add("Celalettin");

            List<int> sayilar = new List<int>();
            sayilar.Add(100);
            sayilar.Add(10);

            Dictionary<string, string> deger = new Dictionary<string, string>();
            deger.Add("KurumAdi", "BT Akademi");
            deger.Add("EgitimAdi", "Yazýlým Uzmanlýðý");
            deger.Add("Kontenjan", "12");


            // foreach döngüsünde degisken tipi var verilir
            foreach (var item in isimler)
            {
                MessageBox.Show(item);
            }

            foreach (var item in deger)
            {
                MessageBox.Show($"{item.Key} : {item.Value}");
            }

            foreach (var item in sayilar)
            {

            }
        }
    }
}