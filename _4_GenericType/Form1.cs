namespace _4_GenericType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            Islem<int> islem1 = new Islem<int>();
            Islem<double> islem2 = new Islem<double>();

            //Islem<string> islem3 = new Islem<string>();  // string tipi class olduðu için islem generiðinde kullanýlamaz...

            islem1.Ekle(20);
            islem1.Ekle(2000);
            // islem1.Ekle("aaaa"); islem1 instance int olduðu için string parametreyi kabul etmeyecektir...

            islem2.Ekle(1);
            islem2.Ekle(1.1);

        //Collections ve GenericCollections
        //Static yapýlar
        //Anonim Tipler ve Nullable tipler
        //Linq 

        }
    }
}