using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnassoMarianaEjercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Title = "Ejercicio01";
                    double Cateto1, Cateto2;
                    double Perimetro, Supericie, Hipotenusa;
                    Console.WriteLine("Ingresar el valor del primer cateto:");
                    Cateto1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresar el valor del segundo cateto:");
                    Cateto2 = Convert.ToDouble(Console.ReadLine());

                    if (Cateto1 > 0 && Cateto2 > 0)
                    {
                        Hipotenusa = Math.Sqrt(Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2));
                        Perimetro = Cateto1 + Cateto2 + Hipotenusa;
                        Supericie = (Cateto1 * Cateto2) / 2;

                        Console.WriteLine($"El perimetro del triangulo es: {Perimetro}");
                        Console.WriteLine($"La superficie del triangulo es: {Supericie}");

                    }
                    else
                    {
                        Console.WriteLine("Los lados del triangulo deben ser mayores a cero.");
                    }

                }
                catch (FormatException)
                {

                    Console.WriteLine("Los valores se deben ingresar en formato numerico");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();


        }
    }
}