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

            // Pausar la consola para ver el resultado antes de salir
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
