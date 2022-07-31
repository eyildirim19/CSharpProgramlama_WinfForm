namespace _2_App4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // EventArgs => Eventi temsil eder.. 
        // Sender   => Eventi tetikleyen nesnesi temsil eder..
        
        private void Islem_Click(object sender, EventArgs e)
        {
            // ilk deðer fieldlarda atamak zorunluý deðilken deðiþkenlerde zorunludur..
            int sayi1 = 0, sayi2 = 0, sonuc = 0;
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi1 = Convert.ToInt32(txtSayi2.Text);
            }
            catch
            {
                MessageBox.Show("Lütfen girdiðiniz deðerleri kontrol ediniz");
            }
            //C# dilinde object bütün tiplerin atasýdýr. yani bütün tipler object sýnýfýndan türetilmiþtir...
            // object bütün tipplerin referansýný tutabilir..
            // btn nesnesi Button tipindedir ve sender ile gelen referansý tutmasý için tanýmlanmýþtýr....
            // objectten baþka bir tipe dönüþüme unboxing denir..
            Button btn = (Button)sender;
            switch (btn.Tag)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
            }
            lblSonuc.Text = sonuc.ToString();
        }
    }
}