using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practica1();
            Practica2();
            Practica3();

        }
        #region Practica1
        static void Practica1()
        {
            //Console.WriteLine("Hola Mundo!! Aprendiendo c#"); // com
            /*
             * comentario de bloque
             */
            int edad = 45;
            int alumnos = 24;
            string curso = "DEINT";

            //Console.WriteLine("Tu edad es de " + edad + " años");
            //Console.WriteLine($"Tu edad es {edad} años");
            //Console.WriteLine("Tu edad es de {0}", edad);
            //Console.WriteLine("En la clase {0} hay {1} alumnos", curso,alumnos);

            Console.WriteLine("Introduce un valor par un radio");
            double rad = double.Parse(Console.ReadLine());

            const double PI = 3.14;

            double area = Math.Pow(rad, 2) * PI;

            Console.WriteLine($"El área del círculo de radio {rad} es {area}");

        }
        #endregion
        #region Practica2
        #endregion
        #region Practica3
        #endregion

    }
}
