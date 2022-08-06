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
            // Null => de�eri olmayan yap�d�r...
            //Stok = 0    => stokta bitti
            //Stok = null => stokta yok...

            // value typelera null atamak i�in tipin nullable olmas� gerekiyor. Bu durumda e�er bir value type nullable de�ilse non-nullable'd�r..

            int stok = 0;
            string name = null;
            // int stock = null; // int bir value tpye't�r. sadece de�er atanabilir...Bu b�t�n value typler i�in ge�erlidir...

            Nullable<int> stock = null; // intimiz nullable'd�r

            // stock = 0; // nullable type de�er atamas� yap�labilir. Nullable sadece tipin null de�er kabul etti�ini belirtir...

            if (stock == null)
                MessageBox.Show("Stokta yok");
            else
                MessageBox.Show("Stok bitmi�");

            // veya

            if (!stock.HasValue)
                MessageBox.Show("Stokta yok");
            else
                MessageBox.Show("Stok bitmi�");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Nullable<int> stock = null;
            // di�er yolu�
            int? stock = null;
            if (stock == null)
                MessageBox.Show("Stokta yok");
            else
                MessageBox.Show("Stok bitmi�");

            // Value => nullable typelerde nullable tyepin de�eri de�erini verir..

            // ileride veritaban� uygulamarl�nda s�k kullan�l�r...

            // stock = 0;
            // bu sayede gereksiz convert veya casting i�lemi yap�lm�yor
            if (stock.HasValue) // stock'un de�eri varsa 
            {
                int deger = stock.Value; // de�eri deger de�i�kenine ata...
            }
        }
    }
}