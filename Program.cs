using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMachine;

namespace CalculatorApp
{
    class Program
    {
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        static int Pangkat(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        static int Modulo(int a, int b)
        {
            return a % b;
        }

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan Nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai b = ");
            var b = Convert.ToInt32(Console.ReadLine());

            var cal = new Calculator();

            var cil = new Calculator();

            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, cal.Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, cal.Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian : {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b));
            Console.WriteLine("Hasil Pangkat : {0} ^ {1} = {2}", a, b, cil.Pangkat(a, b));
            Console.WriteLine("Hasil Modulo : {0} % {1} = {2}", a, b, cil.Modulo(a, b));

            Console.ReadKey();
        }
    }
}

        