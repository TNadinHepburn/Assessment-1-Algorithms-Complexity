using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RoadData
{
    class Road
    {
        public List<int> RoadData { get; set; }

        public Road(string file)
        {
            List<int> RoadData = new List<int>();
            StreamReader sr = new StreamReader(file);
            string data;
            while ((data = sr.ReadLine())!= null)
            {
                RoadData.Add(int.Parse(data));
            }
        }

        public void Insertion()
        {
            int sorted = 1;
            int i;
            while (sorted < RoadData.Count)
            {
                int temp = RoadData[sorted];
                for (i = sorted; i > 0; i--)
                {
                    if (temp < RoadData[i - 1])
                    {
                        RoadData[i] = RoadData[i - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                RoadData[i] = temp;
                sorted++;
            }
        }


        public override string ToString()
        {
            string output = "";
            foreach(int val in RoadData)
            {
                output += val;
            }

            return output;
        }
    }
}
