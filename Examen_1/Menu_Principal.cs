using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    internal class Menu_Principal
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Agregar Empleados");
                Console.WriteLine("2. Consultar Empleados");
                Console.WriteLine("3. Modificar Empleados");
                Console.WriteLine("4. Borrar Empleados");
                Console.WriteLine("5. Inicializar Arreglos");
                Console.WriteLine("6. Reportes");

                Console.Write("\nSelecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nOpción seleccionada: Agregar Empleados\n");
                        break;
                    case 2:
                        Console.WriteLine("\nOpción seleccionada: Consultar Empleados\n");
                        break;
                    case 3:
                        Console.WriteLine("\nOpción seleccionada: Modificar Empleados\n");
                        break;
                    case 4:
                        Console.WriteLine("\nOpción seleccionada: Borrar Empleados\n");
                        break;
                    case 5:
                        Console.WriteLine("\nOpción seleccionada: Inicializar Arreglos\n");
                        break;
                    case 6:
                        int opcionReportes = 0;
                        do
                        {
                            Console.WriteLine("\nMenú de Reportes:");
                            Console.WriteLine("1. Consultar empleados");
                            Console.WriteLine("2. Listar todos los empleados.");
                            Console.WriteLine("3. Calcular y mostrar el promedio de los salarios.");
                            Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo de todos los empleados.");
                            Console.Write("\nSelecciona una opción: ");
                            opcionReportes = int.Parse(Console.ReadLine());

                            switch (opcionReportes)
                            {
                                case 1:
                                    Console.WriteLine("\nOpción seleccionada: Consultar empleados\n");
                                    break;
                                case 2:
                                    Console.WriteLine("\nOpción seleccionada: Listar todos los empleados\n");
                                    break;
                                case 3:
                                    Console.WriteLine("\nOpción seleccionada: Calcular y mostrar el promedio de los salarios\n");
                                    break;
                                case 4:
                                    Console.WriteLine("\nOpción seleccionada: Calcular y mostrar el salario más alto y el más bajo de todos los empleados\n");
                                    break;
                                default:
                                    break;
                            }
                        } while (opcionReportes != 4);
                        break;
                    default:
                        break;
                }
            } while (opcion != 6);
        }
    }
    
}
