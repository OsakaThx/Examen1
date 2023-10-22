using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class menu
    {

        public static void AgregarEmpleado()
        {
            Console.Write("Ingrese la cédula: ");
            int cedula;
            if (int.TryParse(Console.ReadLine(), out cedula))
            {
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la dirección: ");
                string direccion = Console.ReadLine();

                Console.Write("Ingrese el teléfono: ");
                int telefono;
                if (int.TryParse(Console.ReadLine(), out telefono))
                {
                    Console.Write("Ingrese el salario: ");
                    decimal salario;
                    if (decimal.TryParse(Console.ReadLine(), out salario))
                    {
                        // Llamar al método de la clase Empleado para crear un empleado
                        Empleado.CrearEmpleado(cedula, nombre, direccion, telefono, salario);
                        Console.WriteLine("Empleado agregado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Salario no válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Teléfono no válido.");
                }
            }
            else
            {
                Console.WriteLine("Cédula no válida.");
            }
        }
        public static void MostrarInformacionEmpleadoPorCedula()
        {
            Console.Write("Ingrese la cédula del empleado: ");
            int cedula;
            if (int.TryParse(Console.ReadLine(), out cedula))
            {
                int indice = Array.IndexOf(Empleado.Cedula, cedula); // Buscar el índice por la cédula
                if (indice >= 0)
                {
                    string informacion = Empleado.ObtenerInformacionEmpleado(indice);
                    Console.WriteLine("※✥※∴※∴※✥※∴※∴※✥※※✥※∴※∴※✥※∴※∴※✥※※✥※∴※∴※✥※∴※∴※✥※");
                    Console.WriteLine("✎ ✐");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"Información del empleado {cedula}: {informacion}");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("✎ ✐");
                    Console.WriteLine("※✥※∴※∴※✥※∴※∴※✥※※✥※∴※∴※✥※∴※∴※✥※※✥※∴※∴※✥※∴※∴※✥※");
                }
                else
                {
                    Console.WriteLine("No se encontró un empleado con la cédula proporcionada.");
                }
            }
            else
            {
                Console.WriteLine("Cédula no válida.");
            }

        }


        public static void BorrarEmpleado()
        {
            Console.Write("Ingrese la cédula del empleado a borrar: ");
            int cedula;
            if (int.TryParse(Console.ReadLine(), out cedula))
            {
                int indice = Array.IndexOf(Empleado.Cedula, cedula); // Buscar el índice por la cédula
                if (indice >= 0)
                {
                    // Borrar la información del empleado si se encuentra
                    Empleado.Cedula[indice] = 0;
                    Empleado.Nombre[indice] = null;
                    Empleado.Direccion[indice] = null;
                    Empleado.Telefono[indice] = 0;
                    Empleado.Salario[indice] = 0m;
                    Empleado.Contador--;
                    Console.WriteLine($"Información del empleado con cédula {cedula} ha sido borrada.");
                }
                else
                {
                    Console.WriteLine("No se encontró un empleado con la cédula proporcionada.");
                }
            }
            else
            {
                Console.WriteLine("Cédula no válida.");
            }
        }
        public static void Modificar()
        {
            string respuesta;
            do {
                Console.Write("Ingrese la cédula del empleado a modificar: ");
                int cedula;
                if (int.TryParse(Console.ReadLine(), out cedula))
                {
                    int indice = Array.IndexOf(Empleado.Cedula, cedula); // Buscar el índice por la cédula
                    if (indice >= 0)
                    {
                        // Permitir al usuario seleccionar qué atributo desea modificar
                        Console.WriteLine("¿Qué atributo desea modificar?");
                        Console.WriteLine("1. Nombre");
                        Console.WriteLine("2. Teléfono");
                        Console.WriteLine("3. Dirección");
                        Console.WriteLine("4. Salario");

                        int opcion;
                        if (int.TryParse(Console.ReadLine(), out opcion))
                        {
                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese el nuevo nombre: ");
                                    string nuevoNombre = Console.ReadLine();
                                    Empleado.Nombre[indice] = nuevoNombre;
                                    break;
                                case 2:
                                    Console.WriteLine("Ingrese el nuevo teléfono: ");
                                    int nuevoTelefono;
                                    if (int.TryParse(Console.ReadLine(), out nuevoTelefono))
                                    {
                                        Empleado.Telefono[indice] = nuevoTelefono;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Teléfono no válido. No se realizaron modificaciones.");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Ingrese la nueva dirección: ");
                                    string nuevaDireccion = Console.ReadLine();
                                    Empleado.Direccion[indice] = nuevaDireccion;
                                    break;
                                case 4:
                                    Console.WriteLine("Ingrese el nuevo salario: ");
                                    decimal nuevoSalario;
                                    if (decimal.TryParse(Console.ReadLine(), out nuevoSalario))
                                    {
                                        Empleado.Salario[indice] = nuevoSalario;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Salario no válido. No se realizaron modificaciones.");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. No se realizaron modificaciones.");
                                    break;
                            }

                            Console.WriteLine("Atributo modificado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida. No se realizaron modificaciones.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontró un empleado con la cédula proporcionada. No se realizaron modificaciones.");
                    }
                }
                else
                {
                    Console.WriteLine("Cédula no válida. No se realizaron modificaciones.");

                }

                Console.Write("¿Desea seguir? (Y/N): ");
                respuesta = Console.ReadLine();
            } while (respuesta.Equals("Y", StringComparison.OrdinalIgnoreCase));
        }
        public static void InicializarDatos()
        {
            string respuesta;
        do { 

            Console.Write("Ingrese la cantidad de empleados: ");
            int cantidadEmpleados;
                if (int.TryParse(Console.ReadLine(), out cantidadEmpleados))
                {
                    Empleado.Cedula = new int[cantidadEmpleados];
                    Empleado.Nombre = new string[cantidadEmpleados];
                    Empleado.Telefono = new int[cantidadEmpleados];
                    Empleado.Direccion = new string[cantidadEmpleados];
                    Empleado.Salario = new decimal[cantidadEmpleados];

                    for (int i = 0; i < cantidadEmpleados; i++)
                    {
                        Console.Write("Cédula del empleado " + (i + 1) + ": ");
                        if (int.TryParse(Console.ReadLine(), out Empleado.Cedula[i]))
                        {
                            Console.Write("Nombre del empleado " + (i + 1) + ": ");
                            Empleado.Nombre[i] = Console.ReadLine();

                            Console.Write("Teléfono del empleado " + (i + 1) + ": ");
                            if (int.TryParse(Console.ReadLine(), out Empleado.Telefono[i]))
                            {
                                Console.Write("Dirección del empleado " + (i + 1) + ": ");
                                Empleado.Direccion[i] = Console.ReadLine();

                                Console.Write("Salario del empleado " + (i + 1) + ": ");
                                if (decimal.TryParse(Console.ReadLine(), out Empleado.Salario[i]))
                                {
                                    Console.WriteLine("Empleado " + (i + 1) + " registrado correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("Salario no válido. No se registró el empleado.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Teléfono no válido. No se registró el empleado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cédula no válida. No se registró el empleado.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Cantidad de empleados no válida. No se inicializaron los datos.");
                }
                Console.Write("¿Desea seguir? (Y/N): ");
                respuesta = Console.ReadLine();
            } while (respuesta.Equals("Y", StringComparison.OrdinalIgnoreCase));
        }

    }
}


