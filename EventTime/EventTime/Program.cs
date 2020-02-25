using System;
using System.Globalization;

namespace EventTime
{
    //1061 - Event Time
    class Program
    {
        static void Main(string[] args)
        {
            string startDay = Console.ReadLine();
            var auxLength = (startDay.Length - 4);
            startDay = startDay.Substring(4, auxLength);
            string startHour = Console.ReadLine();
            string endDay = Console.ReadLine();
            auxLength = (endDay.Length - 4);
            endDay = endDay.Substring(4, auxLength);
            string endHour = Console.ReadLine();
            DateTime start = DateTime.Parse(DateTime.Now.Year + "-04-" + startDay + " " + startHour, CultureInfo.InvariantCulture);
            DateTime end = DateTime.Parse(DateTime.Now.Year + "-04-" + endDay + " " + endHour, CultureInfo.InvariantCulture);
           
            TimeSpan duration = end - start;

            Console.WriteLine(duration.Days + " dia(s)");
            Console.WriteLine(duration.Hours + " hora(s)");
            Console.WriteLine(duration.Minutes + " minuto(s)");
            Console.WriteLine(duration.Seconds + " segundo(s)");
        }
    }
}
