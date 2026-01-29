using System.Text;

namespace CSharpGiza002
{
    class Program
    {
        static void Main()
        {
            #region problem1
            //Console.Write("enter string inpurt: ");
            //string input=Console.ReadLine();

            //int number1=int.Parse(input);
            //Console.WriteLine("int.Parse result: " + number1);

            //int number2=Convert.ToInt32(input);
            //Console.WriteLine("Convert.ToInt32 result: " + number2); 
            #endregion

            #region problem2
            //Console.WriteLine("entern a number: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int result))
            //    Console.WriteLine("valid number: " + result);
            //else
            //    Console.WriteLine("invalid number"); 
            #endregion

            #region problem3
            //object ob;

            //ob = 30;
            //Console.WriteLine("hashcode of int" + ob.GetHashCode());

            //ob = "mohamed";
            //Console.WriteLine("hashcode of string" + ob.GetHashCode());

            //ob = 5242.863;
            //Console.WriteLine("hashcode of double" + ob.GetHashCode());
            #endregion

            #region problem4
            //object ob1 = 10;
            //object ob2 = ob1;

            //ob1 = 20;
            //Console.WriteLine("object value type: "+ob2);

            //object ob3 = new int[] { 10 };
            //object ob4 = ob3;

            //((int[])ob3)[0] = 20;
            //Console.WriteLine("object reference type: "+((int[])ob4)[0]);
            #endregion

            #region problem5
            //string x = "hello";
            //Console.WriteLine("string befor modification: "+x);
            //Console.WriteLine("Hashcode befor modification: " + x.GetHashCode());

            //x += " Hi Willy";
            //Console.WriteLine("string after modification: " + x);
            //Console.WriteLine("Hashcode after modification: " + x.GetHashCode());
            #endregion

            #region problem6
            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine("StringBuilder Befor modification: "+sb);
            //Console.WriteLine("Hashcode befor modification: " + sb.GetHashCode());

            //sb.Append(" How are you");
            //Console.WriteLine("StringBuilder after modification: " + sb);
            //Console.WriteLine("Hashcode after modification: " + sb.GetHashCode()); 
            #endregion

            #region problem7
            //Console.Write("Enter first number: ");
            //int num1=int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2=int.Parse(Console.ReadLine());

            //int sum = num1 + num2;

            //Console.WriteLine("sum is " + num1+ "+" +num2 + " = " + sum);
            //Console.WriteLine("sum is {0} + {1} = {2}",num1,num2,sum);
            //Console.WriteLine($"sum is {num1}+{num2}={sum}"); 
            #endregion

            #region problem8
            //StringBuilder sb = new StringBuilder("Hi");
            //Console.WriteLine(sb);

            //sb.Append(" mohamed");
            //Console.WriteLine("After Append: "+sb);

            //sb.Replace("mohamed", "ahmed");
            //Console.WriteLine("After Replace: "+sb);

            //sb.Insert(2, ",");
            //Console.WriteLine("After Insert: "+sb);

            //sb.Remove(5,2);
            //Console.WriteLine("After Remove: " + sb); 
            #endregion
        }
    }
}
