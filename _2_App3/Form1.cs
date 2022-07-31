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
            //try-catch bloklarý => runtime'da oluþan hatalarý yönetmek için kullanýlýr. hata olasýlýðý olacak komutlar try bloðuna yazýlýr. catch bloðu try'da oluþan hatayý yakalar burasý hatayý yönettiðimiz bloktur.

            // Exception => hatalar  hakkýnda bilgi veren genel sýnýftýr..
            // FormatException => tür dönüþümü format hatalarý hakkýnda bilgi verir.
            // OverflowException => tür dönüþümü taþma hatalarý hakkýnda bilgi verir
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
            }
            catch (FormatException ex) // sadece format exceptinlarý yakala...
            {
                MessageBox.Show("Opsss. Bir hata oluþtu");
            }
            catch (OverflowException ex) // sadaece taþma hatalarý yakala
            {
                MessageBox.Show("Opssss. Deðer çok büyük veya çok küçük");
            }
            //finally // hata olsun olmasýn en son çalýþan blok
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
                MessageBox.Show("Opssss. Bir hata oluþtu");
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
                MessageBox.Show("Opssss. Bir hata oluþtu");
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
                MessageBox.Show("Opssss. Bir hata oluþtu");
            }

            sonuc = sayi1 * sayi2;
            lblSonuc.Text = sonuc.ToString();
        }
    }
}