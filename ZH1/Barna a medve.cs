using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1
{
    class Barna_a_medve
    {
        private int Sorszám = 4;
        private int LépésekSzáma = 0;
        private int Sebesség = 100;
        private int Megtettút = 0;
        private int _Lépéshossza { get { return Lépéshossza; } set { Lépéshossza = value; } }


        public int Lépéshossza
        { get { return _Lépéshossza; } set { _Lépéshossza = value; } }

        public Barna_a_medve()
        {

        }
        public void Lép(int lépéshossza)
        {
            Lépéshossza = lépéshossza;
            Megtettút += lépéshossza;
            LépésekSzáma++;
        }
    }
}
