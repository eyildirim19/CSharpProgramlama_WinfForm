namespace _2_App
{
    public partial class Form1 : Form
    {
        // Click bir control eventýdýr. Event denilen þey controllerin davranýþlarýný ifade eden yapýdýr. Click, Hover,Load vb eventler controllerin çeþitleri davranýþlarýný ifade ederler. eventler metotlarý iþaret ederler. Yani click eventýnda bir metot iþaret edilir ve event tetiklendiðinde o metodu tetikler ve programýn o bölümü çalýþýr....
        public Form1() // constructor (yapýcý metot)
        {
            InitializeComponent();
        }

        // class seviyesi tanýmlý deðikenlere field denir....

        private byte sayac = 0; // SAYAC ÖMRÜ form1 nesnesi ömrü kadar..

        private void btnTikla_Click(object sender, EventArgs e)
        {
            sayac++;
            btnTikla.Text = $"Týkladýn {sayac}"; // Týkladýn 1
        }
        // field, property,metod
        private int counter = 0;
        private bool durum = true;
        public void Arttir(object sender, EventArgs e)
        {
            // 10 kadar arttýrsýn. 10 olduðunda 0'a kadar azaltsýn 0. 0lþduðunda tekrar 10'a kadar arttýrsýn..
            if (durum == true) // eðer if koþulunda koþullu kod 1. satýr ise scope açmaya gerek yok...
                counter++;
            else
                counter--;

            if (counter == 10)
                durum = false;

            if (counter == 0)
                durum = true;
            //if (btnArttir.Text == "Arttýr")
            //    counter++;
            //else
            //    counter--;
            //if (counter == 10)
            //    btnArttir.Text = "Azalt";
            //else if (counter == 0)
            //    btnArttir.Text = "Arttýr";
            ////lblCounter.Text = Convert.ToString(counter); // 1. yol           
            lblCounter.Text = counter.ToString(); // 2. yol
        }
    }
}