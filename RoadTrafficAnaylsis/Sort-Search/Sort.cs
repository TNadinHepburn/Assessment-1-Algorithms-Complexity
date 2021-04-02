using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Search
{
    public static class Sort
    {
        public static List<int> Insertion(List<int> data)
        {
            int sorted = 1;
            int i;
            while (sorted < data.Count)
            {
                int temp = data[sorted];
                for (i = sorted; i > 0; i--)
                {
                    if (temp < data[i - 1])
                    {
                        data[i] = data[i - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                data[i] = temp;
                sorted++;
            }
            return data;
        }
    }
}
