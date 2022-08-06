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
            // C# dilinde a��kca tip belirlemeden de�i�ken olu�turmam�z� sa�layan yap�lad�r...
            // anonim = var
            var num = 1; // int tipinde de�i�ken
            var name = "bt akademi"; // string tipinde de�i�ken
            var cinsiyet = 'e'; // char tipinde de�i�ken
            num = 10;
            // anomim tipli de�i�kenlerin tipleri de�er atand���nda olu�ur...bu y�zden anonim tiplerde ilk de�er atamas� zorunludur...
            //var durum;
            var durum = true;
            durum = false;
            // e�er ilk de�er yoksa
            // default �zelli�i => anonim tipin de�er ataams� yap�lmad��� yerde tip belirlemek i�in kullan�l�r
            var maas = default(decimal);
            // var genellikle kulland���m�z bir tiptir..ancak value typle i�lemlerde �ok tercih etmeyiniz..
            // baz� durumlarda �zel anl�k tipler olu�turma�z gerekir. bu durumlarda s�n�f olu�turmak yerine anonim tipleri tercih ediliriz..

            // new ifadesi a�a��daki gibi kullan�l�rsa bu anonim de�er atamas�d�r..
            var kisi = new
            {
                Adi = "Ziya",
                SoyAdi = "Erdo�du",
                Yas = 33
            };
            var ogrenci = new { Vize = 40, Final = 55.1d };

            // kisi.Adi = "�smail"; // => anonim tipli bir nesnenin propertyleri readonly'dir. yani sadece okunabilir...
            MessageBox.Show($"{kisi.Adi} {kisi.SoyAdi} {kisi.Yas}");
            // Anonim tipler dizi veya de�i�ken olarkta kullan�labilir..
            // �zellikle ileride linq yap�lar� ile tercih edelir ve ciddi kolayl�klar� vard�r...
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
            deger.Add("EgitimAdi", "Yaz�l�m Uzmanl���");
            deger.Add("Kontenjan", "12");


            // foreach d�ng�s�nde degisken tipi var verilir
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