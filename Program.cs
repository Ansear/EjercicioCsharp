using ejercicio1.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        int val = 1;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Agregar Estudiante");
            Console.WriteLine("2. Agregar notas al Estudiante");
            Console.WriteLine("3. Mostrar informacion del Estudiante");
            Console.WriteLine("4. Mostrar notas finales del Estudiante");
            Console.WriteLine("5. Salir");
            val = Convert.ToInt16(Console.ReadLine());
            switch (val)
            {
                case 1:
                    do
                    {
                        estudiantes.Add(AddStudent());
                        Console.WriteLine("¿Desea Agregar otro estudiante? si(Y) no(N)");
                        
                    } while (Console.ReadLine().ToUpper() == "Y");
                    break;
                case 2:
                    Console.WriteLine("Seleccion 2");
                    break;
                case 3:
                    Console.Clear();
                    foreach (Estudiante est in estudiantes)
                    {
                        Console.WriteLine("{0,-36} {1,-30} {2,3}",est.Nombre);
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Seleccion 4");
                    break;
                case 5:
                    Console.WriteLine("Gracias por usar el programa");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Valor Invalidad");
                    break;
            }
        } while (val != 5);
            
    }

    public static Estudiante AddStudent(){
        Console.Clear();
        Estudiante estudiante = new Estudiante();
        Console.WriteLine("Ingrese Id del Estudiante");
        estudiante.Id =  Console.ReadLine();
        Console.WriteLine("Ingrese Nombre del Estudiante");
        estudiante.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese Email del Estudiante");
        estudiante.Email = Console.ReadLine();
        Console.WriteLine("Ingrese Edad del Estudiante");
        estudiante.Edad = int.Parse(Console.ReadLine());    
        return estudiante;
    }
}