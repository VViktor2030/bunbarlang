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
			for (int i = 0; i < Offset; i++)
			{
				OffsetString += "          ";
			}
			if (this.Szam != "10")
			{
			return $@"
{OffsetString}|-------|
{OffsetString}|{this.Szam}      |
{OffsetString}|       |
{OffsetString}|       |
{OffsetString}|{this.Szin}   |
{OffsetString}|_______|";

			}
			else
			{
				return $@"
{OffsetString}|-------|
{OffsetString}|{this.Szam}     |
{OffsetString}|       |
{OffsetString}|       |
{OffsetString}|{this.Szin}   |
{OffsetString}|_______|";
			}
			
		}
	}
}