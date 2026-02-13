using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bunbarlang
{
	internal class Kartya
	{
		public int Ertek()
{
    switch (Szam)
    {
        case "A": return 14;
        case "K": return 13;
        case "Q": return 12;
        case "J": return 11;
        default: return int.Parse(Szam);
    }
}



		private string szam;
		private int offset;
		public enum Szinek
		{
			Tref,
			Pikk,
			Szív,
			Káró
		}
		private Szinek Szin;
		public Random rnd = new Random();

		public string Szam { get => szam; set => szam = value; }
		public int Offset { get => offset; set => offset = value; }

		public string OffsetString = "";





		public Kartya(Szinek szin, string szam)
		{
			Szin = szin;
			Szam = szam;

		}

		public override string ToString()
		{
			OffsetString = "";
			string SzamSpace = "";
			for (int i = 0; i < Offset; i++)
			{
				OffsetString += "          ";
			}
			if (this.Szam != "10")
			{
				SzamSpace = "      ";
			}
			else
			{
				SzamSpace = "     ";
			}
			return $@"
{OffsetString}|-------|
{OffsetString}|{this.Szam}{SzamSpace}|
{OffsetString}|       |
{OffsetString}|       |
{OffsetString}|{this.Szin}   |
{OffsetString}|_______|";

			}

			

			
		}
	}
