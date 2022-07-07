using System;

namespace TimezoneAula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime());

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");
            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
            Console.WriteLine(horaAustralia);

            //var timezones = TimeZoneInfo.GetSystemTimeZones();
            //foreach (var timezone in timezones)
            //{
            //    Console.WriteLine(timezone.Id);
            //    Console.WriteLine(timezone);
            //    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            //    Console.WriteLine("__________");
            //}

        }
    }
}
