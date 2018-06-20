using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_cutulu;

namespace Code_royale
{
    public class Spawn : Entity
    {
        public int TimeBeforeSpawning;

        public Spawn(Vec pos) : base(pos)
        {
        }
    }
}
