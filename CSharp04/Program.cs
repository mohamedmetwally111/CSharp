using System.Globalization;
using System.Runtime.InteropServices;

namespace Giza002CSharp04
{
    class Program
    {
        static void Main()
        {
            #region Problem1
            ////1
            //int[] arr1 = new int[3];
            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;

            //foreach(int n in arr1)
            //{
            //    Console.WriteLine(n);
            //}

            ////2
            //int[] arr2=new int[3] { 10, 20, 30 };
            //for(int i=0;i<arr2.Length;i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}


            ////3
            //int[] arr3 = { 10, 20, 30 };
            //foreach (int i in arr3)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Problem2
            //int[] arr1 = { 1, 2, 3, };

            //int[] arr2 = arr1;

            //arr1[0] =100;

            //Console.WriteLine("After Shallow copy modification: ");
            //Console.WriteLine("arr1: ");
            //foreach(int i in arr1) 
            //    Console.WriteLine(i);

            //Console.WriteLine("arr2:");
            //foreach (int i in arr2)
            //    Console.WriteLine(i); 

            //int[] arr3 = (int[]) arr1.Clone();

            //arr1[1] = 200;

            //Console.WriteLine("After Deep copy (Clone) Modification :");
            //Console.WriteLine("arr1: ");
            //foreach(int i in arr1)
            //    Console.WriteLine(i);

            //Console.WriteLine("arr3: ");
            //foreach( int i in arr3)
            //    Console.WriteLine(i); 
            #endregion

            #region Problem3
            //int[,] grades = new int[3,3];

            //for (int i = 0; i<3; i++)
            //{
            //    Console.WriteLine("enter grades for student: "+(i+1));

            //    for (int j=0; j<3; j++)
            //    {
            //        Console.WriteLine("Subject1: "+(j+1)+":");
            //        grades[i,j]=int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.Clear();

            //for(int i=0; i<3; i++)
            //{
            //    Console.WriteLine("student "+(i+1)+":");
            //    for (int j=0; j<3; j++)
            //    {
            //        Console.WriteLine("subject " + (j + 1) + ":");
            //        Console.WriteLine(grades[i, j]);
            //    }
            //} 
            #endregion

            #region Problem3
            //int[] arr = { 9, 2, 7, 4, 8 };

            ////sort
            //Console.WriteLine("Befor Sort: ");
            //foreach (int i in arr)
            //    Console.WriteLine(i);

            //Array.Sort(arr);
            //Console.WriteLine("After Sort: ");
            //foreach (int i in arr)
            //    Console.WriteLine(i);

            ////Reverse
            //Console.WriteLine("Befor Reverse: ");
            //foreach(int i in arr)
            //    Console.WriteLine(i);

            //Array.Reverse(arr);
            //Console.WriteLine("After Reverse: ");
            //foreach(int i in arr)
            //    Console.WriteLine(i);

            ////indexOf
            //int a=Array.IndexOf(arr,7);
            //Console.WriteLine("index of 7: "+a);

            ////copy
            //Console.WriteLine(" copy Array: ");
            //int[] c=new int[arr.Length];
            //Array.Copy(arr,c,arr.Length);
            //foreach (int i in c)
            //    Console.WriteLine(i);

            //Console.WriteLine("Befor Clear: ");
            //foreach(int i in arr)
            //    Console.WriteLine(i);

            //Array.Clear(arr);
            //Console.WriteLine("After length: ");
            //foreach(int i in arr)
            //    Console.WriteLine(i); 
            #endregion

            #region Problem4
            //int[] arr = { 10, 20, 30, 40, 50 };

            //for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }

            ////foreach
            //foreach (int i in arr)
            //    Console.WriteLine(i);

            //int c = arr.Length;
            //c--;
            //while (c>= 0)
            //{
            //    Console.WriteLine(arr[c]);
            //    c--;
            //} 
            #endregion

            #region Problem5
            //int num;
            //bool isValid;

            //do
            //{
            //    Console.WriteLine("Entar a positive odd number: ");
            //    string input = Console.ReadLine();

            //    isValid = int.TryParse(input, out num);

            //    if (!isValid)
            //    {
            //        Console.WriteLine("invalid input! ");
            //        isValid = false;
            //    }

            //    else if (num % 2 == 0)
            //    {
            //        Console.WriteLine("Number must be odd!");
            //        isValid = false;
            //    }

            //    else if (num <= 0)
            //    {
            //        Console.WriteLine("number must be positive!");
            //        isValid = false;
            //    }
            //}
            //while (!isValid);
            #endregion

            #region problem6
            //int[,] grades =
            //{
            //    {92,83,66},
            //    {40,77,90 },
            //    {88,99,60 }
            //};

            //Console.WriteLine("Grades Matrix");
            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.WriteLine(grades[i, j]);
            //    }
            //    Console.WriteLine();   
            //}
            #endregion

            #region Problem7
            // Console.Write("enter a month number: ");
            // int month;
            // month=int.Parse(Console.ReadLine());

            ////if
            // if (month == 1)
            //     Console.WriteLine("Junuary");
            // else if (month == 2)
            //     Console.WriteLine("February");
            // else if (month == 3)
            //     Console.WriteLine("March");
            // else if (month == 4)
            //     Console.WriteLine("April");
            // else if (month == 5)
            //     Console.WriteLine("May");
            // else if (month == 6)
            //     Console.WriteLine("June");
            // else if (month == 7)
            //     Console.WriteLine("July");
            // else if (month == 8)
            //     Console.WriteLine("August");
            // else if (month == 9)
            //     Console.WriteLine("September");
            // else if (month == 10)
            //     Console.WriteLine("October");
            // else if (month == 11)
            //     Console.WriteLine("November");
            // else if (month == 12)
            //     Console.WriteLine("December");
            // else
            //     Console.WriteLine("Invalid month number!");

            // //switch
            // switch(month)
            // {
            //     case 1:
            //         Console.WriteLine("Junuary");
            //         break;
            //      case 2:
            //         Console.WriteLine("February");
            //         break;
            //     case 3:
            //         Console.WriteLine("March");
            //         break;
            //     case 4:
            //         Console.WriteLine("April");
            //         break;
            //     case 5:
            //         Console.WriteLine("May");
            //         break;
            //     case 6:
            //         Console.WriteLine("June");
            //         break;
            //     case 7:
            //         Console.WriteLine("July");
            //         break;
            //     case 8:
            //         Console.WriteLine("August");
            //         break;
            //     case 9:
            //         Console.WriteLine("September");
            //         break;
            //     case 10:
            //         Console.WriteLine("October");
            //         break;
            //     case 11:
            //         Console.WriteLine("November");
            //         break;
            //     case 12:
            //         Console.WriteLine("December");
            //         break;
            //     default:
            //         Console.WriteLine("invalid month:");
            //         break ;
            // } 
            #endregion

            #region Problem8
            //int[] numbers = { 5,2,7,2,6,3 };

            //Array.Sort(numbers);
            //Console.WriteLine("Sorted Array:");
            //foreach(int i in numbers)
            //    Console.WriteLine(i);

            //int FIndex=Array.IndexOf(numbers, 2);
            //int LIndex=Array.LastIndexOf(numbers, 2);

            //Console.WriteLine("first index of " + FIndex);
            //Console.WriteLine("last index of "+LIndex); 
            #endregion

            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            int sum1 = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum1 += numbers[i];

            Console.WriteLine("sum using for loop:"+sum1);

            int sum2 = 0;
            foreach(int i in numbers)
                sum2 += i;

            Console.WriteLine("sum using foreach:" + sum2);


        }
    }
}
