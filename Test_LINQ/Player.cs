using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_LINQ
{
    internal class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public Player(string login, int level)
        {
            Name = login;
            Level = level;
        }
    }
}
