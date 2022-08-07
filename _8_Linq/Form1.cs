namespace _8_Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // LINQ (Language Integrated Query) => Dile entegre sorgula veya Dil ile bütünleþik sorgulama
            // Sorgulama dilleri veriler üzerinde iþlem (manipülasyon) yapmamýzý saðyalan dillerdir..
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(10);
            nums.Add(4);
            nums.Add(8);
            nums.Add(16);
            nums.Add(13);

            List<int> tekler = new List<int>();
            foreach (int i in nums)
            {
                if (i % 2 == 1)
                {
                    tekler.Add(i);
                }
            }
            // tekleri bulduk...
            List<int> kucukler = new List<int>();
            foreach (var i in nums)
            {
                if (i > 10)
                {
                    kucukler.Add(i);
                }
            }


            // LINQ Sayesinde gereksiz döngü ve karar yapýlarýndan kurluluturz. tamamen tek satýrda query yazarak sonucu elde ederiz...
            List<int> teknums = (from a in nums // verileri a'ya ata
                                 where a % 2 == 1// filtre uygula
                                 select a).ToList(); // a'larý seç

            List<int> kucuknums = (from a in nums where a < 0 select a).ToList();




        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        List<Ogrenci> ogrencis = new List<Ogrenci>();
        private void Form1_Load(object sender, EventArgs e) // formun yüklenme olayý. Form yüklenirken tetiklenir. genelde baþlangý verileri burada set edilir...
        {
            // verileri hazýrla
            Ogrenci ogr = new Ogrenci();
            ogr.AdiSoyAdi = "Ziya Erdoðdu";
            ogr.Cinsyet = 'E';
            ogr.Vize = 40;
            ogr.Final = 60;

            //  Object Initializer
            Ogrenci ogr1 = new Ogrenci
            {
                AdiSoyAdi = "Celalettin Mikdan",
                Cinsyet = 'E',
                Vize = 50,
                Final = 70
            };

            Ogrenci ogr2 = new Ogrenci { AdiSoyAdi = "Onur Derman", Cinsyet = 'E', Vize = 20, Final = 100 };
            Ogrenci ogr3 = new Ogrenci { AdiSoyAdi = "Ýsmail Aslan", Cinsyet = 'E', Vize = 80, Final = 40 };
            Ogrenci ogr4 = new Ogrenci { AdiSoyAdi = "Kübra Karakuþ", Cinsyet = 'K', Vize = 30, Final = 90 };

            ogrencis.Add(ogr);
            ogrencis.Add(ogr1);
            ogrencis.Add(ogr2);
            ogrencis.Add(ogr3);
            ogrencis.Add(ogr4);
            ogrencis.Add(new Ogrenci { AdiSoyAdi = "Büþra Genç", Cinsyet = 'K', Vize = 60, Final = 50 });
        }

        private void btnTumu_Click(object sender, EventArgs e)
        {
            // DataGridView dizi koleksion gibi yapýlarý satýr ve sütun þeklinde düzenli olarak verileri gösterir...
            //DataSource özelliði listelenecek veri kaynaðý bekler. ogrencis veri kaynaðýný gride source ediyoruz...
            dgwResult.DataSource = ogrencis;
        }

        private void btnBay_Click(object sender, EventArgs e)
        {
            // koþula uygun verileri tutmak için bir liste tanýmla
            // Normal;
            //List<Ogrenci> baylar = new List<Ogrenci>();
            //foreach (var item in ogrencis)
            //{
            //    if (item.Cinsyet == 'E')
            //    {
            //        baylar.Add(item); // koþula uygun item'i listeye ekle
            //    }
            //}
            //dgwResult.DataSource = baylar;

            // Linq;
            //dgwResult.DataSource = (from o in ogrencis
            //          where o.Cinsyet == 'E'
            //          select o).ToList();

            List<Ogrenci> bayOgrencis = (from o in ogrencis
                                         where o.Cinsyet == 'E'
                                         select o).ToList();

            dgwResult.DataSource = bayOgrencis;
        }

        private void btnBayan_Click(object sender, EventArgs e)
        {
            dgwResult.DataSource = (from o in ogrencis
                                    where o.Cinsyet == 'K'
                                    select o).ToList();
        }

        private void btnGecen_Click(object sender, EventArgs e)
        {
            //float sum = 0;
            //foreach (var item in ogrencis)
            //{
            //    sum += item.Ortalama;
            //}
            //float avg = sum / ogrencis.Count; // ortalamayý bul..

            //List<Ogrenci> gecenler = new List<Ogrenci>();
            //foreach (var item in ogrencis)
            //{
            //    if (item.Ortalama >= avg)
            //    {
            //        gecenler.Add(item);
            //    }
            //}
            //dgwResult.DataSource = gecenler;

            // linq;
            //List<float> ortalamalari = (from o in ogrencis
            //                            select o.Ortalama).ToList();
            //float avg1 = ortalamalari.Average();

            float avg2 = (from o in ogrencis
                          select o.Ortalama).Average();
            List<Ogrenci> gecenOgrencis = (from a in ogrencis
                                           where a.Ortalama > avg2
                                           select a).ToList();

            dgwResult.DataSource = gecenOgrencis;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // select ifadesi => sorguyadan çýktý olarak üretilecek nesneleri ifade eder..

            // ogrencileri seç
            List<Ogrenci> ogrenciler = (from a in ogrencis
                                        where a.Cinsyet == 'K'
                                        select a).ToList();

            foreach (var item in ogrenciler)
            {
                MessageBox.Show(item.AdiSoyAdi + item.Vize + item.Final);
            }

            // normal yol

            List<string> names = new List<string>();
            foreach (var item in ogrencis)
            {
                names.Add(item.AdiSoyAdi);
            }


            // linq
            // adsoyadlarýný seç 
            List<string> isimleri = (from a in ogrencis
                                     select a.AdiSoyAdi).ToList();

            foreach (var item in isimleri)
            {
                MessageBox.Show(item);
            }


            List<float> ortamalari = (from ogr in ogrencis
                                      select ogr.Ortalama).ToList();

            foreach (var item in ortamalari)
            {
                MessageBox.Show(item.ToString());
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ogrencilerimin adýsoyadý ve ortalamarýný gridde gösterelim...
            //List<OgrenciDTO> dtoList = new List<OgrenciDTO>();
            //foreach (var item in ogrencis)
            //{
            //    OgrenciDTO dot = new OgrenciDTO();
            //    dot.AdiSoyAdi = item.AdiSoyAdi;
            //    dot.Ortalama = item.Ortalama;

            //    dtoList.Add(dot);
            //}

            //dgwResult.DataSource = dtoList;

            // select new ifadesi ile new'den sonra tip belirtilmezse result anonymous dönecektir...

            // Anonim result
            var ogrencilerim = (from a in ogrencis
                                select new
                                {
                                    a.AdiSoyAdi,
                                    a.Ortalama
                                }).ToList();

            dgwResult.DataSource = ogrencilerim;
        }

        private void btnGecenBayan_Click(object sender, EventArgs e)
        {
            var ortalama = (from a in ogrencis
                            select a.Ortalama).Average();

            var gecenbayanogrencis = (from a in ogrencis
                                      where a.Ortalama >= ortalama && a.Cinsyet == 'K'
                                      select a).ToList();

            dgwResult.DataSource = gecenbayanogrencis;
        }

        private void btnGecenBayAnonim_Click(object sender, EventArgs e)
        {
            var ortalama = (from a in ogrencis
                            select a.Ortalama).Average();

            var anonimList = (from a in ogrencis
                              where a.Ortalama >= ortalama && a.Cinsyet == 'E'
                              select new
                              {
                                  a.AdiSoyAdi,
                                  a.Vize,
                                  a.Final
                              }).ToList();

            dgwResult.DataSource = anonimList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Lambda ifadeleri : girdi parametrelerden sonuç üretmemizi saðlayan isimsiz fonksiyonlar diyebiliriz...
            // girdiParametresi => sonucÝfadesi
            // c => c + c (c parametresini c ile topla)
            // c => c + 10 (c parametresini 10 ile topla)
            // x => x > 5  (x öyle bir x'ki 5 den büyüse sonuç true)

            // giriþ parametresi int, dönüþü int lambda ifadesi... // c => 
            Func<int, int> ifade1 = c => c + c;
            int result = ifade1(4);
            MessageBox.Show(result.ToString());

            Func<int, bool> ifade2 = c => c == 10;
            bool result2 = ifade2(1);
            MessageBox.Show(result2.ToString());

            Func<char, bool> ifade3 = c => c == 'K';// c =='k' ya idade 2 true dönsün...
            foreach (var item in ogrencis)
            {
                if (ifade3(item.Cinsyet))
                {
                    MessageBox.Show(item.AdiSoyAdi);
                }
            }

            var resultbayanlar = (from a in ogrencis
                                  where ifade3(a.Cinsyet)
                                  select a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Extension metotlar => instance üzerinden çaðrýlan c# metotlarýdýr..
            // LÝnq sorugularýna alternatif sorgular (sorguyu kýsaltmak) yazmak için kullanýlýr...


            // Cinsiyeti E olan öðrencileri geri dön...

            List<Ogrenci> bayogrencis = ogrencis.Where(c => c.Cinsyet == 'E').ToList();
            dgwResult.DataSource = bayogrencis;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            // linq ile
            //var ortalama = (from a in ogrencis
            //                select a.Ortalama).Average();
            //var anonimList = (from a in ogrencis
            //                  where a.Ortalama >= ortalama && a.Cinsyet == 'E'
            //                  select new
            //                  {
            //                      a.AdiSoyAdi,
            //                      a.Vize,
            //                      a.Final
            //                  }).ToList();

            //dgwResult.DataSource = anonimList;

            var ortalama1 = ogrencis.Average(c => c.Ortalama);
            var anonimList1 = ogrencis.Where(c => c.Ortalama > ortalama1).Select(c => new
            {
                c.AdiSoyAdi,
                c.Vize,
                c.Final
            }).ToList();

            dgwResult.DataSource = anonimList1;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            // eðer whereden sonra select  metodu kullanýlmazsa where dönüþ olarak hangi liste üzerinden çaðrýlýrsa o tipte dönüþ yapacaktýr..


            var ortalama1 = ogrencis.Average(c => c.Ortalama);
            var gecenOgrenciler = ogrencis.Where(c => c.Ortalama > ortalama1).ToList();
            dgwResult.DataSource = gecenOgrenciler;


        }
    }
}