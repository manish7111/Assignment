using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Example.Add();
            Add();
            Program program = new Program();
            Add(2);
            Console.WriteLine("Assignments");
        }
        static void Add()
        {

        }
        public void Add(int a)
        {

        }
    }
}
