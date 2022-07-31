using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_GenericType
{
    // <T> generic typeleri ifade eder.T burada tipi ifade eder.generic type kullanımında sınıf içerisindeki yapılar dinamik olacaktır. belirtiekn tiplere göre işlem yapmak istenilen bir sınıf oluşturulur. bu sınıf içerisinde T tipinde üyeler tanımlanarak yapı dinamik hale getirilir..

    // where T : struct => T sadece struct tipinden türeyen tipler olabilir...
    public class Islem<T> where T : struct
    {
        public T Value1 { get; set; }
        public T Value2 { get; set; }

        public void Ekle(T deger)
        {
            // burada T'nin değeri dosyaya yazılır..
        }
    }
}
