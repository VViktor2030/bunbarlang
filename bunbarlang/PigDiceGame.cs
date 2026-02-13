using System.Numerics;

namespace Bunbarlang

{

    internal class PigDiceGame

    {

        private string valasz;

        Random random = new Random();

        public string Valasz { get => valasz; set => valasz = value; }

        public void jatekos_kor(Player player)

        {

            do

            {

                int rnd = random.Next(1, 7);

                Console.WriteLine($"Az osszes pontod: {player.Point}/100");

                Console.WriteLine($"Ebben a korben szerzett pontszamod: {player.Point_ingame}");

                Console.WriteLine($"A dobott szamod: {rnd}");

                if (rnd == 1)

                {

                    Console.WriteLine("1-et dobtal, ebbol a korbol kimaradsz es lenullaztam a jelenlegi pontszamodat");

                    player.Point_ingame = 0;

                }

                else

                {

                    Console.WriteLine($"Szeretnel meg dobni? (i/n)");

                    Valasz = Console.ReadLine();

                    if (Valasz == "i")

                    {

                        player.Point_ingame += rnd;

                    }

                    else

                    {

                        player.Point += player.Point_ingame + rnd;

                        player.Point_ingame = 0;

                    }

                }

                Console.WriteLine();

                Console.WriteLine();

                Console.WriteLine();

            } while (player.Point < 100);

            Console.WriteLine("Elerted a 100 pontot!");

            Console.WriteLine("Nyertel");

        }

    }

}
