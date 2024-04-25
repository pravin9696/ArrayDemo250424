using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo250424
{
    internal class Assign2
    {
        public void Assg2()
        {
            int[] MyArray = new int[5];
            Console.WriteLine("enter Array Elements:");
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0;i< MyArray.Length;i++) 
            {
                sum += MyArray[i];
            }
            Console.WriteLine("Sum of Array Elements ="+sum);
        }
        public void Assg3()
        {
            int[] MyArray = new int[5];
            Console.WriteLine("enter Array Elements:");
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = int.Parse(Console.ReadLine());
            }

            int max;
            int min;

            max = MyArray[0];
            min = MyArray[0];

            for (int i = 1; i < MyArray.Length; i++)
            {
                if (max < MyArray[i])
                {
                    max = MyArray[i];
                }
                if (min > MyArray[i])
                {
                    min = MyArray[i];
                }
            }
            Console.WriteLine("Max="+max+" Min="+min);
        }
    }
}
