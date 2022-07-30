namespace _2_App
{
    public partial class Form1 : Form
    {
        // Click bir control event�d�r. Event denilen �ey controllerin davran��lar�n� ifade eden yap�d�r. Click, Hover,Load vb eventler controllerin �e�itleri davran��lar�n� ifade ederler. eventler metotlar� i�aret ederler. Yani click event�nda bir metot i�aret edilir ve event tetiklendi�inde o metodu tetikler ve program�n o b�l�m� �al���r....
        public Form1() // constructor (yap�c� metot)
        {
            InitializeComponent();
        }

        // class seviyesi tan�ml� de�ikenlere field denir....

        private byte sayac = 0; // SAYAC �MR� form1 nesnesi �mr� kadar..

        private void btnTikla_Click(object sender, EventArgs e)
        {
            sayac++;
            btnTikla.Text = $"T�klad�n {sayac}"; // T�klad�n 1
        }
        // field, property,metod
        private int counter = 0;
        private bool durum = true;
        public void Arttir(object sender, EventArgs e)
        {
            // 10 kadar artt�rs�n. 10 oldu�unda 0'a kadar azalts�n 0. 0l�du�unda tekrar 10'a kadar artt�rs�n..
            if (durum == true) // e�er if ko�ulunda ko�ullu kod 1. sat�r ise scope a�maya gerek yok...
                counter++;
            else
                counter--;

            if (counter == 10)
                durum = false;

            if (counter == 0)
                durum = true;
            //if (btnArttir.Text == "Artt�r")
            //    counter++;
            //else
            //    counter--;
            //if (counter == 10)
            //    btnArttir.Text = "Azalt";
            //else if (counter == 0)
            //    btnArttir.Text = "Artt�r";
            ////lblCounter.Text = Convert.ToString(counter); // 1. yol           
            lblCounter.Text = counter.ToString(); // 2. yol
        }
    }
}