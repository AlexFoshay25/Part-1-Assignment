using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            //My First Program
            string firstName = "Alex";
            string favMovie = "The Matrix";


            Console.WriteLine("Hello World!");

            Console.WriteLine("   A      FFFFFFF");
            Console.WriteLine(" A   A    F      ");
            Console.WriteLine("A     A   F      ");
            Console.WriteLine("AAAAAAA   FFFFF  ");
            Console.WriteLine("A     A   F      ");
            Console.WriteLine("A     A   F      ");
            Console.WriteLine("A     A   F      ");
            Console.WriteLine("");

            Console.WriteLine($"a. Hello {firstName.ToLower()}, my favorite movie is {favMovie.ToLower()}");
            favMovie = "The Matrix".ToUpper();
            Console.WriteLine("b." + favMovie);
            Console.WriteLine("c." + favMovie.Contains("THE"));
            favMovie = favMovie.Replace("A", "@").Replace("E", "3");
            Console.WriteLine($"d. {favMovie}");



            Console.ReadLine();
        }
    }
}
