using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocenteFijo Derik =  new DocenteFijo("Derik", "123124", 80000, true);

            Console.WriteLine(Derik.ToString());

            DocenteHoras profesor = new DocenteHoras("Ben","12234", 40);

            Console.WriteLine(profesor.ToString());
        }
    }
}