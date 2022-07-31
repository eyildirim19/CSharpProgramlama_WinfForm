namespace _2_App4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // EventArgs => Eventi temsil eder.. 
        // Sender   => Eventi tetikleyen nesnesi temsil eder..
        
        private void Islem_Click(object sender, EventArgs e)
        {
            // ilk de�er fieldlarda atamak zorunlu� de�ilken de�i�kenlerde zorunludur..
            int sayi1 = 0, sayi2 = 0, sonuc = 0;
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi1 = Convert.ToInt32(txtSayi2.Text);
            }
            catch
            {
                MessageBox.Show("L�tfen girdi�iniz de�erleri kontrol ediniz");
            }
            //C# dilinde object b�t�n tiplerin atas�d�r. yani b�t�n tipler object s�n�f�ndan t�retilmi�tir...
            // object b�t�n tipplerin referans�n� tutabilir..
            // btn nesnesi Button tipindedir ve sender ile gelen referans� tutmas� i�in tan�mlanm��t�r....
            // objectten ba�ka bir tipe d�n���me unboxing denir..
            Button btn = (Button)sender;
            switch (btn.Tag)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
            }
            lblSonuc.Text = sonuc.ToString();
        }
    }
}