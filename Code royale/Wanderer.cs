using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_cutulu;

namespace Code_royale
{
    public class Wanderer :Entity
    {
        public bool IsWandering = false;
        public int TimeBeforeRecall;

	    public Wanderer(Vec pos) : base(pos)
	    {
	    }
    }
}
