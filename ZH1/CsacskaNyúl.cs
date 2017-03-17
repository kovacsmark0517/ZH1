using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1
{
    class CsacskaNyúl
    {
        private int Sorszám = 1;
        private int LépésekSzáma = 0;
        private int Sebesség = 100;
        private int Megtettút = 0;
        private int Lépéshossza;

        public CsacskaNyúl()
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
