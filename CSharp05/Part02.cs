namespace CSharp05
{
    class Program
    {
        static void Main()
        {
            #region Program1
            //int number;

            //do
            //{
            //    Console.WriteLine("enter positive integer");
            //}
            //while (!int.TryParse(Console.ReadLine(), out number)||number<=0);

            //for (int i=1;i<=number;i++)
            //{
            //     Console.Write(i);
            //    if (i < number)
            //        Console.Write(",");
            //} 
            #endregion

            #region Program2
            //int number;

            //do
            //{
            //    Console.WriteLine("enter integer number");
            //}
            //while (!int.TryParse(Console.ReadLine(), out number));

            //int result = 0;
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number*i);
            //    if(i<12)
            //    {
            //        Console.Write(",");
            //    }
            //} 
            #endregion

            #region Program3
            //int number;

            //do
            //{
            //    Console.WriteLine("enter integer number");
            //}
            //while (!int.TryParse(Console.ReadLine(), out number));

            //for (int i = 1; i < number; i+=2)
            //{
            //    Console.Write(i + 1);
            //    if (i+2 < number)
            //        Console.Write(",");
            //} 
            #endregion

            #region Program4
            //int num1,num2;

            //do
            //{
            //    Console.WriteLine("enter integer number");
            //}
            //while (!int.TryParse(Console.ReadLine(), out num1));

            //do
            //{
            //    Console.WriteLine("enter power number");
            //}
            //while (!int.TryParse(Console.ReadLine(), out num2));

            //int result = 1;
            //for (int i = 0; i < num2; i++)
            //{
            //    result *= num1;
            //}
            //Console.WriteLine(result); 
            #endregion

            #region Program5
            //string text;
            //text=Console.ReadLine();

            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //} 
            #endregion

            #region Program6
            //int number;

            //do
            //{
            //    Console.WriteLine("enter positive integer");
            //}
            //while (!int.TryParse(Console.ReadLine(), out number));

            //int reverse = 0;

            //while(number!=0)
            //{
            //    int digit = number % 10;
            //    reverse = (reverse * 10) + digit;
            //    number=number / 10;
            //}
            //Console.WriteLine(reverse); 
            #endregion

            #region Program7
            //int leng;
            //Console.WriteLine("enter the length of araay");
            //leng = int.Parse(Console.ReadLine());

            //int[] arr = new int[leng];

            //for (int i= 0; i<leng; i++)
            //{
            //    Console.Write($"enter array arr[{i}]: ");
            //    arr[i]=int.Parse(Console.ReadLine());
            //}

            //int distinict = 0;
            //int maxDistincit = 0; 

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for(int j =i+1; j < arr.Length; j++)
            //    {
            //        if(arr[i] == arr[j] )
            //        {
            //            distinict = j - i - 1;

            //            if(distinict>maxDistincit)
            //            {
            //                maxDistincit=distinict; 
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"longeast distincit: {maxDistincit}"); 
            #endregion

            #region Program8
            //Console.WriteLine("Enter a sentence");
            //string sentence = Console.ReadLine();

            //string[] word=sentence.Split(' ');

            //Array.Reverse(word);

            //Console.WriteLine(string.Join(" ",word)); 
            #endregion


        }
    }
}
