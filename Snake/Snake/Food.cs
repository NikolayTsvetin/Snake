using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Food(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
