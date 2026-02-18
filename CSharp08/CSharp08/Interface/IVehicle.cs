using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp08.CSharp08.Interface
{
    #region  Problem1 - IVehicle Interface
    internal interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    internal class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car Start Engine");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car Stop Engine");
        }
    }

    internal class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike Start Engine");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike Stop Engine");
        }
    }
    #endregion
}
