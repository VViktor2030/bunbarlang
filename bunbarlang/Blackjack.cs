using System.Net.WebSockets;
using System.Numerics;
using System.Transactions;

namespace bunbarlang
{
	internal class Blackjack
	{
		private int bet;
		public Blackjack(int bet)
		{
			bool push = false;
			do
			{
				push = false;

				Pakli p = new Pakli();
				static int Sum(List<Kartya> lk)
				{
					int szum = 0;
					foreach (var i in lk)
					{
						switch (i.Szam)
						{
							case "A":
								szum += 11;
								break;
							case "J":
							case "Q":
							case "K":
								szum += 10;
								break;
							default:
								szum += Convert.ToInt32(i.Szam);
								break;
						}
					}
					if (szum > 21)
					{
						foreach(var i in lk)
						{
							if (i.Szam == "A" && szum > 21)
							{
								szum -= 10;
							}
						}
					}
					return szum;
				}


				bool vege = false;
				bool huz = true;
				int i;
				List<Kartya> JatekosKartyak = new List<Kartya>();
				List<Kartya> DealerKartyak = new List<Kartya>();

				JatekosKartyak.Add(p.Huz());
				JatekosKartyak.Add(p.Huz());
				DealerKartyak.Add(p.Huz());


				while (!vege)
				{
					Console.Clear();

					int sumJatekos = Sum(JatekosKartyak);
					int sumDealer = Sum(DealerKartyak);
					Console.WriteLine("Játékos");

					i = JatekosKartyak.Count() - 1;
					foreach (var k in JatekosKartyak)
					{
						Console.CursorTop = 0;
						k.Offset = i;
						Console.WriteLine(k);
						i--;

					}
					Console.WriteLine();
					Console.WriteLine($"Összesen: {sumJatekos}");
					Console.WriteLine();
					Console.WriteLine("Dealer");
					i = DealerKartyak.Count() - 1;
					int cursorTop = Console.CursorTop;
					foreach (var k in DealerKartyak)
					{
						k.Offset = i;
						Console.WriteLine(k);
						Console.CursorTop = cursorTop;
						i--;
					}
					Console.WriteLine();

					Console.CursorTop += cursorTop;
					Console.WriteLine($"Összesen: {sumDealer}");

					if ((sumJatekos <= 21 && sumDealer <= 21) && (sumDealer < sumJatekos || huz))
					{

						if (huz)
						{


							Console.WriteLine("Akarsz még húzni? (i / n)");
							switch (Console.ReadLine())
							{
								case "i":
									JatekosKartyak.Add(p.Huz());

									break;

								default:
									huz = false;
									break;

							}
						}

						sumJatekos = Sum(JatekosKartyak);
						sumDealer = Sum(DealerKartyak);

						if (sumDealer < sumJatekos)
						{
							DealerKartyak.Add(p.Huz());

						}


					}
					else
					{
						vege = true;
						if (sumJatekos > sumDealer && sumJatekos <= 21 || sumDealer > 21 && sumJatekos <= 21)
						{
							Console.WriteLine("nyer");
							Bet = bet * 2;
						}
						else if (sumDealer > sumJatekos || (sumJatekos > 21))
						{
							Console.WriteLine("veszít");
							Bet = 0;
						}
						else
						{
							Console.WriteLine("Döntetlen, mégegyszer");
							push = true;
						}

						Console.ReadLine();

					}
				}


			} while (push);
		}

		public int Bet { get => bet; set => bet = value; }
	}
}