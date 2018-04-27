using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGit.Classes
{
    public abstract class AbstractCandy
    {
        public string Name { get; set; }
        public int Weight { get;  set; }
        public int Sugar { get; set; }

        public AbstractCandy(string name, int weight, int sugar)
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
        }
       
    }
}
