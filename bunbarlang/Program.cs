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
				Console.WriteLine("Mit akarsz játszani? (1. Blackjack stbstbstbstb k = kilépés)");
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
						} while (bet > penz);
						penz -= bet;
						penz += new Blackjack(bet).Bet;
						break;
				}


			} while (valasz != "k");


		}
	}
}