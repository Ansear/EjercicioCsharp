using ejercicio1.Entities;
using EjercicioCsharp.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<NotasEstu> notas = new List<NotasEstu>();
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
                        AddStudent(estudiantes,notas);
                        Console.WriteLine("¿Desea Agregar otro estudiante? si(Y) no(N)");
                    } while (Console.ReadLine().ToUpper() == "Y");
                    break;
                case 2:
                    AddNotas(notas);
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
                    Console.Clear();
                    foreach (NotasEstu item in notas)
                    {
                        Console.WriteLine(item.IdEstudiante);
                        
                            foreach (int vak in item.Quices)
                            {        
                                Console.WriteLine(vak);
                            }
                            foreach (int vak in item.Parciales)
                            {        
                                Console.WriteLine(vak);
                            }
                            foreach (int vak in item.Trabajos)
                            {        
                                Console.WriteLine(vak);
                            }

                    }

                    Console.ReadKey();
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

    public static void AddStudent(List<Estudiante> estudiantes,List<NotasEstu> notas){
        Console.Clear();
        bool ban;
        Estudiante estudiant = new Estudiante();
        NotasEstu notasEst = new NotasEstu();
        do
        {
            Console.WriteLine("Ingrese Id del Estudiante");
            string ide = Console.ReadLine();
            if(ide.Length>0 && ide.Length<=15){
                estudiant.Id = ide;
                notasEst.IdEstudiante = ide;
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
                estudiant.Nombre = nom;
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
                estudiant.Email = email;
                ban = false;
            }else{
                Console.Clear();
                Console.WriteLine("Email mayor a 40 caracteres, intente nuevamente");
                ban = true;
            }
        } while (ban);
        Console.WriteLine("Ingrese Edad del Estudiante");
        estudiant.Edad = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.WriteLine("Ingrese Direccion del Estudiante");
            string dire = Console.ReadLine();
            if (dire.Length>0 && dire.Length<=35){
                estudiant.Direccion = dire;    
                ban = false;
            }else{
                Console.Clear();
                Console.WriteLine("Direccion mayor a 35 caracteres, intente nuevamente");
                ban = true;
            }
        } while (ban);
        estudiantes.Add(estudiant);
        notas.Add(notasEst);
    }

    public static void AddNotas(List<NotasEstu> p1){
        Console.Clear();
        Console.WriteLine("Ingrese el id del estudiante: ");
        string idBusca = Console.ReadLine();
        foreach (NotasEstu item in p1)
        {
            if(item.IdEstudiante == idBusca){
                Console.WriteLine("1. Agregar notas de Quices");
                Console.WriteLine("2. Agregar notas de Trabajos");
                Console.WriteLine("3. Agregar notas de Parciales");
                int valu = Convert.ToInt16(Console.ReadLine());
                switch (valu)
                {
                    case 1:
                        do
                        {
                            AddQuices(item);
                            Console.WriteLine("¿Desea Agregar nota de otro Quiz? si(Y) no(N)");
                        }while (Console.ReadLine().ToUpper() == "Y");
                        break;
                    case 2:
                        do
                        {
                            AddTrabajos(item);
                            Console.WriteLine("¿Desea Agregar nota de otro Trabajo? si(Y) no(N)");
                        } while (Console.ReadLine().ToUpper() == "Y");
                        break;
                    case 3:
                        do
                        {
                            AddParciales(item);
                            Console.WriteLine("¿Desea Agregar nota de otro Parcial? si(Y) no(N)");
                        } while (Console.ReadLine().ToUpper() == "Y");
                        break;
                    default:
                        Console.WriteLine("Valor ingresado invalido");
                        break;
                }   
            }
        }
        
        
    }

    public static void AddQuices(NotasEstu notasQ){
        if(notasQ.Quices.Count()<4){
                int toNo = notasQ.Quices.Count();
                Console.WriteLine($"Agregar notas del Quiz {toNo+1}");
                int va1 = Convert.ToInt16(Console.ReadLine());
                notasQ.Quices.Add(va1);
        }else{
            Console.WriteLine("Las notas de Quices ya estan completas");
        }
    }
    public static void AddTrabajos(NotasEstu notasQ){
        if(notasQ.Trabajos.Count()<2){
                int toNo = notasQ.Trabajos.Count();
                Console.WriteLine($"Agregar notas del Quiz {toNo+1}");
                int va1 = Convert.ToInt16(Console.ReadLine());
                notasQ.Trabajos[toNo] = va1;
        }else{
            Console.WriteLine("Las notas de Trabajos ya estan completas");
        }
    }
    public static void AddParciales(NotasEstu notasQ){
        if(notasQ.Parciales.Count()<3){
                int toNo = notasQ.Parciales.Count();
                Console.WriteLine($"Agregar notas del Quiz {toNo+1}");
                int va1 = Convert.ToInt16(Console.ReadLine());
                notasQ.Parciales[toNo] = va1;
        }else{
            Console.WriteLine("Las notas de Parciales ya estan completas");
        }
    }
}