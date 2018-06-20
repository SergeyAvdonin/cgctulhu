using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_royale
{
    public class State
    {
        //0(.) - пусто, 1(w) - spawn, 2(#) стена
        public CellType[,] Map;

        public List<Spawn> Spawns;

        public List<Wanderer> Wanderers;

        public List<Explorer> Explorers;

        public State Copy()
        {
            var copy = new State();
            var map = new CellType[Map.GetLength(0), Map.GetLength(1)];
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(0); j++)
                {
                    map[i,j] = Map[i, j];
                }
            }
            copy.Map = map;
            
            return copy;
        }
    }

    public enum CellType
    {
        Empty, Spawn, Wall
    }
}
