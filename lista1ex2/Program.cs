using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l;
            int area;

            Console.WriteLine("calcular e exibir a area de um quadrado");
            Console.WriteLine("digite o valor da aresta do quadrado");
            l = int.Parse(Console.ReadLine());

            area = l * l;

            Console.WriteLine(" o valor da area de quadrado é: ");
            Console.WriteLine(area);

        }
    }
}
