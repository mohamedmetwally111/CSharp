using System.Security.Cryptography.X509Certificates;

namespace CSharp06.CSharp06
{
    internal class Program
    {
        #region Problem6
        //public static void ModifyPoint(Point p)
        //{
        //    p.X += 10;
        //    p.Y += 10;
        //    Console.WriteLine($"X={p.X}, Y = {p.Y}");
        //}

        //public static void ModifyEmployee(Employee e)
        //{
        //    e.Name = "Ahmed";
        //    e.Salary += 1000;
        //    Console.WriteLine($"Name = {e.Name}, Salary = {e.Salary}");
        //} 
        #endregion
        static void Main()
        {
            #region Problem1
            Point p1 = new Point(6, 7);
            Console.WriteLine(p1);
            #endregion

            #region Problem2
            //TypeA T = new TypeA();

            //T.show();

            ////outside class typeA but inside same Project

            ////Console.WriteLine(T.F);  //Error: f is private
            //Console.WriteLine(T.G); // internal is accessible
            //Console.WriteLine(T.H); //public is accessible 
            #endregion

            #region Problem3

            //Employee em = new Employee();
            //em.SetName("Mohamed");
            //Console.WriteLine(em.GetName());

            //em.salary = 120;
            //Console.WriteLine(em.salary);

            //em.employeeID = 10;
            //Console.WriteLine(em.employeeID); 
            #endregion

            #region Problem 4+5
            //Point p1 = new Point(5);
            //Console.WriteLine(p1.ToString());

            //Point p2= new Point(5,6);
            //Console.WriteLine(p2.ToString()); 
            #endregion

            #region Problem6
            //Point p1 = new Point(5, 5);
            //Employee emp = new Employee("Mohamed", 5000);

            //Console.WriteLine("Before modification:");
            //Console.WriteLine($" X = {p1.X}, Y = {p1.Y}");
            //Console.WriteLine($"Name = {emp.Name}, Salary = {emp.Salary}");

            //ModifyPoint(p1);
            //ModifyEmployee(emp);

            //Console.WriteLine("\nAfter modification:");
            //Console.WriteLine($"X = {p1.X}, Y = {p1.Y}");
            //Console.WriteLine($"Name = {emp.Name}, Salary = {emp.Salary}");

            #endregion

        }
    }
}
