using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGit.Interfaces
{
    interface ICandy
    {
        string Name { get; set; }
        int Weight { get; set; }
        int Sugar { get; set; }
    }
}
