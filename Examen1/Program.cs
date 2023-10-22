using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Program
    {
        static int opcion = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("※✥※∴※∴※✥※∴※∴※✥※※✥※∴※∴※✥※∴※∴※✥※※✥※∴※∴※✥※∴※∴※✥※");
                Console.WriteLine("1- Agregar Empleados");
                Console.WriteLine("2- Mostrar informacion de un empleado");
                Console.WriteLine("3- Borrar empleado");
                Console.WriteLine("4- Modificar informacion de un empleado");
                Console.WriteLine("5- Inicializar Vectores");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Digite una opción:");
                Console.WriteLine("※✥※∴※∴※✥※∴※∴※✥※※✥※∴※∴※✥※∴※∴※✥※※✥※∴※∴※✥※∴※∴※✥※");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        menu.AgregarEmpleado();
                        break;

                    case 2:
                        Console.Clear();
                        menu.MostrarInformacionEmpleadoPorCedula();
                        
                        
                        break;

                    case 3:
                        Console.Clear();
                        menu.BorrarEmpleado();
                        
                        break;

                    case 4:
                        Console.Clear();
                        menu.Modificar();


                        break;

                    case 5:
                        
                        Console.Clear();
                        menu.InicializarDatos();
                        break;



                    case 6:
                        Console.WriteLine("Saliendo del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            } while (opcion != 6);
        }
    }
}
