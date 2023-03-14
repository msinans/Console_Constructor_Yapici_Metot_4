using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Yapici_Metot_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            kml.AD = "ALİ";
            kml.SOYAD = "ömercikoğlu";
            kml.CINSIYET = 'E'; // Sınıf içerisinde ilk değer ataması olsa da artık bunu geçerli kabul ediyor
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);
            Console.WriteLine(kml.SEHİR);

            Console.Read();
        }
    }
}
