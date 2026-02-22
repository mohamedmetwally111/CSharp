using Csharo09;
using System.Security.Cryptography;

namespace CSharp09
{
    #region Proplem1 - enum
    //enum Weekdays:int
    //{
    //    Monday = 1, Tuesday, Wednesday, Thursday, friday
    //}
    #endregion

    #region Problem2 - modify the grade enum
    //enum grades:short
    //{
    //    A,b,c,d,e,f=-1
    //} 
    #endregion

    #region Problem9 - Enum tryParse
    //enum grades
    //{
    //    A,B,C,D,F
    //} 
    #endregion

    #region proplem7 - gender enum with byte
    //enum Gender:byte
    //{
    //    male,female
    //}

    //enum GenderDefault : int
    //{
    //    male, female
    //} 
    #endregion

    #region problem10+14(Department+employee) - Employee Equals Searcharray
    //class Helper<T>
    //{
    //    public static int SearchArray(T[] arr, T Value)
    //    {
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            if (arr[i].Equals(Value))
    //                return i;

    //        }
    //        return -1;
    //    }
    //}
    #endregion

    #region problem11 - helper class and generic method
    //class Helper<T> where T : IComparable<T>
    //{
    //    public static T max(T num1, T num2) 
    //    {
    //        if (num1.CompareTo(num2)>0)
    //            return num1;
    //        else return num2;
    //    }
    //} 
    #endregion

    #region Problem12 - helper class and generic mehhod replace
    //class helper<T> where T : IComparable<T>
    //{
    //    public static void replaceArray(T[] arr,T oldValue,T newValue)
    //    {
    //        for(int i=0;i<arr.Length;i++ )
    //        {
    //            if (arr[i].CompareTo(oldValue)==0)
    //                arr[i] = newValue;   
    //        }
    //    }
    //} 
    #endregion

    #region Problem13 - Swap rect
    //class helper
    //{
    //    public static void swap(ref rectangle r1, ref rectangle r2)
    //    {
    //        rectangle temp = r1;
    //        r1 = r2;
    //        r2 = temp;
    //    }
    //} 
    #endregion

    internal class Program
    {
       public static T[] ReverseArr<T>(T[] array)
        {
            T[] reverse = new T[array.Length];
            for (int i = 0;i<array.Length;i++)
            {
                reverse[i] = array[array.Length-1-i];
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            #region Proplem1 - enum
            //foreach (string name in Enum.GetNames(typeof(Weekdays)))
            //{
            //    Weekdays day = Enum.Parse<Weekdays>(name);
            //    Console.WriteLine($"Today is {day} = {(int)day}");
            //}
            #endregion

            #region Problem2 - modify the grade enum

            //foreach (grades grade in Enum.GetValues(typeof(grades)))
            //{
            //    Console.WriteLine($"{grade}={(short)grade}");
            //} 
            #endregion

            #region Problem3 - Add department prop
            //Person p1 = new Person() {Department="HR",Id=1,Age=20 };
            //Person p2 = new Person() {Department="IT",Id = 12, Age = 30 };

            //Console.WriteLine(p1);
            //Console.WriteLine(p2); 
            #endregion

            #region Problem4 - Child class With sealed Salary
            //child c = new child() {salary=344.54 };
            //c.displaySalary(); 
            #endregion

            #region Prroblem5+8 - Static method in static class

            //Console.WriteLine(Utility.CalacPerimeterOfRect(10,4));
            //Console.WriteLine(Utility.CelsiusToFahrenheit(100));
            //Console.WriteLine(Utility.FahrenheitToCelsius(212));

            #endregion

            #region Problem6 - ComplexNumber MultiPlication
            //ComplexNumber c1 = new ComplexNumber() { Real = 2, Imag = 5 };
            //ComplexNumber c2 = new ComplexNumber() { Real = 3, Imag = 6 };
            //ComplexNumber c3 = c1 * c2;
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3); 
            #endregion

            #region proplem7 - gender enum with byte
            //Console.WriteLine(sizeof(Gender));
            //Console.WriteLine(sizeof(GenderDefault)); 
            #endregion

            #region Problem9 - Enum tryParse
            //Console.Write("Enter Grades:");
            //string input=Console.ReadLine();
            //if(Enum.TryParse(input,out grades grade))
            //{
            //    Console.WriteLine($"Valid grade:{grade}");
            //}
            //else
            //{
            //    Console.WriteLine("invalid grade enter");
            //} 
            #endregion

            #region problem10 - Employee Equals Searcharray
            //Employess[] em =
            //{
            //    new Employess{Id=1,Name="Ahmed"},
            //    new Employess{Id=2,Name="Mohamed"},
            //    new Employess{Id=3,Name="Wael"}
            //};


            //Employess em1 = new Employess() { Id = 3 };
            //int index = Helper<Employess>.SearchArray(em, em1);

            //if (index != -1)
            //    Console.WriteLine($"employee found {index}");
            //else
            //    Console.WriteLine("employee not founded"); 
            #endregion

            #region problem11 - helper class and generic method
            //Console.WriteLine(Helper<int>.max(2,5));
            //Console.WriteLine(Helper<double>.max(3.2, 1));
            //Console.WriteLine(Helper<string>.max("Ali", "Mito")); 
            #endregion

            #region Problem12 - helper class and generic mehhod replace
            //int[] numbers = { 1, 2, 4, 5, 6, 7, 2, 9 };
            //Console.WriteLine("Original integer");
            //foreach(int i in numbers)
            //    Console.WriteLine(i);
            //Console.WriteLine("After integer");
            //helper<int>.replaceArray(numbers, 2, 99);
            //foreach (int i in numbers)
            //    Console.WriteLine(i);

            //string[] name = { "mohamed","ahmed","abdo","wael","mohamed" };
            //Console.WriteLine("Original integer");
            //foreach (string i in name)
            //    Console.WriteLine(i);
            //Console.WriteLine("After integer");
            //helper<string>.replaceArray(name, "mohamed","metwally");
            //foreach (string i in name)
            //    Console.WriteLine(i); 
            #endregion

            #region Problem13 - Swap rect
            //rectangle r1 = new rectangle(3, 4);
            //rectangle r2 = new rectangle(6, 7);
            //Console.WriteLine("Befor swap");
            //Console.WriteLine(r1);
            //Console.WriteLine(r2);

            //helper.swap(ref r1, ref r2);
            //Console.WriteLine("After swap");
            //Console.WriteLine(r1);
            //Console.WriteLine(r2); 
            #endregion

            #region probem15 - Circle struct ==
            //Circle c1=new Circle(3.14,"red");
            //Circle c2 = new Circle(9.11, "yellow");
            //Circle c3 = new Circle(3.14, "red");

            //Console.WriteLine(c1==c3);
            //Console.WriteLine(c1 == c2); 
            #endregion



            int[] arr = { 4,5,9,5,3};
            Console.WriteLine("befor revers"); 
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("after revers");
            int[] reverseNumber=ReverseArr<int>(arr);
            foreach (int i in reverseNumber)
            {
                Console.WriteLine(i);
            }
        }

    }
}
