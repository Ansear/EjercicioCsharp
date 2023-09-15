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
            string idBusca;
        try
        {
            idBusca = Console.ReadLine();
        }
        catch (NullReferenceException)
        {
            Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Dato ingresado invalido");
                Console.ReadLine();
            throw;
        }
        Estudiante alumno = lst.FirstOrDefault(st => st.Id.Equals(idBusca));
        if(alumno!=null){
            
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
            }else{
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

    public void ShowStudents(List<Estudiante> lts){
        Console.Clear();
        Console.WriteLine("{0,-28} {1,13}{2,33} {3,18} {4,18}","Codigo","Nombre","Quices","Trabajos","Parciales");
        Console.WriteLine("{0,65}{1,5}{2,5}{3,5} {4,8}{5,5} {6,10}{7,5}{8,5}","Q1","Q2","Q3","Q4","T1","T2","P1","P2","P3");
        Console.WriteLine(" ");
        if(lts.Count != 0){
            foreach (Estudiante est in lts)
            {
                float[] q = new float[4]{0,0,0,0};
                float[] t = new float[2]{0,0};
                float[] p = new float[3]{0,0,0};                    
                if(est.Quices.Count != 0){
                    for(int i=0; i<est.Quices.Count; i++){
                            q[i]= est.Quices[i];
                    }
                }
                if(est.Trabajos.Count != 0){
                    for(int i=0; i<est.Trabajos.Count; i++){
                            t[i]= est.Trabajos[i];
                    }
                }
                if(est.Parciales.Count != 0){
                    for(int i=0; i<est.Parciales.Count; i++){
                            p[i]= est.Parciales[i];
                    }
                    
                }
                Console.WriteLine("{0,-18}{1,40}{2,8}|{3,4}|{4,4}|{5,4}| {6,6}|{7,4}| {8,8}|{9,4}|{10,4}|",
                est.Id,
                est.Nombre,
                q[0]==0?"Np":q[0],
                q[1]==0?"Np":q[1],
                q[2]==0?"Np":q[2],
                q[3]==0?"Np":q[3],
                t[0]==0?"Np":t[0],
                t[1]==0?"Np":t[1],
                p[0]==0?"Np":p[0],
                p[1]==0?"Np":p[1],
                p[2]==0?"Np":p[2]);
            }
            Console.WriteLine();
            Console.WriteLine("Np = No Presento");
        }else{
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("En el momento no hay estudiantes registrados");
        }
        Console.ReadKey();
    }

    public void ShowStudentsDef(List<Estudiante> lts){
        Console.Clear();
        Console.WriteLine("{0,-28} {1,13} {2,33} {3,15} {4,15} {5,15}","Codigo","Nombre","Def Quices","Def Trabajos","Def Parciales","Nota Final");
        Console.WriteLine(" ");
        if(lts.Count != 0){
            foreach (Estudiante est in lts)
            {
                float[] q = new float[4]{0,0,0,0};
                float[] t = new float[2]{0,0};
                float[] p = new float[3]{0,0,0};
                float Tq = 0.0f;
                float Tt = 0.0f;
                float Tp = 0.0f;
                foreach (Estudiante item in lts)
                {
                    if(item.Id == est.Id){
                        
                            if(item.Quices.Count != 0){
                                for(int i=0; i<item.Quices.Count; i++){
                                        q[i]= item.Quices[i];
                                }
                            }
                            if(item.Trabajos.Count != 0){
                                for(int i=0; i<item.Trabajos.Count; i++){
                                        t[i]= item.Trabajos[i];
                                }
                            }
                            if(item.Parciales.Count != 0){
                                for(int i=0; i<item.Parciales.Count; i++){
                                        p[i]= item.Parciales[i];
                                }
                                
                            }
                    }
                }
                foreach (float item in q)
                {
                    Tq+=item;
                }
                foreach (float item in t)
                {
                    Tt+=item;
                }
                foreach (float item in p)
                {
                    Tp+=item;
                }
                float to = ((Tp/3)+(Tq/4)+(Tt/2))/3;
                Console.WriteLine("{0,-18} {1,40}| {2,12}| {3,12}| {4,12}| {5,15}|",
                est.Id,
                est.Nombre,
                (Tq/4).ToString("F1"),
                (Tt/2).ToString("F1"),
                (Tp/3).ToString("F1"),
                to.ToString("F1"));
            }
        }else{
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("En el momento no hay estudiantes registrados");
        }
        Console.ReadKey();
    }
}