using System;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a Resume work page");
            Resume resume = new Resume();
            resume.BuildResume();
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Create a Damage Report");
            DamageReport dr = new DamageReport();
            dr.BuildReport();
            Console.ReadLine();
        }
    }
}
