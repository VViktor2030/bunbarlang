namespace bunbarlang
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int penz = 1000;
			string valasz;
			int bet;
			do
			{
				Console.WriteLine("Mit akarsz játszani? (1. Blackjack k = kilépés)");
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
				}


			} while (valasz != "k");
			Console.WriteLine($"Végül {penz}Ft-al végeztél");

		}
	}
}