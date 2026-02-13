using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunbarlang
{
    internal class Player
    {
        private int point;
        private int point_ingame;

        public Player()
        {
            this.point = 0;
            this.point_ingame = 0;
        }

        public int Point { get => point; set => point = value; }
        public int Point_ingame { get => point_ingame; set => point_ingame = value; }
    }
}
