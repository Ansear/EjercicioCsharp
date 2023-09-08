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
            Console.WriteLine("3. Mostrar informacion Estudiantes");
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
                    Console.WriteLine("{0,-36} {1,-30} {2,-30} {3,-30} {4,-30}","Codigo","Nombre","Quices","Trabajos","Parciales");
                    // Console.WriteLine("{0,-36} {1,-30} {2,3}","Q1","Q2","Q3","Q4","Parciales");
                    foreach (Estudiante est in estudiantes)
                    {
                        Console.WriteLine("{0,-36} {1,-30}",est.Id,est.Nombre);
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
        bool ban;
        Estudiante estudiante = new Estudiante();
        do
        {
            Console.WriteLine("Ingrese Id del Estudiante");
            string ide = Console.ReadLine();
            if(ide.Length>0 && ide.Length<=15){
                estudiante.Id = ide;
                ban = false;
            }else{
                Console.Clear();
                Console.WriteLine("Id del Estudiante mayor a 15 caracteres");
                ban = true;
            }
        } while (ban);
        do
        {
            Console.WriteLine("Ingrese Nombre del Estudiante");
            
            string nom = Console.ReadLine();
            if(nom.Length>0 && nom.Length<=40){
                estudiante.Nombre = nom;
                ban= false;
            }else{
                Console.Clear();
                Console.WriteLine("Nombre mayor a 40 caracteres, intente nuevamente");
                ban = true;
            }
        } while (ban);
        do
        {
            Console.WriteLine("Ingrese Email del Estudiante");
            
            string email = Console.ReadLine();
            if (email.Length>0 && email.Length<=40){
                estudiante.Email = email;
                ban = false;
            }else{
                Console.Clear();
                Console.WriteLine("Email mayor a 40 caracteres, intente nuevamente");
                ban = true;
            }
        } while (ban);
        Console.WriteLine("Ingrese Edad del Estudiante");
        estudiante.Edad = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.WriteLine("Ingrese Direccion del Estudiante");
            string dire = Console.ReadLine();
            if (dire.Length>0 && dire.Length<=35){
                estudiante.Direccion = dire;    
                ban = false;
            }else{
                Console.Clear();
                Console.WriteLine("Direccion mayor a 35 caracteres, intente nuevamente");
                ban = true;
            }
        } while (ban);
        
        return estudiante;
    }
}