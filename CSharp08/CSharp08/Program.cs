using System;
using CSharp08.CSharp08.Interface;
using CSharp08.CSharp08.Class;
using CSharp08.CSharp08.Struct;
using System.Net.Http.Headers;
namespace CSharp08.CSharp08
{
    class Program
    {
        #region  Part02 Example1 - Interface IshapeSeries to Print 10 Shape
        //public static void PrintTenShape(IShapeSeries shape)
        //{
        //    for(int i = 0; i<10; i++)
        //    {
        //        shape.GetNextArea();
        //        Console.WriteLine(shape.CurrentShapeArea);
        //    }
        //    shape.ResetSeries();
        //} 
        #endregion

        #region Part02 Example4 - Implement Your Own Sorting 
        //public static void SelectionSort(int[] numbers)
        //{
        //    int n = numbers.Length;

        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        int minIndex = i;

        //        for (int j = i + 1; j < n; j++)
        //        {
        //            if (numbers[j] < numbers[minIndex])
        //            {
        //                minIndex = j;
        //            }
        //        }

        //        int temp = numbers[i];
        //        numbers[i] = numbers[minIndex];
        //        numbers[minIndex] = temp;
        //    }


        //} 
        #endregion


        static void Main()
        {
            #region Problem1 - IVehicle Interface
            IVehicle myCar = new Car();
            IVehicle myBike = new Bike();
            myCar.StartEngine();
            myBike.StartEngine();
            myCar.StopEngine();
            myBike.StopEngine();
            #endregion

            #region Problem2 - Shape abstract
            //Rectangle rectangle = new Rectangle(5, 5);
            //Circle circle = new Circle(3);

            //rectangle.Display();
            //circle.Display();
            #endregion

            #region Problem2 - SHape Interface
            //Rectangle rectangle = new Rectangle(5, 5);
            //Circle circle = new Circle(3);

            //rectangle.Display();
            //circle.Display(); 
            #endregion

            #region Problem3 - Product Implement IComparable
            //Product[] product1 = new Product[]
            //{
            //    new Product(230199,"labtob",93),
            //    new Product(230987,"Phone",45),
            //    new Product(239648,"mac",78)
            //};

            //Array.Sort(product1);

            //foreach(var p in product1)
            //{
            //    Console.WriteLine($"ID:{p.Id}, Name:{p.Name}, Price:{p.Price}");
            //} 
            #endregion

            #region Problem4 - student deep copy

            //Student stu1 = new Student(230974,"Ahmed",95.4);
            //Student stu2 = new Student(230748, "Mohamed", 50);

            ////shallow copy
            //stu1 = stu2;
            //Console.WriteLine(stu1.ToString());
            //Console.WriteLine(stu2.ToString());

            //Console.WriteLine(stu1.GetHashCode());
            //Console.WriteLine(stu2.GetHashCode());

            ////deep copy
            //Student stu3 = new Student(stu2);
            //Console.WriteLine(stu2.ToString());
            //Console.WriteLine(stu3.ToString());

            //Console.WriteLine(stu2.GetHashCode());
            //Console.WriteLine(stu3.GetHashCode()); 
            #endregion

            #region Problem5 - IWalkable Explicit interface
            //Robot robot = new Robot();
            //IWalkable w = robot;
            //w.Walk(); 
            #endregion

            #region problem6 - Account struct
            //Account account = new Account();
            //account.AccountId = 1;
            //account.Balance = -652;
            //account.AccounHolderId = "ahmed";
            //Console.WriteLine(account); 
            #endregion

            #region Problem7 - Interface Ilogger
            // ILogger ilog = new ConsoleLogger();
            // ilog.Log();//class

            //ILogger ilog1=new DefaultLogger();
            // ilog.Log();//interface 
            #endregion

            #region Problem8 - Book With Multible constructor
            //Book book1 = new Book();
            //Book book2=new Book("Database");
            //Book book3 = new Book("CSS","Mohamed Metwally");

            //book1.display();
            //book2.display();
            //book3.display(); 
            #endregion

            #region  Part02 Example1 - Interface IshapeSeries to Print 10 Shape
            //Console.WriteLine("firt 10 SquareSeries Area");
            //SquareSeries square = new SquareSeries();
            //PrintTenShape(square);

            //Console.WriteLine("\n");

            //Console.WriteLine("firt 10 CircleSeries Area");
            //CircleSeries circle=new CircleSeries();
            //PrintTenShape(circle); 
            #endregion

            #region Part02 Example2 -Implement IComparable to sorting shapes by area.
            //List<Shape1> sahpe = new List<Shape1>()
            //{
            //     new Shape1("Square", 16),
            //     new Shape1("Circle", 78.5),
            //     new Shape1("Rectangle", 50),
            //     new Shape1("Square", 25),
            //     new Shape1("Circle", 12.56),
            //     new Shape1("Rectangle", 100)
            //};

            //Shape1[] shapeArray = sahpe.ToArray();
            //Array.Sort(shapeArray);
            //foreach (Shape1 shape in shapeArray)
            //{
            //    Console.WriteLine(shape.ToString());
            //} 
            #endregion

            #region Part02 Example3 - class GeometricShape
            //Triangle tringle = new Triangle
            //{
            //    Dimension1 = 3,
            //    Dimension2 = 4
            //};

            //Rectangle rectangle = new Rectangle
            //{
            //    Dimension1 = 9,
            //    Dimension2 = 10
            //};

            //Console.WriteLine("rectangle");
            //Console.WriteLine($"Area={rectangle.CalculateArea()}");
            //Console.WriteLine($"perimeters={rectangle.Perimeter}");

            //Console.WriteLine("Tringle");
            //Console.WriteLine($"Area={tringle.CalculateArea()}");
            //Console.WriteLine($"perimeters={tringle.Perimeter}"); 
            #endregion

            #region Part02 Example4 - Implement Your Own Sorting 
            //    List<GeometricShape> shapes = new List<GeometricShape>()
            //{
            //    new Rectangle { Dimension1 = 5, Dimension2 = 10 }, 
            //    new Rectangle { Dimension1 = 3, Dimension2 = 4 },  
            //    new Rectangle { Dimension1 = 7, Dimension2 = 2 }   
            //};

            //    int[] areas = new int[shapes.Count];

            //    for (int i = 0; i < shapes.Count; i++)
            //    {
            //        areas[i] = (int)shapes[i].CalculateArea();
            //    }


            //    Console.WriteLine("Before Sorting:");
            //    foreach (int area in areas)
            //        Console.WriteLine(area);


            //    SelectionSort(areas);

            //    Console.WriteLine("\nAfter Sorting (Selection Sort):");
            //    foreach (int area in areas)
            //    Console.WriteLine(area);

            #endregion

        }

    }

}
