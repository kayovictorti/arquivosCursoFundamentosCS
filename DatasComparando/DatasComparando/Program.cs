using System;

namespace DatasComparando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            if(data == DateTime.Now)
            {
                Console.WriteLine("É igual");
            }

            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual!");
            }


            Console.WriteLine(data); 

        }
    }
}
