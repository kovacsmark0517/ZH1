using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1
{
    class Másnapos_a_szöcske
    {
        private int Sorszám = 7;
        private int LépésekSzáma = 0;
        private int Sebesség = 100;
        private int Megtettút = 0;
        private int Lépéshossza;

        public Másnapos_a_szöcske()
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
