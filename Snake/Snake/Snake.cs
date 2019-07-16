using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public Queue<Coordinates> Head { get; private set; }

        public Snake()
        {
            Head = new Queue<Coordinates>();
        }
    }
}
