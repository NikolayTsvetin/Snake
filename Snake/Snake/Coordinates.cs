using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Coordinates
    {
        private int _x;
        private int _y;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0 || value > Constants.Width)
                {
                    throw new ArgumentException("Coordinates must be positive.");
                }

                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value < 0 || value > Constants.Height)
                {
                    throw new ArgumentException("Coordinates must be positive.");
                }

                _y = value;
            }
        }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
