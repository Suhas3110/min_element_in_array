using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=new int[5];
            Console.WriteLine("Enter the array Element");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Print Maximum Element in an Array");
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine("Print Minimum Element in an Array");
            int min=arr[0];
            for(int i = 0;i < arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min= arr[i];    
                }
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
