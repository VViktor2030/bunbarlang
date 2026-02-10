using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunbarlang
{
	internal class Pakli
	{
		private List<Kartya> kartyak = new List<Kartya>();

		public Pakli()
		{
			this.Kartyak = new List<Kartya>();
			string szam;
			for (int i = 0; i < 13; i++)
			{
				for (int j = 0; j <= 3; j++)

				{
					switch (i)
					{
						case 0:
							szam = "A";
							break;
						case 10:
							szam = "J";
							break;
						case 11:
							szam = "Q";
							break;
						case 12:
							szam = "K";
							break;
						default:
							szam = $"{i + 1}";
							break;
					}
					Kartyak.Add(new Kartya((Kartya.Szinek)j, szam));
				}
			}


		}

		internal List<Kartya> Kartyak { get => kartyak; set => kartyak = value; }


		public Kartya Huz()
		{
			Random rnd = new Random();
			Kartya huzott = kartyak[rnd.Next(0, kartyak.Count - 1)];
			kartyak.Remove(huzott);
			return huzott;
		}



	}
}