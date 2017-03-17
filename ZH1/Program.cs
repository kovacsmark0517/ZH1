using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1
{
    class Program
    {
        static void Main(string[] args)
        {
            CsacskaNyúl csacskanyúl = new CsacskaNyúl();
            ZsigaCsiga zsigacsiga = new ZsigaCsiga();
            TréMedve trémedve = new TréMedve();
            Barna_a_medve barnamedve = new Barna_a_medve();
            Hóvirág hóvirág = new Hóvirág();
            Para_a_róka paraaróka = new Para_a_róka();
            Másnapos_a_szöcske másnaposszöcske = new Másnapos_a_szöcske();
            Bolha bolha = new Bolha();
            Verseny verseny = new ZH1.Verseny();


            while (true)
            {
                csacskanyúl.Lép(35);
                zsigacsiga.Lép(5);
                trémedve.Lép(25);
                barnamedve.Lép(20);
                hóvirág.Lép(0);
                paraaróka.Lép(30);
                másnaposszöcske.Lép(15);
                bolha.Lép(barnamedve.Lépéshossza);
                verseny.idő_múlás();

                switch (verseny.körökSzáma)
                { 
                    case 10:
                        break;
                    case 20:
                        break;
                    case 30:
                        break;
                    case 40:
                        break;
                    case 50:
                        break;
                    case 60:
                        break;
                    case 70:
                        break;
                    case 80:
                        break;
                    case 90:
                        break;
                    case 100:
                        break;
                }
                if (verseny.körökSzáma > 99)
                    break;


            }//while true vége

        }
    }
}
