using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_cutulu;

namespace Code_royale
{
    public class State
    {
        //0(.) - пусто, 1(w) - spawn, 2(#) стена
        public CellType[,] Map;

        public List<Spawn> Spawns;

        public List<Wanderer> Wanderers;

        public List<Explorer> OtherExplorers;

	    public Explorer MyExplorer;

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

	    public int GetPotentialFor(Vec targetPos)
	    {
		    if (MyExplorer == null)
				throw new Exception("null explorer");
		    var maxDist = Map.GetLength(0) + Map.GetLength(1);
		    var result = 0;

		    foreach (var otherExplorer in OtherExplorers)
		    {
			    if (targetPos.ManhDistTo(otherExplorer.Pos) < 2)
				    result += 10;
				else if (targetPos.ManhDistTo(otherExplorer.Pos) == 2)
				    result += 5;
			    else
					//улучшить
				    result += (maxDist - targetPos.ManhDistTo(otherExplorer.Pos)) / 20;
			}

		    return result;
	    }
    }

    public enum CellType
    {
        Empty, Spawn, Wall
    }
}
