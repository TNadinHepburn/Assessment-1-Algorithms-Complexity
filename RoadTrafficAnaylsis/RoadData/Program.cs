using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadData
{
    class Program
    {
        static void Main(string[] args)
        {
            Road R_1_256 = new Road("Road_1_256.txt");
            
            Console.WriteLine(R_1_256.RoadData);

        }
    }
}
