using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library5_2;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userRandomInput1 = { -4, 5 };
            int[] userRandomInput2 = { 2, 2 };


            Polynomial polynom = new Polynomial(userRandomInput1);
            Polynomial polynom2 = new Polynomial(userRandomInput2);

            Polynomial polynom3 = polynom + polynom2;

            Console.WriteLine(polynom.Print());
            Console.WriteLine(polynom2.Print());
            Console.WriteLine();
            Console.WriteLine("result  " + polynom3.Print());

            polynom3 = polynom - polynom2;
            Console.WriteLine("result  " + polynom3.Print());

            polynom[25] = 2;
            Console.WriteLine(polynom.Print());
            polynom[25] = 0;
            Console.WriteLine(polynom.Print());

            polynom3 = polynom * polynom2;
            Console.WriteLine("result  " + polynom3.Print());

        }

    }
}
