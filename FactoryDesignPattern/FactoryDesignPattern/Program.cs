using System;
using System.Threading;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting to assemble your documents. Your name is?");
            string name = Console.ReadLine();
            Console.WriteLine("Thank you. Processing ...");
            Console.WriteLine("writing Resume ... building resume writer");
            Thread.Sleep(800);
            ResumeWriter Tolkien = new ResumeWriter();
            Document resume = Tolkien.Write(name);
            Console.WriteLine($"{nameof(Tolkien)} has written a resume for {resume.Name}");
            Console.WriteLine($"resume filetype is {resume.FileExtension}");
            Conwole.WriteLine($"Previous work history: you have worked at {resume.Work}")
            Console.WriteLine("Hello World!");
        }
    }
}
