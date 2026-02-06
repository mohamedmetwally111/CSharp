
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace CSharp05
{
    class Program
    {
        #region Problem2
        //public static void TestDefensiveCode()
        //{
        //    int x, y;
        //    do
        //    {
        //        Console.WriteLine("enter positive integer x: ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(),out x)|| x<=0);

        //    do
        //    {
        //        Console.WriteLine("enter positive integer y: ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out y) || y <= 1);

        //    Console.WriteLine($"x = {x} and y = {y}");
        //} 
        #endregion

        #region Problem9
        //public static void SumAndMultiply(int x,int y,out int sum,out int product)
        //{
        //    sum = x + y;
        //    product = x * y;
        //} 
        #endregion

        #region Problem10
        //public static void PrintStringOfTime(string m, int time = 5)
        //{
        //    for(int i=0; i<time; i++)
        //    {
        //        Console.WriteLine(m);
        //    }
        //} 
        #endregion

        #region Problem13
		        //public static int SumArray(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach(int n in numbers)
        //    {
        //        sum += n;
        //    }
        //    return sum; 
	    #endregion
        }
        static void Main()
        {
            #region Problem1
            //int x, y;
            //do
            //{
            //    Console.WriteLine("enter first integer number:");
            //}
            //while (!int.TryParse(Console.ReadLine(), out x));

            //do
            //{
            //    Console.WriteLine("enter second integer number:");
            //}
            //while (!int.TryParse(Console.ReadLine(), out y));

            //try
            //{
            //    Console.WriteLine("The divided two integer: " + x / y);
            //}
            //catch (DivideByZeroException Ex)
            //{
            //    Console.WriteLine(Ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //} 
            #endregion

            #region Problem3
            //int? x= null;
            //int result = x ?? 0;
            //Console.WriteLine(result);

            //if(x.HasValue)
            //    Console.WriteLine($"number is {x}"); 
            //else
            //    Console.WriteLine("number is null"); 
            #endregion

            #region Problem4
            //int[] arr = new int[5];

            //try
            //{
            //    Console.WriteLine(arr[8]);
            //}
            //catch(IndexOutOfRangeException EX)
            //{
            //    Console.WriteLine(EX.Message);
            //} 
            #endregion

            #region Problem5
            //int[,] arr = new int[3,3];

            //for(int i=0;i<3;i++)                                           
            //{
            //    for(int j=0;j<3;j++)                                       
            //    {
            //        Console.WriteLine($"enter value for arr[{i},{j}]");    
            //        arr[i,j] =int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < 3; i++)
            //{
            //    int SumRow = 0;
            //    for ( int j=0; j<3; j++)
            //    {
            //        SumRow +=arr[i, j];
            //    }
            //    Console.WriteLine($"sum of Row{i+1}:{SumRow}");
            //}

            //for(int i=0;i< 3; i++)
            //{
            //    int SumColumn = 0;
            //    for( int j=0; j<3;j++)
            //    {
            //        SumColumn += arr[j, i];
            //    }
            //    Console.WriteLine($"sum of column{i+1}:{SumColumn}");
            //} 
            #endregion

            #region Problem6
            //int[][] arr = new int[3][];

            //arr[0] = new int[2];
            //arr[1] = new int[3];
            //arr[2] = new int[4];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter values for row {i + 1}:");
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"Element [{i}][{j}]: ");
            //        arr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nJagged Array Elements:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem7
            //string? name;

            //Console.WriteLine("enter your name");
            //string input = Console.ReadLine();

            //if (!String.IsNullOrWhiteSpace(input))
            //{
            //    name = input;
            //}
            //else
            //{
            //    name = null;
            //}

            //Console.WriteLine("Name length: " + name!.Length); 
            #endregion

            #region Problem8
            //object obj = 5;

            //try
            //{

            //    double y = (double)obj;
            //}
            //catch
            //{
            //    Console.WriteLine("invalid casting");
            //} 
            #endregion

            #region Problem9
            //int x = 5, y = 3;
            //int sum, product; ;
            //SumAndMultiply(x, y, out sum, out product);
            //Console.WriteLine($"sum={sum}");
            //Console.WriteLine($"sum={product}"); 
            #endregion

            #region Problem10
            //PrintStringOfTime("Hi");
            //Console.WriteLine();

            //PrintStringOfTime("Hi",10);
            //Console.WriteLine();

            //PrintStringOfTime(m: "Hi mohamed metwally", time: 2); 
            #endregion

            #region Problem11
            //int[]? arr = null;
            //Console.WriteLine("length of array: " + (arr?.Length??0));

            //arr =new int[] { 8,6,9,3};
            //Console.WriteLine("length of array: " + (arr?.Length??0)); 
            #endregion

            #region Problem12
            //Console.WriteLine("enter a day of week: ");
            //string day = Console.ReadLine();

            //int dayNumber = day.ToLower()
            //switch
            //{
            //    "monday" => 1,
            //    "tuseday" => 2,
            //    "wednesday" => 3,
            //    "thursday" => 4,
            //    "friday" => 5,
            //    "saturday" => 6,
            //    "sunday" => 7,
            //    _=>0

            //};
            //if (dayNumber != 0)
            //    Console.WriteLine($"{day} is day number {dayNumber}");
            //else
            //    Console.WriteLine("invalid day entered!");

            #endregion

            #region Problem13
            //int sum=SumArray(1, 5, 8);
            //Console.WriteLine(sum);

            //int[] arr = { 5,8,2};
            //int sum2=SumArray(arr);
            //Console.WriteLine(sum2); 
            #endregion
        }
    }
}
