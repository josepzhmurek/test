using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGit.Classes
{
    public class ChockolateCandy : AbstractCandy, Interfaces.ICandy
    {
        public ChockolateCandy(string name, int weight, int sugar) : base(name, weight, sugar)
        {


        }
        public void Write(string name)
        {
            Console.WriteLine($"{name}");
        }

    }

}
