using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zehntausend
{
    class Player
    {
        private string name;
        private int id;
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}