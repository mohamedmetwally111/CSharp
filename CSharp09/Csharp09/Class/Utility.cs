using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Csharo09
{
    #region Prroblem5+8 - Static method in static class
    internal static class Utility
    {

        public static int X { get; set; }
        public static int Y { get; set; }

        public static double C { get; set; }

        public static double F { get; set; }

        private const double pi = 3.14;
        public static double Pi
        {
            get { return pi; }
        }


        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        public static double CalcCircleArea(double result)
        {
            return Pi * result * result;
        }

        public static double CalacPerimeterOfRect(double X,double Y)
        {
            return 2 * (X + Y);
        }

        public static double CelsiusToFahrenheit(double C)
        {
            return (C * 9 / 5 + 32);
        }
        public static double FahrenheitToCelsius(double F)
        {
            return (F-32)*5/9;
        }
    }
    #endregion
}
