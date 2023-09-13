using ejercicio1;
using ejercicio1.Entities;
using EjercicioCsharp.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        Estudiante estudiant = new Estudiante();    
        int val = 1;
        estudiantes = MisFunciones.LoadData();
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("|*************Menu Principal*************|");
            Console.WriteLine("1. Agregar Estudiante");
            Console.WriteLine("2. Agregar notas al Estudiante");
            Console.WriteLine("3. Reporte e informes de Estudiantes");
            Console.WriteLine("4. Eliminar Alumno");
            Console.WriteLine("5. Salir");
            Console.WriteLine("|****************************************|");
            try{
                val = Convert.ToInt16(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        do
                        {
                            estudiant.AddStudent(estudiantes);
                            MisFunciones.SaveData(estudiantes);
                            Console.WriteLine("¿Desea Agregar otro estudiante? si(Y) no(N)");
                        } while (Console.ReadLine().ToUpper() == "Y");
                        break;
                    case 2:
                        bool fligNotas = true;
                        while (fligNotas)
                        {
                            Console.Clear();
                            int opcNotas = MisFunciones.MenuNotas();
                            if(opcNotas != 0)
                            {
                                estudiant.AddNotas(estudiantes, opcNotas);
                                MisFunciones.SaveData(estudiantes);
                            }else
                            {
                                fligNotas = false;
                            }

                        }
                        break;
                    case 3:
                    bool fligRepor = true;
                        while (fligRepor)
                        {
                            int opcRepor = MisFunciones.Reportes();
                            switch(opcRepor){
                                case 1: 
                                    Console.Clear();
                                    estudiant.ShowStudents(estudiantes);
                                    break;
                                case 2:
                                    Console.Clear();
                                    break;
                                case 0:
                                    Console.Clear();
                                    fligRepor = false;
                                    break;
                                default:
                                    Console.Clear();    
                                    Console.WriteLine("Valo ingresadi invalido");
                                    Console.Write("Presion enter para continuar....");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        estudiant.RemoveStu(estudiantes);
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el programa");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Valor Invalidado");
                        Console.ReadLine();
                        break;
                }
            }catch(FormatException){
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Dato ingresado invalido");
                Console.ReadLine();
            }
        } while (val != 5);
    }
    

    
    // public static void ShowStudentsDef(List<Estudiante> estudiantes){
    //     Console.Clear();
    //     Console.WriteLine("{0,-28} {1,13} {2,33} {3,15} {4,15} {5,15}","Codigo","Nombre","Def Quices","Def Trabajos","Def Parciales","Nota Final");
    //     Console.WriteLine(" ");
    //     if(estudiantes.Count != 0){
    //         foreach (Estudiante est in estudiantes)
    //         {
    //             float[] q = new float[4]{0,0,0,0};
    //             float[] t = new float[2]{0,0};
    //             float[] p = new float[3]{0,0,0};
    //             float Tq = 0.0f;
    //             float Tt = 0.0f;
    //             float Tp = 0.0f;
    //             foreach (NotasEstu item in notas)
    //             {
    //                 if(item.IdEstudiante == est.Id){
                        
    //                         if(item.Quices.Count != 0){
    //                             for(int i=0; i<item.Quices.Count; i++){
    //                                     q[i]= item.Quices[i];
    //                             }
    //                         }
    //                         if(item.Trabajos.Count != 0){
    //                             for(int i=0; i<item.Trabajos.Count; i++){
    //                                     t[i]= item.Trabajos[i];
    //                             }
    //                         }
    //                         if(item.Parciales.Count != 0){
    //                             for(int i=0; i<item.Parciales.Count; i++){
    //                                     p[i]= item.Parciales[i];
    //                             }
                                
    //                         }
    //                 }
    //             }
    //             foreach (float item in q)
    //             {
    //                 Tq+=item;
    //             }
    //             foreach (float item in t)
    //             {
    //                 Tt+=item;
    //             }
    //             foreach (float item in p)
    //             {
    //                 Tp+=item;
    //             }
    //             float to = ((Tp/3)+(Tq/4)+(Tt/2))/3;
    //             Console.WriteLine("{0,-18} {1,40}| {2,12}| {3,12}| {4,12}| {5,15}|",
    //             est.Id,
    //             est.Nombre,
    //             (Tq/4).ToString("F1"),
    //             (Tt/2).ToString("F1"),
    //             (Tp/3).ToString("F1"),
    //             to.ToString("F1"));
    //         }
    //     }else{
    //         Console.ForegroundColor = ConsoleColor.DarkRed;
    //         Console.WriteLine("En el momento no hay estudiantes registrados");
    //     }
    //     Console.ReadKey();
    // }
    
}