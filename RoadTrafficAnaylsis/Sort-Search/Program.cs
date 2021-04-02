using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sort_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Road_1_256 = new List<int>(ReadData("Road_1_256.txt"));
            List<int> Road_2_256 = new List<int>(ReadData("Road_2_256.txt"));
            List<int> Road_3_256 = new List<int>(ReadData("Road_3_256.txt"));

            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine($"|1:{Road_1_256[i]} |2:{Road_2_256[i]} |3:{Road_3_256[i]}");
            }


        }

        public static List<int> ReadData(string fileP)
        {
            List<int> dataPoints = new List<int>();
            string data;
            StreamReader sr = new StreamReader(fileP);
            while ((data = sr.ReadLine()) != null)
            {
                dataPoints.Add(int.Parse(data));
            }
            return dataPoints;
        }
    }
}
