using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("\n****Calculadora de promedio universitario*****");

            //Solicitando al estudiante que ingrese las notas del primer computo
            Console.WriteLine("\nIngrese las notas del primer computo");
            Console.WriteLine("Ingrese las notas del laboratorio 1:");
            double lab1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las notas del parcial 1:");
            double parc1 = Convert.ToDouble(Console.ReadLine());

            // Solicitando al estudiante que ingrese las notas del segundo computo

            Console.WriteLine("\nIngrese las notas del segundo computo");
            Console.WriteLine("Ingrese las notas del laboratorio 2:");
            double lab2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las notas del parcial 2:");
            double parc2 = Convert.ToDouble(Console.ReadLine());

            // Solicitando al estudiante que ingrese las notas del tercer computo
            Console.WriteLine("\nIngrese las notas del segundo computo");
            Console.WriteLine("Ingrese las notas del laboratorio 3:");
            double lab3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las notas del parcial 3:");
            double parc3 = Convert.ToDouble(Console.ReadLine());

            // Calcular el promedio
            double promedioLab = (lab1 + lab2 + lab3) * 0.60;
            double promedioParc = (parc1 + parc2 + parc3)* 0.40;
            double notaFinal = (promedioLab / 3) + (promedioParc / 3);

            Console.WriteLine("\nSu nota final fue: " + Math.Round(notaFinal, 1));

            // Compara el promedio de las notas finales
            if (notaFinal >= 7)
            {
                Console.WriteLine("\n Usted paso la materia con exelente nota");
            }
            else if (notaFinal >=6)
            {
                Console.WriteLine("\n Usted paso la materia con baja nota");
            }
            else
            {
                Console.WriteLine("\n Usted NO aprobo la materia");
            }

            Console.ReadKey();
        }
    }
}