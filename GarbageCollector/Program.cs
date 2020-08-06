using System;

namespace GarbageCollector
{
    class Program
    {
        static void Main()
        {
            string gl = "A";
            while (gl.Length>=1)
            {
                gl +=gl;
                Console.WriteLine(gl.Length);
            }
            Console.ReadKey();
        }
    }
}
