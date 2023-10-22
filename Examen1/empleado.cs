using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Empleado
    {
        public static int Capacidad = 15;
        public static int[] Cedula = new int[Capacidad];
        public static string[] Nombre = new string[Capacidad];
        public static string[] Direccion = new string[Capacidad];
        public static int[] Telefono = new int[Capacidad];
        public static decimal[] Salario = new decimal[Capacidad];
        public static int Contador = 0;

        // Constructor para inicializar un registro de empleado
        public static void CrearEmpleado(int cedula, string nombre, string direccion, int telefono, decimal salario)
        {
            if (Contador < Capacidad)
            {
                Cedula[Contador] = cedula;
                Nombre[Contador] = nombre;
                Direccion[Contador] = direccion;
                Telefono[Contador] = telefono;
                Salario[Contador] = salario;
                Contador++;
            }
            else
            {
                Console.WriteLine("La capacidad máxima de registros se ha alcanzado.");
            }
        }

        // Getter para obtener la información de un empleado por su índice
        public static string ObtenerInformacionEmpleado(int indice)
        {
            if (indice >= 0 && indice < Contador)
            {
                return $"Cedula: {Cedula[indice]}, Nombre: {Nombre[indice]}, Dirección: {Direccion[indice]}, Teléfono: {Telefono[indice]}, Salario: {Salario[indice]}";
            }
            return "Índice fuera de rango.";
        }

        // Setter para modificar la información de un empleado por su índice
        public static void ModificarEmpleado(int indice, int cedula, string nombre, string direccion, int telefono, decimal salario)
        {
            if (indice >= 0 && indice < Contador)
            {
                Cedula[indice] = cedula;
                Nombre[indice] = nombre;
                Direccion[indice] = direccion;
                Telefono[indice] = telefono;
                Salario[indice] = salario;
            }
            else
            {
                Console.WriteLine("Índice fuera de rango.");
            }
        }
    }
}
