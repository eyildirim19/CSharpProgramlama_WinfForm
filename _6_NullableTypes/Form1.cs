namespace _6_NullableTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Null => deðeri olmayan yapýdýr...
            //Stok = 0    => stokta bitti
            //Stok = null => stokta yok...

            // value typelera null atamak için tipin nullable olmasý gerekiyor. Bu durumda eðer bir value type nullable deðilse non-nullable'dýr..

            int stok = 0;
            string name = null;
            // int stock = null; // int bir value tpye'týr. sadece deðer atanabilir...Bu bütün value typler için geçerlidir...

            Nullable<int> stock = null; // intimiz nullable'dýr

            // stock = 0; // nullable type deðer atamasý yapýlabilir. Nullable sadece tipin null deðer kabul ettiðini belirtir...

            if (stock == null)
                MessageBox.Show("Stokta yok");
            else
                MessageBox.Show("Stok bitmiþ");

            // veya

            if (!stock.HasValue)
                MessageBox.Show("Stokta yok");
            else
                MessageBox.Show("Stok bitmiþ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Nullable<int> stock = null;
            // diðer yoluý
            int? stock = null;
            if (stock == null)
                MessageBox.Show("Stokta yok");
            else
                MessageBox.Show("Stok bitmiþ");

            // Value => nullable typelerde nullable tyepin deðeri deðerini verir..

            // ileride veritabaný uygulamarlýnda sýk kullanýlýr...

            // stock = 0;
            // bu sayede gereksiz convert veya casting iþlemi yapýlmýyor
            if (stock.HasValue) // stock'un deðeri varsa 
            {
                int deger = stock.Value; // deðeri deger deðiþkenine ata...
            }
        }
    }
}