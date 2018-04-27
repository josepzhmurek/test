using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestForGit.Classes;

namespace TestForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            ChockolateCandy p = new ChockolateCandy("Мишка на сервере", 20, 10);

            p.Write(p.Name);

        }

   }
}
