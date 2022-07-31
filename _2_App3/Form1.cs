namespace _2_App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sayi1, sayi2, sonuc;


        private void btnTopla_Click(object sender, EventArgs e)
        {
            //try-catch bloklar� => runtime'da olu�an hatalar� y�netmek i�in kullan�l�r. hata olas�l��� olacak komutlar try blo�una yaz�l�r. catch blo�u try'da olu�an hatay� yakalar buras� hatay� y�netti�imiz bloktur.

            // Exception => hatalar  hakk�nda bilgi veren genel s�n�ft�r..
            // FormatException => t�r d�n���m� format hatalar� hakk�nda bilgi verir.
            // OverflowException => t�r d�n���m� ta�ma hatalar� hakk�nda bilgi verir
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch (FormatException ex) // sadece format exceptinlar� yakala...
            {
                MessageBox.Show("Opsss. Bir hata olu�tu");
            }
            catch (OverflowException ex) // sadaece ta�ma hatalar� yakala
            {
                MessageBox.Show("Opssss. De�er �ok b�y�k veya �ok k���k");
            }
            //finally // hata olsun olmas�n en son �al��an blok
            //{
            //}

            sonuc = sayi1 + sayi2;
            // lblSonuc.Text = Convert.ToString(sonuc);
            lblSonuc.Text = sonuc.ToString();
        }


        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Opssss. Bir hata olu�tu");
            }
            sonuc = sayi1 - sayi2;
            lblSonuc.Text = sonuc.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opssss. Bir hata olu�tu");
            }
            sonuc = sayi1 / sayi2;
            lblSonuc.Text = sonuc.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opssss. Bir hata olu�tu");
            }

            sonuc = sayi1 * sayi2;
            lblSonuc.Text = sonuc.ToString();
        }
    }
}