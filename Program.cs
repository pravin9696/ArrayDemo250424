using System.ComponentModel.DataAnnotations;

namespace ArrayDemo250424
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            ////How to declare array in C#
            ////DataType arr_name[size]
            ////DataType[] arrayName;  // array declaration

            //int[] ArrInt;


            //ArrInt = new int[5];

            //ArrInt[0] = 123;


            ////--------------
            //int[]Arr2=new int[5];
            //Arr2[0] = 89;
            //int x = Arr2.Length;

            ////How to read array(Access)

            //// sequencial access
            ////store data/ int no into array
            //for (int i = 0; i < Arr2.Length; i++)  // 0 to 4f all elements one by one 
            //{
            //    Console.WriteLine("Enter Array Element:");
            //     int temp=int.Parse(Console.ReadLine());
            //    Arr2[i] = temp;
            //}

            //// read and display All Array elements 
            //Console.WriteLine("all even elements from array:");
            //for (int i=0;i<Arr2.Length;i++)
            //{
            //    if (Arr2[i]%2==0)
            //    {
            //        Console.WriteLine(Arr2[i]);
            //    }

            //}

            ////random acess

            #endregion

            ArrayOperation ao = new ArrayOperation();

            //ao.setArray();

            //ao.showArray();
            //int[] intAr = new int[5];
            //intAr[0] = 111;
            //intAr[1] = 222;
            //intAr[2] = 333;
            //intAr[3] = 444;
            //intAr[4] = 555;

            //ao.AcceptArray(intAr);
            //int[] tempArray = ao.getBackArray();

            //Console.WriteLine("display array elements of intAr in main");
            //for (int i = 0; i < intAr.Length; i++)
            //{
            //    Console.WriteLine(intAr[i]);
            //}
            //Console.WriteLine("display array elements in main");
            //for (int i = 0; i < tempArray.Length; i++)
            //{
            //    Console.WriteLine(tempArray[i]);
            //}


            Assign2 obj = new Assign2();
            obj.Assg3();
        }
    }
}
