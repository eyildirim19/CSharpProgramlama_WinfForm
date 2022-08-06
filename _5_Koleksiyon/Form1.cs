using System.Collections;

namespace _5_Koleksiyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Array (uzunluk sabittir (statikdir))
        // Collections (uzunluk sabit deðildir (dinamiktir)). Collection sýnýflar System.Collections namepsacesi içerisindedir..
        // Generic Collection

        //string[] kisiler = new string[5];
        //int ind; // sýnýf seviye fieldlarýn default deðerleri vardýr. int 0'dýr
        ArrayList kisiList = new ArrayList();
        private void brnEkle_Click(object sender, EventArgs e)
        {
            //kisiler[ind] = txtIsim.Text;
            //ind++;
            kisiList.Add(txtIsim.Text);

            txtIsim.Clear(); // texti temizle...

            //Add Metodu koleksiyonlarda eleman eklemek için kullanýlýr....
            //Count property'si koleksiyonun uzunluðunu verir 

            kisiList.Add("test");
            kisiList.Remove("test"); // test elemanýný sil... 


        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kisiList.Count; i++)
            {
                lboxIsýmler.Items.Add(kisiList[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // key value þeklinde veri saklayan koleksiyon yapýsýdýr. Dizi veya ArrayListten farklý keyler bizim indexlerimiz ve tarafýmýzdan oluþturulur...

            Hashtable ht = new Hashtable(); // koleksiyon...
            ht.Add("a", "Ekrem");
            ht.Add("b", "Ziya");
            ht.Add("c", "Büþra");

            // Not : keyler unique (benzersiz) olmalýdýr
            //  ht.Add("b", "Ýsmail");

            ht["b"] = "Ýsmail"; // var olan bir indexe eleman atamasý yapýlabilir...


            string str = ht["c"].ToString();

            // Koleksiyonlar kullanýlýrken dizilerdki gibi tip belirtilmez. Çünkü koleksiyon object tipinde eleman saklar (elemanlar object tipindedir). object c# dilinde bütün tiplerin atasýdýr. yani bütün tiplerin referansýný tutabilir. 

            // onject olarak saklandýklarý kullanalýacaðý zaman tekrar objecttten dönüþüm yapýlmasý gerekir. çünkü object referans tutan bir varlýktýr. buda performans sorunu olarak karþýmýza çýkar...

            ArrayList arrNames = new ArrayList();
            arrNames.Add("Onur");
            arrNames.Add("Celalettin");

            ArrayList arrNums = new ArrayList();
            arrNums.Add(10);
            arrNums.Add(20);
            arrNums.Add(30);

            ArrayList arrChars = new ArrayList();
            arrChars.Add('A');
            arrChars.Add('B');
            arrChars.Add('C');


            Ogrenci o = new Ogrenci();
            o.Adi = "Ýsmail";
            o.SoyAdi = "Aslan";

            Ogrenci o1 = new Ogrenci();
            o1.Adi = "Büþra";
            o1.SoyAdi = "Genç";

            ArrayList arrOgr = new ArrayList();
            arrOgr.Add(o);
            arrOgr.Add(o1);

            // object'e dönüþüm boxing
            // object'ten dönüþün unboxing
            // iþlemidir...

            int num = 0;
            for (int i = 0; i < arrNums.Count; i++)
            {
                num += (int)arrNums[i]; // unboxing
            }

            for (int i = 0; i < arrOgr.Count; i++)
            {
                Ogrenci otemp = (Ogrenci)arrOgr[i];
                MessageBox.Show(otemp.Adi);
            }

            // koleksiyon yapýlarýnda tip güvenliði yoktur..
            string[] arr = new string[2]; // dizilerin tip güvenliði vardýr. yani dizi tipinde eleman eklenebilir
            //arr[0] = 100;

            //int s = "aaa"; // deðiþkenlerin tip güvenliði vardýr. degisken tipinde veri set edilebilir..

            ArrayList arrrTemp = new ArrayList();
            arrrTemp.Add("ekrem");
            arrrTemp.Add(100);
            arrrTemp.Add('E');

            // i 1 olkduðubnda 1. eleman int tipinde olduüu için string tipinde çýkarýlamaz. çalýþma zamaný hatasý alýrýz.

            // koleksiyonlarda bu þekilde farklý tipten veriler bir arada saklanabildiði için bu bir dezavantajdýr..Dikkatli olmaklý gerekir.. 
            for (int i = 0; i < arrrTemp.Count; i++)
            {
                string name = (string)arrrTemp[i];
            }
        }
    }
}