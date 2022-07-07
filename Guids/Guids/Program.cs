using System;

namespace Guids
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("c7bc662b-b900-4f6a-851a-88910774925c");

            if(id == Guid.NewGuid())
            Console.WriteLine(id.ToString().Substring(0, 8));
        }
    }
}
