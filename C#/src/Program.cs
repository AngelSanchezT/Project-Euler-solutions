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



            // Pausar la consola para ver el resultado antes de salir
            Console.WriteLine("Press any key to exit...");
            
            
            
            
            Console.ReadKey();


        }
    }
}
