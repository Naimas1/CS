using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class MyArray : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
    {
        public int[] arr { get; set; }

        public void SortAsc()
        {
            Array.Sort(arr);
        }
        public void SortDesc()
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc) SortAsc();
            else SortDesc();
        }
        public MyArray() 
        {
            arr = new int[0];
        }
        public MyArray(int[] arr)
        {
            this.arr = arr;
        }
        public void Show()
        {
            Console.WriteLine("It`s array method Show");
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
        }
        public int Max()
        {
            return arr.Max();
        }
        public int Min()
        {
            return arr.Min();
        }
        public float Avg()
        {
            return (float)arr.Average();
        }
        public bool Search(int valueToSearch)
        {
            return arr.Contains(valueToSearch) ? true : false;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int number in arr)
            {
                if (number < valueToCompare) count++;
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int number in arr)
            {
                if (number > valueToCompare) count++;
            }
            return count;
        }

        public void ShowEven()
        {
            Console.WriteLine("Even numbers:");
            foreach (int number in arr)
            {
                if (number % 2 == 0) Console.WriteLine(number);
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd numbers:");
            foreach (int number in arr)
            {
                if (number % 2 != 0) Console.WriteLine(number);
            }
        }

        public int CountDistinct()
        {
            return arr.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return arr.Count(number => number == valueToCompare);
        }

        public override string ToString()
        {
            return string.Join(", ", arr);
        }
    }
}
