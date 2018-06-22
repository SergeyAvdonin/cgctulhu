using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_royale
{
	public class SimpleAi
	{
		public string GetNextMove(State state)
		{
			var possibleMoves = state.MyExplorer.Pos.GetNeighboursAndItselfManh()
				.Where(vec => vec.X >= 0 && vec.Y >= 0 && vec.X < state.Map.GetLength(0) && vec.Y < state.Map.GetLength(1)
				 && state.Map[vec.X, vec.Y] != CellType.Wall);
			var scores = possibleMoves.Select(x =>
			new {
				Pos = x,
				Score = state.GetPotentialFor(x)
			})
			.OrderByDescending(x=>x.Score);

			var result = scores.First();
			if (Equals(result.Pos, state.MyExplorer.Pos))
				return $"WAIT;{result.Score}";
			return $"MOVE {result.Pos.X} {result.Pos.Y};{result.Score}";
		}
	}
}
