namespace CSharp10
{
    #region Problem1 - SortingAlgorithm<T> class of Employee Asc
    //static class SortingTwo<T> where T : IComparable<T>
    //{
    //    public static void SortingAlgorthm(T[] arr)
    //    {
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            for (int j = 0; j < arr.Length - 1 - i; j++)
    //            {
    //                if (arr[j].CompareTo(arr[j + 1]) > 0)
    //                {
    //                    Swap(ref arr[j], ref arr[j + 1]);
    //                }
    //            }
    //        }
    //    }

    //    public static void Swap(ref T x, ref T Y)
    //    {
    //        T temp = x;
    //        x = Y;
    //        Y = temp;

    //    }
    //}
    #endregion


    #region Problem2 - SortingTwo<T> Sort method to dynamically+length in ascending + Problem3 - sort strings length in ascending + Problem4 - sorting Asc logic employee and  Manager
    //static class SortingTwo<T> where T : IComparable<T>
    //{
    //    public static void SortingAlgorthm(T[] arr, Func<T, T, bool> CompareFunc)
    //    {
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            for (int j = 0; j < arr.Length - 1 - i; j++)
    //            {
    //                if (CompareFunc(arr[j], (arr[j + 1])))
    //                {
    //                    Swap(ref arr[j], ref arr[j + 1]);
    //                }
    //            }
    //        }
    //    }

    //    public static void Swap(ref T x, ref T Y)
    //    {
    //        T temp = x;
    //        x = Y;
    //        Y = temp;

    //    }

    //}

    //static class CompareFunction<T> where T : IComparable<T>
    //{
    //    public static Func<T, T, bool> SortAscFunc = (X, Y) => X.CompareTo(Y) > 0;

    //    public static Func<T, T, bool> SortDescFunc = (X, Y) => X.CompareTo(Y) < 0;

    //}
    #endregion


    #region problem5 - delegate Func<T, T, bool> to compare Employee by Name length
    //static class CompareFunction
    //{
    //    public static bool SortAscLength(Employee em1, Employee em2)
    //    {
    //        return em1.Name.Length > em2.Name.Length;
    //    }

    //    public static bool SortDescLength(Employee em1, Employee em2)
    //    {
    //        return em1.Name.Length < em2.Name.Length;
    //    }

    //}

    //static class SortingTwo<T>
    //{
    //    public static void SortingAlgorthm(T[] arr, Func<T,T,bool> SortFunc)
    //    {
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            for (int j = 0; j < arr.Length - 1 - i; j++)
    //            {
    //                if (SortFunc(arr[j], arr[j + 1]))
    //                {
    //                    Swap(ref arr[j],ref arr[j + 1]);
    //                }
    //            }
    //        }
    //    }

    //    public static void Swap(ref T x,ref T y)
    //    {
    //        T temp = x;
    //        x=y; 
    //        y=temp;
    //    }
    //} 
    #endregion


    #region problem7 - swapping elements of an integer array
    //class SortingAlgorithm<T>
    //{
    //    public static void Swap(ref T X,ref T Y)
    //    {
    //        T temp = X;
    //        X=Y;
    //        Y=temp;
    //    }
    //} 
    #endregion


    #region Problem8 -  sort Employee objects first by Salary  and in case of ties by name
    //static class SortingTwo<T> 
    //{
    //    public static void SortingAlgorthm(T[] arr, Func<T, T, bool> CompareFunc)
    //    {
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            for (int j = 0; j < arr.Length - 1 - i; j++)
    //            {
    //                if (CompareFunc(arr[j], (arr[j + 1])))
    //                {
    //                    Swap(ref arr[j], ref arr[j + 1]);
    //                }
    //            }
    //        }
    //    }

    //    public static void Swap(ref T x, ref T Y)
    //    {
    //        T temp = x;
    //        x = Y;
    //        Y = temp;

    //    }
    //} 

    #endregion


    #region Problem10 -  SortingAlgorithm<T> class to ensure T implements ICloneable
    //static class SortingTwo<T> where T : IComparable<T>,ICloneable
    //{
    //    public static void SortingAlgorthm(T[] arr)
    //    {
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            for (int j = 0; j < arr.Length - 1 - i; j++)
    //            {
    //                if (arr[j].CompareTo(arr[j + 1])>0)
    //                {
    //                    Swap(ref arr[j], ref arr[j + 1]);
    //                }
    //            }
    //        }
    //    }

    //    public static void Swap(ref T x, ref T Y)
    //    {
    //        T temp = x;
    //        x = Y;
    //        Y = temp;

    //    }
    //} 
    #endregion


    #region Problem11 -  converting to uppercase, reversing the string
    //public delegate string StringTransformFuncDeleget(string str);

    //public class StringListProcessor
    //{
    //    List<string> list;
    //    public List<string> Transform(StringTransformFuncDeleget Trans)
    //    {
    //        List<string> result = new List<string>();
    //        foreach (var item in list)
    //        {
    //            result.Add(Trans(item));
    //        }
    //        return result;
    //    }
    //}

    // static class fuction
    //{
    //    static string ToUpperCase(string s)
    //    {
    //        return s.ToUpper();
    //    }

    //    static string ReverseString(string s)
    //    {
    //        char[] arr = s.ToCharArray();
    //        Array.Reverse(arr);
    //        return new string(arr);
    //    }
    //} 
    #endregion


    #region  Problem12 - delegate that takes two integers and apply addition, subtraction, multiplication, and division.
    //public delegate int IntOperationFuncDeleget(int num1, int num2);

    //static class OperatinProcess
    //{
    //    public static int Addition(int num1, int num2)
    //    { return num1 + num2; }

    //    public static int Subtraction(int num1, int num2)
    //    { return num1 - num2; }

    //    public static int multiplication(int num1, int num2)
    //    { return num1 * num2; }

    //    public static int Division(int num1, int num2)
    //    { return num1 / num2; }
    //}

    //static class  Operation
    //{
    //    public static int PerformOperation(int num1, int num2,IntOperationFuncDeleget op)
    //    {
    //        return op(num1, num2); 
    //    }
    //} 
    #endregion


    #region Problem13 -  converting a list of integers to their string representations
    //public delegate R TransformerfuncDeleget<T, R>(T input);

    //public class ListProcessor<T>
    //{
    //    private List<T> _list;

    //    public ListProcessor(List<T> list)
    //    {
    //        _list = list;
    //    }
    //    public List<R> Transform<R>(TransformerfuncDeleget<T, R> transformer)
    //    {
    //        List<R> result = new List<R>();
    //        foreach (var item in _list)
    //        {
    //            result.Add(transformer(item));
    //        }
    //        return result;
    //    }
    //}

    //public class Operation
    //{
    //    static string IntToString(int n) => "Number: " + n;
    //    static int Square(int n) => n * n;
    //} 
    #endregion


    internal class Program
    {


        #region Problem9 - method GetDefault that uses default(T)
        //public static T GetDefault<T>()
        //{
        //    return default(T);
        //} 
        #endregion

        #region Problem14 -  create a delegate that takes a string and prints it to the console
        //public static void ApplyAction(List<string> strings, Action<string> action)
        //{
        //    foreach (var s in strings)
        //    {
        //        action(s);
        //    }
        //} 
        #endregion

        //public static List<int> FilterList(List<int> numbers, Predicate<int> predicate)
        //{
        //    List<int> result = new List<int>();
        //    foreach (var n in numbers)
        //    {
        //        if (predicate(n))
        //        {
        //            result.Add(n);
        //        }
        //    }
        //    return result;
        //}


        static void Main(string[] args)
        {

            #region Problem1 - SortingAlgorithm<T> class of Employee Asc

            //Employee[] emp =
            //{
            //            new Employee(1,"Ahmed",4835),
            //            new Employee(2,"Mohamed",9325),
            //            new Employee(3,"AbdElrahman",1836),
            //            new Employee(3,"Ali",1038),
            //    };

            //Console.WriteLine("Befor Sorting Asc");
            //foreach (Employee employee in emp)
            //    Console.WriteLine(employee);
            //Console.WriteLine();

            //Console.WriteLine("After Sorting Asc");
            //SortingTwo<Employee>.SortingAlgorthm(emp);
            //foreach (Employee employee in emp)
            //    Console.WriteLine(employee);
            #endregion

            #region Problem2 - SortingTwo<T> Sort method to dynamically
            //Employee[] emp =
            //{
            //            new Employee(1,"Ahmed",4835),
            //            new Employee(2,"Mohamed",9325),
            //            new Employee(3,"AbdElrahman",1836),
            //            new Employee(3,"Ali",1038),
            //};

            //Console.WriteLine("Befor Sorting Asc");
            //foreach (Employee employee in emp)
            //    Console.WriteLine(employee);
            //Console.WriteLine();

            //Console.WriteLine("After Sorting Asc");
            //SortingTwo<Employee>.SortingAlgorthm(emp, CompareFunction<Employee>.SortDescFunc);
            //foreach (Employee employee in emp)
            //    Console.WriteLine(employee); 
            #endregion

            #region Problem3 - sort strings length in ascending
            //string[] names = { "Ahmed", "Ali", "Abdo", "Abd Elrhman" };
            //Console.WriteLine("Befor Sorting Asc");
            //foreach ( string name in names)
            //    Console.WriteLine(name);
            //Console.WriteLine();
            //Console.WriteLine("After Sorting Asc");
            //var SortAscLength = (string X, string Y) => X.Length > Y.Length;
            //SortingTwo<string>.SortingAlgorthm(names, SortAscLength);
            //foreach (string name in names)
            //    Console.WriteLine(name); 
            #endregion

            #region Problem4 - sorting Asc logic employee and  Manager
            //Employee[] empAndManagers =
            //{
            //    new Employee(1,"Ahmed",4835),
            //    new Employee(2,"Mohamed",9325),
            //    new Employee(3,"AbdElrahman",1836),
            //    new Employee(4,"Ali",1038),
            //    new Manager(5,"Sara",12000,"IT"),
            //    new Manager(6,"Hany",8500,"HR"),
            //};

            //Console.WriteLine("Befor Sorting Asc");
            //foreach (Employee empMgr in empAndManagers)
            //    Console.WriteLine(empMgr);
            //Console.WriteLine();

            //Console.WriteLine("After Sorting Asc");
            //SortingTwo<Employee>.SortingAlgorthm(empAndManagers, CompareFunction<Employee>.SortAscFunc);
            //foreach (Employee empMgr in empAndManagers)
            //    Console.WriteLine(empMgr); 
            #endregion

            #region Problem5 - delegate Func<T, T, bool> to compare Employee by Name length
            // Employee[] employees =
            //{
            //     new Employee(1, "Ahmed", 4835),
            //     new Employee(2, "Mohamed", 9325),
            //     new Employee(3, "AbdElrahman", 1836),
            //     new Employee(4, "Ali", 1038)
            // };

            // Console.WriteLine("Before Sorting :");
            // foreach (var emp in employees) 
            //     Console.WriteLine(emp);
            // Console.WriteLine();

            // SortingTwo<Employee>.SortingAlgorthm(employees, CompareFunction.SortAscLength);

            // Console.WriteLine("After Sorting Ascending by Name Length:");
            // foreach (var emp in employees) Console.WriteLine(emp);
            // Console.WriteLine();


            // SortingTwo<Employee>.SortingAlgorthm(employees, CompareFunction.SortDescLength);

            // Console.WriteLine("After Sorting Descending by Name Length:");
            // foreach (var emp in employees) Console.WriteLine(emp); 
            #endregion

            #region Problem6 -  anonymous function and  lambda expression to ass array

            ////anonymous function 
            //int[] integer = { 99, 55, 100, 77, 33 };
            //Array.Sort(integer,delegate (int num1,int num2)
            //{
            //    return num1.CompareTo(num2);
            //});
            //Console.WriteLine("After Sorting Ascending With anonymous function : ");
            //foreach (int num in integer)
            //    Console.WriteLine(num);

            ////lambda expression. 
            //Array.Sort(integer, ( num1, num2) => num1.CompareTo(num2));

            //Console.WriteLine("After Sorting Ascending with lambda expression. : ");
            //foreach (int num in integer)
            //Console.WriteLine(num); 
            #endregion

            #region Problem7 -  swapping elements of an integer array
            //int[] numbers = { 5, 9, 3, 8, 4, 2 };
            //Console.WriteLine("befor Swap");
            //foreach (int i in numbers)
            //    Console.WriteLine(i);

            //Console.WriteLine("after Swap");
            //SortingAlgorithm<int>.Swap(ref numbers[0],ref numbers[3]);
            //foreach (int i in numbers)
            //    Console.WriteLine(i); 
            #endregion

            #region Problem8 -  sort Employee objects first by Salary  and in case of ties by name

            //Employee[] employees =
            //{
            //    new Employee(1,"Ahmed", 5000),
            //    new Employee(2,"Mohamed", 5000),
            //    new Employee(3,"Ali", 4000),
            //    new Employee(4,"Sara", 6000)
            //};

            //foreach (Employee employee in employees) 
            //    Console.WriteLine(employee);
            //Console.WriteLine();

            //Func<Employee, Employee, bool> CompareEmployee = (em1, em2) =>
            //{
            //    if(em1.Salary>em2.Salary)
            //        return true;
            //    else if(em1.Salary==em2.Salary && string.Compare(em1.Name,em2.Name)>0)
            //        return true;
            //    else
            //        return false;
            //};

            //SortingTwo<Employee>.SortingAlgorthm(employees, CompareEmployee);
            //foreach (Employee employee in employees)
            //    Console.WriteLine(employee);
            //Console.WriteLine(); 
            #endregion

            #region Problem9 - method GetDefault that uses default(T) 
            //int x = GetDefault<int>();
            //string s=GetDefault<string>();

            //Console.WriteLine(x);
            //Console.WriteLine(s ?? "null"); 
            #endregion

            #region Problem10 -  SortingAlgorithm<T> class to ensure T implements ICloneable
            //Employee[] employees =
            //{
            //    new Employee(1,"Ahmed", 5000),
            //    new Employee(2,"Mohamed", 5000),
            //    new Employee(3,"Ali", 4000),
            //    new Employee(4,"Sara", 6000)
            //};

            //Console.Write("Original:");
            //foreach(Employee em in employees)
            //    Console.WriteLine(em);
            //Console.WriteLine();

            //Employee[] clonedEmployees = new Employee[employees.Length];

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    clonedEmployees[i] = (Employee)employees[i].Clone(); 
            //} 


            //Console.Write("Clone:");
            //foreach (Employee em in clonedEmployees)
            //    Console.WriteLine(em);
            //Console.WriteLine();

            //SortingTwo<Employee>.SortingAlgorthm(clonedEmployees);
            //Console.WriteLine("original after sort clone");
            //foreach (Employee em in employees)
            //    Console.WriteLine(em);
            //Console.WriteLine();

            //Console.WriteLine("clone after sort clone");
            //foreach (Employee em in clonedEmployees)
            //    Console.WriteLine(em);
            //Console.WriteLine();
            #endregion

            #region Problem12 - delegate that takes two integers and apply addition, subtraction, multiplication, and division. 
            //int a = 10, b = 5;
            //Console.WriteLine("Add: " +Operation.PerformOperation(a, b,OperatinProcess.Addition));
            //Console.WriteLine("Subtract: " + Operation.PerformOperation(a, b, OperatinProcess.Subtraction));
            //Console.WriteLine("Multiply: " + Operation.PerformOperation(a, b, OperatinProcess.multiplication));
            //Console.WriteLine("Divide: " + Operation.PerformOperation(a, b, OperatinProcess.Division)); 
            #endregion

            #region Problem14 -  create a delegate that takes a string and prints it to the console
            //List<string> names = new List<string> { "Mito", "Ahmed", "Ali" };

            //Action<string> printAction = s => Console.WriteLine(s);

            //ApplyAction(names, printAction); 
            #endregion

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            //Predicate<int> isEven = n => n % 2 == 0;

            //List<int> evenNumbers = FilterList(numbers, isEven);

            //Console.WriteLine("Even numbers:");
            //foreach (var n in evenNumbers)
            //{
            //    Console.WriteLine(n);
            //}

        }
    }
}
