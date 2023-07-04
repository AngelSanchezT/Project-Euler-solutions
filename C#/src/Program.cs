using System;

namespace ProjectEulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejecutar aquí las soluciones de los problemas de Project Euler
            int problem001Solution = EulerProblems.Problem001.Solution(1000);
            Console.WriteLine($"Problem 001 solution: {problem001Solution}");

             // Llamar al método Solution de la clase Problem002
            int len = 4000000;
            int sum = EulerProblems.Problem002.Solution(len);

            // Mostrar el resultado en la consola
            Console.WriteLine("The sum of even Fibonacci numbers below {0} is: {1}", len, sum);

            // Llamar al método Solution y obtener el factor primo
            double len003 = 13195;
            long primeFactor = EulerProblems.Problem003.Solution(len003);

            // Mostrar el factor primo en la consola
            Console.WriteLine("The prime factor of {0} is: {1}", len003, primeFactor);

            // Pausar la consola para ver el resultado antes de salir
            Console.WriteLine("Press any key to exit...");
            
            // Problem004
            int len = 3;
            long result = EulerProblems.Problem004.Solution(len);
            Console.WriteLine("The largest palindrome product of two {0}-digit numbers is: {1}", len, result);

            // Problem005
            long min = 1;
            long max = 20;
            long result = EulerProblems.Problem005.Solution(min, max);
            Console.WriteLine("The smallest positive number that is evenly divisible by all numbers from {0} to {1} is: {2}", min, max, result);

            Console.ReadKey();
        }
    }
}
