using EjercicioCsharp.Entities;

namespace ejercicio1.Entities;
    public class Estudiante : NotasEstu
    {
        private string id;
        private string nombre;
        private string email;
        private int edad;
        private string direccion;
        
        public string Id
        {
            get{ return id; }
            set { id = value; }
        }
        
        public string Nombre
        {
            get{ return nombre; }
            set { nombre = value; }
        }
        public string Email
        {
            get{ return email; }
            set { email = value; }
        }
        public int Edad
        {
            get{ return edad; }
            set { edad = value; }
        }
        public string Direccion
        {
            get{ return direccion; }
            set { direccion = value; }
        }
        public Estudiante():base()
        {
        }
        public Estudiante(string id,string nombre,string email,int edad,string direccion,List<float> quices, List<float> trabajos,List<float> parciales):base(quices,trabajos,parciales){
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.edad = edad;
            this.direccion = direccion;
            this.Quices = quices;
            this.Trabajos = trabajos;
            this.Parciales = parciales;
        }

        public void AddStudent(List<Estudiante> estudiantes){
            Console.Clear();
            bool ban;
            Estudiante estudiante= new Estudiante();
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("|************Registro de Estudiantes************|");
                Console.WriteLine("Ingrese Id del Estudiante");
                string ide = Console.ReadLine();
                ban = false;
                if(estudiantes.Count != 0){
                    Estudiante r = estudiantes.Where(e => e.Id == ide).FirstOrDefault();
                    if(r == null){
                        if(ide.Length>0 && ide.Length<=15){
                            estudiante.Id = ide;
                            ban = false;
                        }else{
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Id del Estudiante mayor a 15 caracteres");
                            ban = true;
                        }
                    }else{
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("El id ya se encuentra registrado");
                        ban = true;
                        }
                }else{
                    if(ide.Length>0 && ide.Length<=15){
                            estudiante.Id = ide;
                            ban = false;
                        }else{
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Id del Estudiante mayor a 15 caracteres");
                            ban = true;
                        }
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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Direccion mayor a 35 caracteres, intente nuevamente");
                    ban = true;
                }
            } while (ban);
            estudiantes.Add(estudiante);
    }

    public void AddNotas(List<Estudiante> lst, int opcion){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("|************Menu de Registro de notas************|");
        Console.WriteLine("Ingrese el id del estudiante: ");
        string idBusca = Console.ReadLine();
        Estudiante alumno = lst.FirstOrDefault(st => st.Id.Equals(idBusca));
       
            if(alumno.Id == idBusca){
                Console.WriteLine("Por favor ingrese la nota del: ");
                switch (opcion)
                {
                    case 1:
                                if(alumno.Quices.Count<4)
                                {
                                        Console.WriteLine("Agregar notas del Quiz {0}, de 0 a 5,0",alumno.Quices.Count+1);
                                        float v = float.Parse(Console.ReadLine());
                                        if(v>0 && v<=5){
                                            alumno.Quices.Add(v);
                                        }else{
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Nota invalida");
                                        }
                                }else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Las notas de Quices ya estan completas maximo 4 notas");
                                    Console.ReadKey();
                                }
                            break;
                    case 2:
                            if(alumno.Trabajos.Count<2){
                                Console.WriteLine("Agregar notas del Trabajo {0}, de 0 a 5,0",alumno.Trabajos.Count+1);
                                float v = float.Parse(Console.ReadLine());
                                if(v>0 && v<=5){
                                    alumno.Trabajos.Add(v);
                                }else{
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Nota invalida");
                                }
                            }else{
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Las notas de Trabajos ya estan completas, maximo 2 notas");
                                Console.ReadKey();
                            }
                            break;
                    case 3:
                            if(alumno.Parciales.Count<3){
                                Console.WriteLine("Agregar notas del Parciale {0}, de 0 a 5,0",alumno.Parciales.Count+1);
                                float v = float.Parse(Console.ReadLine());
                                if(v>0 && v<=5){
                                    alumno.Parciales.Add(v);
                                }else{
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Nota invalida");
                                }
                            }else{
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Las notas de Parciales ya estan completas, maximo 3 notas");
                                Console.ReadKey();
                            }
                            break;
                    default:
                        Console.WriteLine("Valor ingresado invalido");
                        break;
                }  
                int idx = lst.FindIndex(x => x.Id.Equals(idBusca));
                lst[idx] = alumno;
            }
            else{
                Console.Clear();
                Console.WriteLine("No se encontro el id ingresado");
                Console.ReadKey();
            }
    }

    public void RemoveStu(List<Estudiante> lts)
    {
        Console.Clear();
        Console.Write("Ingrese el Id del estudiante a eliminar: ");
        string id = Console.ReadLine();
        Estudiante studentToRemove = lts.FirstOrDefault(st => (st.Id ?? string.Empty)
        .Equals(id)) ?? new Estudiante();
        if (studentToRemove != null)
        {
            lts.Remove(studentToRemove);
            MisFunciones.SaveData(lts);
        }else
        {
            Console.WriteLine("No se elimino el estudiante");
            Console.ReadKey();
        }
    }
}