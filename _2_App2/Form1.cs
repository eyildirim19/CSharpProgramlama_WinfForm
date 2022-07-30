namespace _2_App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Patron");
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            lblBilgi.Text = txtBilgi.Text;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            // textbox'a 100 karaktere kadar olan kýsým label'ê yazdýrýlsýn...
            if (txtValue.Text.Length < 100)
            {
                lblValue.Text = txtValue.Text;
            }


            // kalan karakter 0  0 olduðunda -1'e düþmesin.."0 karakter kaldý" yazsýn

            if (txtValue.Text.Length <= 100)
            {
                lblCounter.Text = $"{100 - txtValue.Text.Length} karakter kaldý";
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // this=> o instancý anlamýna gelir. (bulunulan form anlamýna gelir)
            DialogResult result = MessageBox.Show("Çýkmak istediðine eminmisin?", "UYARI", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}