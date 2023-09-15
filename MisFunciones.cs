using System.IO;
using ejercicio1.Entities;
using Newtonsoft.Json;

namespace ejercicio1;

    public class MisFunciones
    {
        public static int MenuNotas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("|*************Menu Notas*************|");
            Console.WriteLine("1. Agregar notas de Quices");
            Console.WriteLine("2. Agregar notas de Trabajos");
            Console.WriteLine("3. Agregar notas de Parciales");
            Console.WriteLine("0. Atras");
            Console.WriteLine("|****************************************|");
            return Convert.ToInt16(Console.ReadLine());
        }

        public static int Reportes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("|*************Reportes*************|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1.Ver notas del grupo");
            Console.WriteLine("2.Ver notas finales");
            Console.WriteLine("3.Ver notas de un estudiante");
            Console.WriteLine("4.Ver notas finales de un estudiante");
            Console.WriteLine("0. Salir al menu principal");
            return Convert.ToInt16(Console.ReadLine());
        }

        public static void SaveData(List<Estudiante> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText("boletin.json", json);
        }

        public static List<Estudiante> LoadData()
        {
            using (StreamReader reader = new StreamReader("Boletin.json"))
            {
                string json = reader.ReadToEnd();
                return System.Text.Json.JsonSerializer.Deserialize<List<Estudiante>>(json, new System.Text.Json.JsonSerializerOptions()
                { PropertyNameCaseInsensitive = true}) ?? new List<Estudiante>();
            }
        }


    }