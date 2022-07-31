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
            // Kullanýcýnýn 3 hakký olsun. eðer 3 kez bilgiler hatalý girilirse hesabýnýz bloke oldu lütfen bizimle iletiþime geçiniz...
            if (counter == 3)
            {
                MessageBox.Show("Hesabýnýz askýya alýndý. Lütfen bizimle iletiþime geçiniz");
                return;
            }

            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "123")
            {
                frmAna frm = new frmAna();
                frm.Show(); // formu göster...
                //frm.ShowDialog();
                this.Hide(); // giris(form1) formunu gizle... 
                //this.Close(); // giris(form1) formunu kapat... ancak form1 mainform olduðu için form1 kapatýldýðýnda uygulama kapanacaktýr..
            }
            else
            {
                counter++;
                MessageBox.Show($"Hatalý kullanýcý adý veya þifre girdiniz. Lütfen tekrar deneyiniz...Kalan hakkýnýz = {3 - counter}");
            }
        }
    }
}