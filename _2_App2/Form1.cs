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
            // textbox'a 100 karaktere kadar olan k�s�m label'� yazd�r�ls�n...
            if (txtValue.Text.Length < 100)
            {
                lblValue.Text = txtValue.Text;
            }


            // kalan karakter 0  0 oldu�unda -1'e d��mesin.."0 karakter kald�" yazs�n

            if (txtValue.Text.Length <= 100)
            {
                lblCounter.Text = $"{100 - txtValue.Text.Length} karakter kald�";
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // this=> o instanc� anlam�na gelir. (bulunulan form anlam�na gelir)
            DialogResult result = MessageBox.Show("��kmak istedi�ine eminmisin?", "UYARI", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}