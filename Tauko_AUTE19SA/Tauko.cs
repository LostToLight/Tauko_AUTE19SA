using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tauko_AUTE19SA
{
    public class Tauko
    {
        private DateTime alkuaika;
        private DateTime loppuaika;
        private TimeSpan kokonaispituus;
        int t = 0;

        public void aseta_alkuaika(DateTime l)
        {
            alkuaika = l;
        }
        public void aseta_loppuaika(DateTime l)
        {
            loppuaika = l;
        }
        public TimeSpan Kokonaispituus()
        {
            kokonaispituus = loppuaika - alkuaika;
            return kokonaispituus;
        }
    }
}