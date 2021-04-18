using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Search
{
    public static class Search
    {
        public static List<int> Binary(List<int> data)
        {
            return null;
        }

        public static List<int> Sequential(List<int> data,int searchValue)
        {
            //int counter=0;
            List<int> foundIndexes = new List<int>();
            for(int i = 0; i < data.Count(); i++)
            {
                //counter++;
                if (data[i] == searchValue)
                {
                    foundIndexes.Add(i);
                }
            }
            //Console.WriteLine($"Completed in {counter} steps");
            return foundIndexes;
        }
    }
}
