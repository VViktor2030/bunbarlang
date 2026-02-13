using Bunbarlang;

namespace bunbarlang
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int penz = 1000;
			string valasz;
			int bet;
            Console.WriteLine("Mi a neved?");
			string nev = Console.ReadLine();
			do
			{

				Console.WriteLine("Mit akarsz játszani?");
				Console.WriteLine("1. Blackjack");
				Console.WriteLine("2. Nagyobb lap nyer");
				Console.WriteLine("k = kilépés");

				Console.WriteLine("Mit akarsz játszani? (1. Blackjack 2. Nagyobb Kártya 3. Pig Dice k = kilépés)");

				valasz = Console.ReadLine();
				switch (valasz)
				{
					case "1":
						do
						{
							Console.WriteLine($"Mennyit akarsz fogadni? {penz}Ft van nálad");
							bet = Convert.ToInt32(Console.ReadLine());
							if (bet > penz)
							{
								Console.WriteLine("Nincs annyi pénzed");
							}
							if (bet < 0)
							{
								Console.WriteLine("Nem lehet negatív mennyiséget fogadni");
							}
						} while (bet > penz || bet < 0);
						penz -= bet;
						penz += new Blackjack(bet).Bet;
						break;

					case "2":
                        do
                        {
                            Console.WriteLine($"Mennyit akarsz fogadni? {penz}Ft van nálad");
                            bet = Convert.ToInt32(Console.ReadLine());
                            if (bet > penz)
                            {
                                Console.WriteLine("Nincs annyi pénzed");
                            }
                            if (bet < 0)
                            {
                                Console.WriteLine("Nem lehet negatív mennyiséget fogadni");
                            }
                        } while (bet > penz || bet < 0);

                        penz -= bet;
                        penz += new NagyobbLap(bet).Bet;
                        break;	

					case "3":
						PigDiceGame p = new PigDiceGame();
						Player jatekos = new Player(nev);
						p.jatekos_kor(jatekos);
						break;
				}


			} while (valasz != "k");
			Console.WriteLine($"Végül {penz}Ft-al végeztél");

		}
	}
}