using System.Reflection.Metadata.Ecma335;
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
                            if(opcNotas>=0 && opcNotas<=3){
                                if(opcNotas != 0){
                                    estudiant.AddNotas(estudiantes, opcNotas);
                                    MisFunciones.SaveData(estudiantes);
                                }else{
                                    fligNotas = false;
                                }
                            }else{
                                Console.WriteLine("Opcion ingresada invalida...Enter para continuar");
                                Console.ReadKey();
                            }

                        }
                        break;
                    case 3:
                    bool fligRepor = true;
                        while (fligRepor)
                        {
                            int opcRepor = MisFunciones.Reportes();
                            if(opcRepor>=0 && opcRepor<=4){
                                switch(opcRepor){
                                    case 1: 
                                        Console.Clear();
                                        estudiant.ShowStudents(estudiantes);
                                        break;
                                    case 2:
                                        Console.Clear();
                                        estudiant.ShowStudentsDef(estudiantes);
                                        break;
                                    case 3:
                                        Console.Clear();
                                        estudiant.FindOne(estudiantes);
                                        break;
                                    case 4:
                                        Console.Clear();
                                        estudiant.FindOneDef(estudiantes);
                                        break;
                                    case 0:
                                        Console.Clear();
                                        fligRepor = false;
                                        break;
                                    default:
                                        Console.Clear();    
                                        Console.WriteLine("Valo ingresado invalido");
                                        Console.Write("Presion enter para continuar....");
                                        Console.ReadKey();
                                        break;
                                }
                            }else{
                                Console.WriteLine("Valo ingresado invalido");
                                Console.Write("Presion enter para continuar....");
                                Console.ReadKey();
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
    
}