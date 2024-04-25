using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo250424
{
    internal class ArrayOperation
    {
        int[] Arr1;
        int size;
        public void setArray()
        {
           
            Console.WriteLine("Enter Array Size");
            size = Convert.ToInt32(Console.ReadLine());
            
             //size=int.Parse(Console.ReadLine());
            
            Arr1=new int[size];
            for (int i = 0;i< Arr1.Length; i++) 
            {
                Console.WriteLine("Enter no:");
                Arr1[i]= Convert.ToInt32(Console.ReadLine());
            }
            
        }

        public void showArray()
        {
            Console.WriteLine("All Array Elements :");
            for (int i = 0;i<Arr1.Length; i++) 
            {
               
                Console.WriteLine(Arr1[i]);
            }
        }
        public void AcceptArray(int[]ar)
        {
            //Arr1 = ar;
            Arr1 = new int[ar.Length];
            for (int i = 0; i < ar.Length; i++)
            {
                Arr1[i] = ar[i];
            }


        }
        public int[]  getBackArray()
        {
            for (int i = 0; i < Arr1.Length; i++)
            {
                Arr1[i] = Arr1[i]+1000;
            }

            return Arr1;
        }

    }
}
