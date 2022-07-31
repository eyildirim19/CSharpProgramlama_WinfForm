using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PartialClass
{
    // partial => aynı isimde birden fazla class geliştirmemiz sağlayan yapıdır. partiallar ayrı yazılır beraber derlenirler. derlenme aşamında iki farklı yerde geliştirimiş class birleştirilerek kullanılabilir...
    public partial class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
    }
}