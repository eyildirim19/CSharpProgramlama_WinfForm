namespace _3_PartialClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "A";
            ogr.SoyAdi = "B";
            ogr.Vize = 40;
            ogr.Final = 100;
        }
    }
}