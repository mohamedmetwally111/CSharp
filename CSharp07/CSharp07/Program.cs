using System.Reflection.Metadata;
namespace CSharp07.CSharp07
{
    class Program
    {
        static void Main()
        {
            #region Problem1 - Car Test
            //Car car1 = new Car();
            //Console.WriteLine(car1.ToString());

            //Car car2 = new Car(50);
            //Console.WriteLine(car2.ToString());

            //Car car3 = new Car(40, "Mohamed");
            //Console.WriteLine(car3.ToString());

            //Car car4 = new Car(60, "Ahmed", 50.57);
            //Console.WriteLine(car4.ToString());
            #endregion

            #region Problem2 - Calculator Test
            //Calculator cal1 = new Calculator();
            //Console.WriteLine($"sum of two intger {cal1.sum(4, 7)}");
            //Console.WriteLine($"sum of three intger {cal1.sum(4, 7, 9)}");
            //Console.WriteLine($"sum of two double {cal1.sum(8.5, 9.3)}");
            #endregion

            #region Problem3+4+5 - Inheritance Test
            ////problem3
            //Child c1 = new Child(50, 60, 70);
            //Console.WriteLine(c1.ToString());

            //Parent p1 = new Parent(10, 20);
            //Console.WriteLine(p1.ToString());

            ////problem4
            //Child c2 = new Child(10, 20, 30);
            //Console.WriteLine(c2.Product());

            //Parent p2 = new Child(10, 20, 30);
            //Console.WriteLine(p2.Product());

            ////problem5
            //Console.WriteLine("Parent object: " + p1);
            //Console.WriteLine("Child object: " + c1);
            //Console.WriteLine("Parent reference to Child: " + p2);
            #endregion

            #region  problem 6+7 - Shape Test
            //IShape rect = new Rectangle(5, 10);
            //IShape circle = new Circle(3);

            //rect.Draw();
            //circle.Draw();

            //Console.WriteLine($"Area={rect.Area}");
            //Console.WriteLine($"Area={circle.Area}");

            //rect.printDetails();
            //circle.printDetails();
            #endregion

            #region Problem8 - IMovable Test
            //Car car = new Car("BMW");
            //IMovable imovable = car;
            //imovable.Move();
            #endregion

            #region Problem9 - File Test
            //File file = new File("CSharp");
            //file.Read();
            //file.Write();
            #endregion

            #region Problem10 - Drawbles Test
            //Rectangle rectangle = new Rectangle(10,20);
            //rectangle.Draw();
            //rectangle.CalculateArea(); 
            #endregion

        }
    }
}
