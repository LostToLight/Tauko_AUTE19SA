using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tauko_AUTE19SA
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2016, 12, 31, 5, 10, 20); // 15min coffee break
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 25, 20);

            DateTime dt3 = new DateTime(2016, 12, 31, 5, 10, 20); // 30min lunch break
            DateTime dt4 = new DateTime(2016, 12, 31, 5, 40, 20);

            Kahvitauko kt1 = new Kahvitauko();
            kt1.aseta_alkuaika(dt); //parametriksi DateTime luokan olio
            kt1.aseta_loppuaika(dt2);

            Ruokatauko rt = new Ruokatauko();
            rt.aseta_alkuaika(dt3);
            rt.aseta_loppuaika(dt4);

            Kahvitauko kt2 = new Kahvitauko();
            kt2.aseta_alkuaika(dt);
            kt2.aseta_loppuaika(dt2);

            int total = kt1.Tauonpituus() + kt2.Tauonpituus() + rt.Tauonpituus();
            Console.WriteLine("Total time spend on break today was: " + total + " minutes");

            Console.ReadKey();
        }
    }
}
