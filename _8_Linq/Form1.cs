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
            // LINQ (Language Integrated Query) => Dile entegre sorgula veya Dil ile b�t�nle�ik sorgulama
            // Sorgulama dilleri veriler �zerinde i�lem (manip�lasyon) yapmam�z� sa�yalan dillerdir..
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


            // LINQ Sayesinde gereksiz d�ng� ve karar yap�lar�ndan kurluluturz. tamamen tek sat�rda query yazarak sonucu elde ederiz...
            List<int> teknums = (from a in nums // verileri a'ya ata
                                 where a % 2 == 1// filtre uygula
                                 select a).ToList(); // a'lar� se�

            List<int> kucuknums = (from a in nums where a < 0 select a).ToList();




        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        List<Ogrenci> ogrencis = new List<Ogrenci>();
        private void Form1_Load(object sender, EventArgs e) // formun y�klenme olay�. Form y�klenirken tetiklenir. genelde ba�lang� verileri burada set edilir...
        {
            // verileri haz�rla
            Ogrenci ogr = new Ogrenci();
            ogr.AdiSoyAdi = "Ziya Erdo�du";
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
            Ogrenci ogr3 = new Ogrenci { AdiSoyAdi = "�smail Aslan", Cinsyet = 'E', Vize = 80, Final = 40 };
            Ogrenci ogr4 = new Ogrenci { AdiSoyAdi = "K�bra Karaku�", Cinsyet = 'K', Vize = 30, Final = 90 };

            ogrencis.Add(ogr);
            ogrencis.Add(ogr1);
            ogrencis.Add(ogr2);
            ogrencis.Add(ogr3);
            ogrencis.Add(ogr4);
            ogrencis.Add(new Ogrenci { AdiSoyAdi = "B��ra Gen�", Cinsyet = 'K', Vize = 60, Final = 50 });
        }

        private void btnTumu_Click(object sender, EventArgs e)
        {
            // DataGridView dizi koleksion gibi yap�lar� sat�r ve s�tun �eklinde d�zenli olarak verileri g�sterir...
            //DataSource �zelli�i listelenecek veri kayna�� bekler. ogrencis veri kayna��n� gride source ediyoruz...
            dgwResult.DataSource = ogrencis;
        }

        private void btnBay_Click(object sender, EventArgs e)
        {
            // ko�ula uygun verileri tutmak i�in bir liste tan�mla
            // Normal;
            //List<Ogrenci> baylar = new List<Ogrenci>();
            //foreach (var item in ogrencis)
            //{
            //    if (item.Cinsyet == 'E')
            //    {
            //        baylar.Add(item); // ko�ula uygun item'i listeye ekle
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
            //float avg = sum / ogrencis.Count; // ortalamay� bul..

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
            // select ifadesi => sorguyadan ��kt� olarak �retilecek nesneleri ifade eder..

            // ogrencileri se�
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
            // adsoyadlar�n� se� 
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
            //Ogrencilerimin ad�soyad� ve ortalamar�n� gridde g�sterelim...
            //List<OgrenciDTO> dtoList = new List<OgrenciDTO>();
            //foreach (var item in ogrencis)
            //{
            //    OgrenciDTO dot = new OgrenciDTO();
            //    dot.AdiSoyAdi = item.AdiSoyAdi;
            //    dot.Ortalama = item.Ortalama;

            //    dtoList.Add(dot);
            //}

            //dgwResult.DataSource = dtoList;

            // select new ifadesi ile new'den sonra tip belirtilmezse result anonymous d�necektir...

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
            // Lambda ifadeleri : girdi parametrelerden sonu� �retmemizi sa�layan isimsiz fonksiyonlar diyebiliriz...
            // girdiParametresi => sonuc�fadesi
            // c => c + c (c parametresini c ile topla)
            // c => c + 10 (c parametresini 10 ile topla)
            // x => x > 5  (x �yle bir x'ki 5 den b�y�se sonu� true)

            // giri� parametresi int, d�n��� int lambda ifadesi... // c => 
            Func<int, int> ifade1 = c => c + c;
            int result = ifade1(4);
            MessageBox.Show(result.ToString());

            Func<int, bool> ifade2 = c => c == 10;
            bool result2 = ifade2(1);
            MessageBox.Show(result2.ToString());

            Func<char, bool> ifade3 = c => c == 'K';// c =='k' ya idade 2 true d�ns�n...
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
            // Extension metotlar => instance �zerinden �a�r�lan c# metotlar�d�r..
            // L�nq sorugular�na alternatif sorgular (sorguyu k�saltmak) yazmak i�in kullan�l�r...


            // Cinsiyeti E olan ��rencileri geri d�n...

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

            // e�er whereden sonra select  metodu kullan�lmazsa where d�n�� olarak hangi liste �zerinden �a�r�l�rsa o tipte d�n�� yapacakt�r..


            var ortalama1 = ogrencis.Average(c => c.Ortalama);
            var gecenOgrenciler = ogrencis.Where(c => c.Ortalama > ortalama1).ToList();
            dgwResult.DataSource = gecenOgrenciler;


        }
    }
}