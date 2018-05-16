using FactoryDesign.Classes;
using System;

namespace FactoryDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Writing three pages with the Resume Factory:");
            ResumeWriter();
            Console.WriteLine("Writing a TPS Progess Report Page with the TPS Factory");
            TPSReportWriter();
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        static void ResumeWriter()
        {
            ResumeDocument rd = new ResumeDocument();
            rd.WritePage("CoverLetter");
            rd.WritePage("Education");
            rd.WritePage("Work History");
        }

        static void TPSReportWriter()
        {
            TPSReport tr = new TPSReport();
            tr.WritePage("Progress Report");
        }
    }
}
