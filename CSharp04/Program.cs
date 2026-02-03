namespace ENumCSharp
{
    enum DayOfWeek
    {
        Saturdy=1,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number from 1 to 7: ");
            int number=int.Parse(Console.ReadLine());   

            DayOfWeek day=(DayOfWeek)Enum.Parse(typeof(DayOfWeek),number.ToString());
            Console.WriteLine("day is: " + day);
        }
    }
}
