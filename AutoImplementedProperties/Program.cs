using System;

namespace LearningProperties
{
    class Program
    {
        class Player
        {
            public bool IsAlive // uppercase i for IsAlive because it is a property
            {
                get { return Health > 0; } // properties allow adding check in getters and setter.
            }

            public int Health { get; set; } = 100;

            public void Hit()
            {
                Random r = new Random();
                Health -= r.Next(5, 50);
            }
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                Console.WriteLine($"Is player alive : {player.IsAlive}");
            }
        }
    }
}
