using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int[] Salarios = new int[5];
            string[] Nombre = new string[5];
            // Se Solicitan Los Datos Al Usuario
            for (int i = 0; i <Salarios.Length ; i++)
            {
                Console.WriteLine("Digite El Nombre Del Empleado #"+(i+1));
                Nombre[i]=Console.ReadLine();
                Console.WriteLine("Digite El Salario Del Empleado #" + (i+1));
                Salarios[i]=int.Parse(Console.ReadLine());
            }
         // Se Recorren los Datos Digitados
            for (int i = 0; i < Salarios.Length; i++)
            {
                Aguinaldos(Nombre[i], Salarios[i]);
            }
            Console.Read();
        }
        //Calcula el aguinaldo y muestra los datos de los empleados
        static void Aguinaldos(string Nombre,int Salario)
        {
            int Aguinaldo = Salario * 12;
            Console.WriteLine("El Empleado {0} " +
                "Tiene Un Salario De {1} " +
                "merece un Aguinaldo De {2}",Nombre,Salario,Aguinaldo);
        }
    }
}
