using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoEquipoFutbol
{
    class Program
    {
        static void Main(string[] args)
        {         
            string[,] eq = new string[4, 9];
            
            for (int i = 0; i <eq.GetLength(0); i++)
            {               
                Console.WriteLine("Ingresa los equipos "+(i+1));
                eq[i,0] = Console.ReadLine();
                Console.WriteLine("Ingresa los partidos jugados "+(i+1));
                eq[i,1] = Console.ReadLine();               
                Console.WriteLine("Ingresa los partidos ganados "+(i+1));
                eq[i,3] = Console.ReadLine();
                Console.WriteLine("Ingresa los partidos empatados "+(i+1));
                eq[i,4] = Console.ReadLine();
                Console.WriteLine("Ingresa los partidos perdidos "+(i+1));
                eq[i,5] = Console.ReadLine();
                Console.WriteLine("Ingresa los goles a favor " +(i+1));
                eq[i,6] = Console.ReadLine();
                Console.WriteLine("Ingresa los goles en contra "+(i+1));
                eq[i,7] = Console.ReadLine();
                Console.WriteLine("Ingresa la diferencia de goles "+(i+1));
                eq[i,8] = Console.ReadLine();
            }
            Console.Clear();

            string puntaje ="";          
            for (int i=0; i<eq.GetLength(0); i++)
                if (eq[i,2]==puntaje)
                {
                    eq[i, 2] = eq[i,3 * 3] + eq[1,4];
                }

            Console.Write("EQ | PJ | P | PG | PE | PP | GF | GC | DG");
            for (int i=0; i<eq.GetLength(0); i++)
            {
                for(int j=0; j<eq.GetLength(1); j++)
                {
                    Console.Write(eq[i,j] + " | ");
                }
                Console.WriteLine();
            }           
            Console.ReadKey();           
        }
    }
}
