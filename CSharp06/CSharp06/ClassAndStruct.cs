using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp06.CSharp06
{
    #region Problem1
    internal struct Point
    {
        int X;
        int Y;

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"point X={X} and point Y={Y}";
        }

    }
    #endregion

    #region Problem2
    //internal class TypeA
    //{
    //    private int F = 10;
    //    internal int G = 20;
    //    public int H = 30;

    //    //in same class
    //    public void show()
    //    {
    //        Console.WriteLine($"F={F}, G={G}, H={H}");
    //    }
    //}
    #endregion

    #region Problem3
    //internal struct Employee
    //{
    //    private int EmpId;
    //    private string Name;
    //    private int Salary;

    //    public void SetName(string name)
    //    {
    //        Name = name;
    //    }

    //    public string GetName()
    //    {
    //        return Name;
    //    }

    //    public int salary
    //    {
    //        get { return Salary; }
    //        set { Salary = value; }
    //    }

    //    public int employeeID { get; set; }

    //}
    #endregion

    #region Problem 4+5
    //internal struct Point
    //{
    //    private int X;
    //    private int Y;

    //    public Point(int x)
    //    {
    //        X = x;
    //        Y = 0;
    //    }

    //    public Point(int x,int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"X={X}, Y={Y}";
    //    } 
    #endregion

    #region Problem6
    //internal struct Point
    //{
    //    public int X;
    //    public int Y;

    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //}

    //internal class Employee
    //{
    //    public string Name;
    //    public double Salary;

    //    public Employee(string name, double salary)
    //    {
    //        Name = name;
    //        Salary = salary;
    //    }
    //} 
    #endregion



}

