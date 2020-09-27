using System;
using System.Collections;

namespace LearningBitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] preload = new bool[3] { true, false, true };
            BitArray enemyGrid = new BitArray(preload);
            enemyGrid[0] = false;
            enemyGrid[1] = true;
            enemyGrid.Set(2, false);
            foreach (var enemy in enemyGrid)
            {
                Console.WriteLine(enemy);
            }
            Console.ReadLine();
        }
    }
}
