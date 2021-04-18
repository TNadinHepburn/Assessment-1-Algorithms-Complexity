using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Search
{
    public static class Sort
    {
        //Insertion sort - sorts into ascending
        public static void Insertion(List<int> data)
        {
            //int counter = 0;
            int sorted = 1;
            int i;
            while (sorted < data.Count)
            {
                int temp = data[sorted];
                for (i = sorted; i > 0; i--)
                {
                    //counter++;
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

            //Console.WriteLine($"Completed in {counter} comparisons");
        }

        //Bubble sort - sorts into descending
        public static void Bubble(List<int> data)
        {
            //int counter = 0;
            for (int i = 0; i < data.Count()-1; i++)
            {
                for (int j = 0; j < data.Count()-1; j++)
                {
                    if (data[j + 1] > data[j])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                    //counter++;
                }
            }
            //Console.WriteLine($"Completed in {counter} steps");
        }

        //Merge sort - sorts into ascending

        public static List<int> Merge(List<int> data)
        {
            if (data.Count() <= 1)
            {
                return data;
            }
            //int counter = 0;
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = data.Count() / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(data[i]);
            }

            for (int i = middle; i < data.Count(); i++)
            {
                right.Add(data[i]);
            }

            left = Merge(left);
            right = Merge(right);
            return MergeHalves(left,right);
        }
        private static List<int> MergeHalves(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }

        //Quick sort - sorts into descending
        public static void Quick(List<int> data, int left, int right)
        {
            if (right > left)
            {
                int pivot = QuickPartition(data, left, right);
                Quick(data, left, pivot - 1);
                Quick(data, pivot + 1, right);
            }
        }
        public static int QuickPartition(List<int> data, int left, int right)
        {
            int pivot = data[right];
            int leftP = left-1;

            for (int j = left; j <= right - 1; j++)
            {
                if (data[j] > pivot)
                {
                    leftP++;
                    int swap = data[leftP];
                    data[leftP] = data[j];
                    data[j] = swap;
                }
            }
            int temp = data[leftP+1];
            data[leftP+1] = data[right];
            data[right] = temp;
            return leftP+1;
        }


        //printing every tenth element from a list
        public static void printEvery10(List<int> Road)
        {
            for (int i = 0; i < Road.Count(); i += 10)
            {
                Console.WriteLine(Road[i]);
            }
        }

        //printing every fiftith element from a list
        public static void printEvery50(List<int> Road)
        {
            for (int i = 0; i < Road.Count(); i += 50)
            {
                Console.WriteLine(Road[i]);
            }
        }
    }
}


