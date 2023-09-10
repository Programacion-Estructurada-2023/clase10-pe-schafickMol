using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero del mes");
            int Mes = Convert.ToInt32(Console.ReadLine());

            string numeroMes;

            switch (Mes)
            {
                case 1:
                    numeroMes = "Enero";
                break;
                case 2:
                    numeroMes = "Febrero";
                break;
                case 3:
                    numeroMes = "Marzo";
                break;
                case 4:
                    numeroMes = "Abril";
                break;
                case 5:
                    numeroMes = "Mayo";
                break;
                case 6:
                    numeroMes = "Junio";
                break;
                default:
                    numeroMes = "Advertencia numero de mes no valido, ingrese un numero del 1 al 6";
                break;
            }

            Console.WriteLine("El nombre del mes es: " + numeroMes);
        }
    }
}
    
