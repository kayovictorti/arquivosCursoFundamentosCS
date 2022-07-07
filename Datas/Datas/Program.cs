using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Console.Clear();
             var data = new DateTime(2020, 10, 12, 8, 23, 14);
             //var data = DateTime.Now;


             Console.WriteLine(data);
             Console.WriteLine(data.Year);
             Console.WriteLine(data.Month);
             Console.WriteLine(data.Day);
             Console.WriteLine(data.Hour); ;
             Console.WriteLine(data.Minute);
             Console.WriteLine(data.Second);

             Console.WriteLine(data.DayOfWeek);
             Console.WriteLine(data.DayOfYear);
            */

            //*******FORMATANDO DATAS********
            /*
            var data = DateTime.Now;

            //var formatada = String.Format("{0:yyyy}", data);
            //var formatada = String.Format("{0:M}", data);
            //var formatada = String.Format("{0:yyyy-MM-dd}", data);
            var formatada = String.Format("{0:dd/MM/yyy hh:mm:ss ff z}", data);
            Console.WriteLine(formatada);
            */



            var data = DateTime.Now;


            //r, s e u são padrões muito utilizados
            var formatada = String.Format("{0:u}", data);
            Console.WriteLine(formatada);
        }
    }
}
