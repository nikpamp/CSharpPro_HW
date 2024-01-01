using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpPro_HW
{
    public class MyArray : IOutput, IMath, ISort
    {
        public int[] myArray { get; set; }

        public MyArray(int[] ints)
        {
            myArray = ints;
        }
        public void Show()
        {
            if (myArray.Length == 0)
            {
                Console.WriteLine("The array is empty.");
            }
            else
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"{myArray[i]} ");
                }
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            if (myArray.Length == 0)
            {
                Console.WriteLine("The array is empty.");
            }
            else
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"{myArray[i]} ");
                }
            }
            Console.WriteLine($"- {info}");
        }

        public int Max()
        {
            int max = myArray.Max();
            Console.WriteLine(max);
            return max;
        }

        public int Min()
        {
            int min = myArray.Min();
            Console.WriteLine(min);
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }
            float avg = (float)sum / myArray.Length;
            Console.WriteLine(avg);
            return avg;
        }

        public bool Search(int valueToSearch)
        {
            bool a = myArray.Contains(valueToSearch);
            Console.WriteLine(a);
            return a;
        }

        public void SortAsc()
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = 0; j < myArray.Length - i - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        var temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.WriteLine();
        }

        public void SortDesc()
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = 0; j < myArray.Length - i - 1; j++)
                {
                    if (myArray[j] < myArray[j + 1])
                    {
                        var temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.WriteLine();
        }

        public void SortByParam(bool isAsc)
        {
            if (!isAsc)
            {
                SortDesc();
            }
            else
            {
                SortAsc();
            }
        }
    }

    internal interface ISort
    {
    }

    internal interface IMath
    {
    }

    public interface IOutput
    {
    }
}