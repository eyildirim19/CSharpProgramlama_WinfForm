namespace _2_App5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullan�c�n�n 3 hakk� olsun. e�er 3 kez bilgiler hatal� girilirse hesab�n�z bloke oldu l�tfen bizimle ileti�ime ge�iniz...
            if (counter == 3)
            {
                MessageBox.Show("Hesab�n�z ask�ya al�nd�. L�tfen bizimle ileti�ime ge�iniz");
                return;
            }

            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "123")
            {
                frmAna frm = new frmAna();
                frm.Show(); // formu g�ster...
                //frm.ShowDialog();
                this.Hide(); // giris(form1) formunu gizle... 
                //this.Close(); // giris(form1) formunu kapat... ancak form1 mainform oldu�u i�in form1 kapat�ld���nda uygulama kapanacakt�r..
            }
            else
            {
                counter++;
                MessageBox.Show($"Hatal� kullan�c� ad� veya �ifre girdiniz. L�tfen tekrar deneyiniz...Kalan hakk�n�z = {3 - counter}");
            }
        }
    }
}