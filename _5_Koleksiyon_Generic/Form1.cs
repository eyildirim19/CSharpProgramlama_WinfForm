namespace _5_Koleksiyon_Generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // non-generic koleksiyon => (collections vb) birden fazla veriyi bir arada tutmak için kullanýlan yapýlardýr...

            // generic  koleksiyon =>  ayný tipde birden fazla veriyi bir arada tutmak için kullanýlan yapýlardýr...

            // ArrayList'Ýn generic karþýlýðý List tipidir. Ancak List sýnýfý generic olduðu için instance alýnýrken tip belirtilmelidir

            // string tipinde koleksiyon
            List<string> names = new List<string>();
            List<int> nums = new List<int>();
            List<char> chars = new List<char>();

            names.Add("Ziya");
            names.Add("Ýsmail");

            nums.Add(10);
            nums.Add(20);
            nums.Add(30);

            chars.Add('A');
            chars.Add('B');

            char c = chars[0];
            string n = names[0];
            int nu = nums[0];


            Kullanici k1 = new Kullanici();
            k1.KullaniciAdi = "eyildirim";
            k1.Password = 123;

            Kullanici k2 = new Kullanici();
            k2.KullaniciAdi = "zerdogdu";
            k2.Password = 54321;


            List<Kullanici> kullanicis = new List<Kullanici>();
            kullanicis.Add(k1);
            kullanicis.Add(k2);

            //names.Add(1); // koleksiyonlardaki gibi object beklemediði için ve intance alýnýrken string belirtildiði için sadece string eleman eklenebilir...


            //Hastable tipinin generic karþýlýðý Dictonary
            Dictionary<string, int> dnums = new Dictionary<string, int>();
            dnums.Add("a", 10);
            dnums.Add("b", 20);
            dnums.Add("c", 30);

            int dn = dnums["b"]; // b indexindeki elemaný dn deðiþkenine ata
            dnums["c"] = 300; // c indexine 300 verisini ata..

            // KeyValuePair => dictionary içerisindeki 1 satýrý temsil eder..
            foreach (KeyValuePair<string, int> dic in dnums)
            {
                MessageBox.Show(dic.Key); // keyini yazdýr
                MessageBox.Show(dic.Value.ToString()); // value yazdýr
            }
        }


        List<string> kisiler = new List<string>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtName.Text);
            txtName.Clear();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lBoxNames.Items.Clear();
            //for (int i = 0; i < kisiler.Count; i++)
            //{
            //    lBoxNames.Items.Add(i);
            //}
            foreach (string kisi in kisiler)
            {
                lBoxNames.Items.Add(kisi);
            }
        }
    }
}