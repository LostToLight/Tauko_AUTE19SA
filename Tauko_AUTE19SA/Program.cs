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
            Kahvitauko kt1 = new Kahvitauko();
            kt1.aseta_alkuaika(//parametriksi DateTime luokan olio);
            kt1.aseta_loppuaika();
            Ruokatauko rt = new Ruokatauko();
            Kahvitauko kt2 = new Kahvitauko();

            Console.WriteLine("työpäivässä on taukoa yhteensä 60 minuuttia")
        }
    }
}
