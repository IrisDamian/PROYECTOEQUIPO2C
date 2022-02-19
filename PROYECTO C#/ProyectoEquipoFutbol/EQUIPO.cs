using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ProyectoEquipoFutbol
{
    public class EQUIPO
    {
        public string eq { get; set; }      
    }

    public class Programa
    {
        public static void Main()
        {
            string fileName = "EQUIPO.json";
            string jsonString = File.ReadAllText(fileName);
            EQUIPO equipof = JsonSerializer.Deserialize<EQUIPO>(jsonString)!;

            Console.WriteLine($"eq: {equipof.eq}");          
        }
    }
}
