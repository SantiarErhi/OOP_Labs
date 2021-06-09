using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Dish
    {
        string name { get; set; }
        int cost { get; set; }
        int timeToReady { get; set; }
        Cook cook { get; set; }
        Categories categories { get; set; }


    }
}
