using System;
using System.Collections.Generic;

namespace bunbarlang
{
    internal class NagyobbLap
    {
        private int bet;

        public NagyobbLap(int bet)
        {
            this.bet = 0;

            Pakli pakli = new Pakli();

            Kartya jatekos = pakli.Huz();
            Kartya gep = pakli.Huz();

            Console.Clear();
            Console.WriteLine("Te húztad:");
            Console.WriteLine(jatekos);

            Console.WriteLine("Gép húzta:");
            Console.WriteLine(gep);

            if (jatekos.Ertek() > gep.Ertek())
            {
                Console.WriteLine("Nyertél!");
                this.bet = bet * 2;
            }
            else if (jatekos.Ertek() < gep.Ertek())
            {
                Console.WriteLine("Vesztettél!");
                this.bet = 0;
            }
            else
            {
                Console.WriteLine("Döntetlen!");
                this.bet = bet; 
            }

            Console.ReadLine();
        }

        public int Bet { get => bet; }
    }
}
