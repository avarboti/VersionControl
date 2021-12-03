using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimulacio.Entities
{
    public class DeathProbability
    {
        public Gender Gender { get; set; }
        public int age { get; set; }
        public double probability { get; set; }
    }
}
