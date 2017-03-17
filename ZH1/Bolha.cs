using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Bolha
    {
        private int Sorszám = 8;
        private int LépésekSzáma = 0;
        private int Sebesség = 100;
        private int Megtettút = 0;

        public Bolha()
        {

        }

        public void Lép(int lépéshossza)
        {
            Megtettút += lépéshossza;
            LépésekSzáma++;
        }
    }
}