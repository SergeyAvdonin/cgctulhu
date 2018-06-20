using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_royale;

namespace Code_cutulu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs;
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            var map = new CellType[width, height];
            var baseState = new State();
            for (int i = 0; i < height; i++)
            {
                string line = Console.ReadLine();
                for (var j = 0; j < line.Length; j++)
                {
                    if (line.ElementAt(j) == '.')
                        map[i, j] = CellType.Empty;
                    if (line.ElementAt(j) == '#')
                        map[i, j] = CellType.Wall;
                    if (line.ElementAt(j) == 'w')
                    {
                        map[i, j] = CellType.Spawn;
                        baseState.Spawns.Add(new Spawn(new Vec(i,j)));
                    }
                }

            }
            baseState.Map = map;

            inputs = Console.ReadLine().Split(' ');
            int sanityLossLonely = int.Parse(inputs[0]); // how much sanity you lose every turn when alone, always 3 until wood 1
            int sanityLossGroup = int.Parse(inputs[1]); // how much sanity you lose every turn when near another player, always 1 until wood 1
            int wandererSpawnTime = int.Parse(inputs[2]); // how many turns the wanderer take to spawn, always 3 until wood 1
            int wandererLifeTime = int.Parse(inputs[3]); // how many turns the wanderer is on map after spawning, always 40 until wood 1

            // game loop
            while (true)
            {
                var currentState = baseState.Copy();
                int entityCount = int.Parse(Console.ReadLine()); // the first given entity corresponds to your explorer
                for (int i = 0; i < entityCount; i++)
                {
                    inputs = Console.ReadLine().Split(' ');
                    string entityType = inputs[0];

                    if (entityType == "EXPLORER")
                    {
                        int id = int.Parse(inputs[1]);
                        int x = int.Parse(inputs[2]);
                        int y = int.Parse(inputs[3]);
                        int param0 = int.Parse(inputs[4]);
                        int param1 = int.Parse(inputs[5]);
                        int param2 = int.Parse(inputs[6]);
                    }

                    
                    //Console.Error.WriteLine(inputs);
                }

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                Console.WriteLine("WAIT"); // MOVE <x> <y> | WAIT
            }
        }
    }
}

    
