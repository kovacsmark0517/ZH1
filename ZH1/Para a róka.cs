using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1
{
    class Para_a_róka
    {
        private int Sorszám = 6;
        private int LépésekSzáma = 0;
        private int Sebesség = 100;
        private int Megtettút = 0;
        private int Lépéshossza;

        public Para_a_róka()
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
