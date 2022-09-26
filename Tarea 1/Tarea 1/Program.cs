using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[5];
            short [] Notas = new short[5];
            short Promedio =0, NotaMayor=0, TotalMayor=0, TotalMenor=0;
       
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el nombre del estudiante #" + (i+1));
                Nombres[i] = Console.ReadLine();
                Console.WriteLine("Digite la nota del estudiante #"+(i+1));
                Notas[i] = short.Parse(Console.ReadLine());
                Promedio += Notas[i];
            }
            Promedio /= 5;
            for (int i = 0; i < 5; i++)
            {
                if (NotaMayor < Notas[i])
                {
                    NotaMayor = Notas[i];
                }
                if (Notas[i] > Promedio)
                {
                    TotalMayor++;
                }
                else {
                    TotalMenor++;
                }
            }
            Console.WriteLine("El Promedio de las notas de los estudiantes es de " + Promedio);
            Console.WriteLine("La Nota mayor es un " + NotaMayor);
            Console.WriteLine("En Total {0} estudiantes tienen una nota mayor al promedio y {1} tienen una nota menor a este", TotalMayor, TotalMenor);
            Console.Read();
        }
    }
}
