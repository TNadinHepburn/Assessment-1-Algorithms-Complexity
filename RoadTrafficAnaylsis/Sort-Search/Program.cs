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
        /*
         2 searching - binary and sequential
         4 sorting - bubble , insertion , merge , quick
         */


        static void Main(string[] args)
        {

            List<int> Road_1_256 = new List<int>(ReadData("Road_1_256.txt"));
            List<int> Road_2_256 = new List<int>(ReadData("Road_2_256.txt"));
            List<int> Road_3_256 = new List<int>(ReadData("Road_3_256.txt"));
            List<int> Road_1_2048 = new List<int>(ReadData("Road_1_2048.txt"));
            List<int> Road_2_2048 = new List<int>(ReadData("Road_2_2048.txt"));
            List<int> Road_3_2048 = new List<int>(ReadData("Road_3_2048.txt"));


            Console.WriteLine("---Road_1_256 Sorted ascending---");
            Sort.Insertion(Road_1_256);
            Sort.printEvery10(Road_1_256);
            Console.WriteLine("---Road_2_256 Sorted ascending---");
            Sort.Insertion(Road_2_256);
            Sort.printEvery10(Road_2_256);
            Console.WriteLine("---Road_3_256 Sorted ascending---");
            Sort.Insertion(Road_3_256);
            Sort.printEvery10(Road_3_256);

            Console.WriteLine("---Road_1_256 Sorted descending---");
            Sort.Bubble(Road_1_256);
            Sort.printEvery10(Road_1_256);
            Console.WriteLine("---Road_2_256 Sorted descending---");
            Sort.Bubble(Road_2_256);
            Sort.printEvery10(Road_2_256);
            Console.WriteLine("---Road_3_256 Sorted descending---");
            Sort.Bubble(Road_3_256);
            Sort.printEvery10(Road_3_256);


            Console.WriteLine("---Road_1_2048 Sorted ascending---");
            Road_1_2048 = Sort.Merge(Road_1_2048);
            Sort.printEvery50(Road_1_2048);
            Console.WriteLine("---Road_2_2048 Sorted ascending---");
            Road_2_2048 = Sort.Merge(Road_2_2048);
            Sort.printEvery50(Road_2_2048);
            Console.WriteLine("---Road_3_2048 Sorted ascending---");
            Road_3_2048 = Sort.Merge(Road_3_2048);
            Sort.printEvery50(Road_3_2048);

            Console.WriteLine("---Road_1_2048 Sorted descending---");
            Sort.Quick(Road_1_2048,0,Road_1_2048.Count()-1);
            Sort.printEvery50(Road_1_2048);
            Console.WriteLine("---Road_2_2048 Sorted descending---");
            Sort.Quick(Road_2_2048, 0, Road_2_2048.Count() - 1);
            Sort.printEvery50(Road_2_2048);
            Console.WriteLine("---Road_3_2048 Sorted descending---");
            Sort.Quick(Road_3_2048, 0, Road_3_2048.Count() - 1);
            Sort.printEvery50(Road_3_2048);
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

        public static int UserSearch()
        {
            int searchFor;
            while (true)
            {
                Console.Write("Value to search for: ");
                try
                {
                    searchFor = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter a number.");
                }
            }
            return searchFor;
        }
    }
}
