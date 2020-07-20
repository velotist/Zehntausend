using System;

namespace Zehntausend
{
    class Player
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public int Points { get; set; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}