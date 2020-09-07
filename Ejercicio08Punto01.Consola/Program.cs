using Ejercicio08Punto01EnCapas.BL;
using Ejercicio08Punto01EnCapas.Dl;
using System;
using ConsoleTables;

namespace Ejercicio08Punto01.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositporiosDeTemperaturas repositorios = new RepositporiosDeTemperaturas();
            do
            {
                Console.Clear();
                #region MenuPrincipal
                int intOpcion;
                Console.Clear();
                Console.WriteLine("Menu principal");
                Console.WriteLine("0-Salir");
                Console.WriteLine("1-Ingresar datos");
                Console.WriteLine("2-Modificar datos");
                Console.WriteLine("3-listar datos");
                Console.WriteLine("4-Estadisticas de datos");
                Console.WriteLine("5-Listado estadisticos");
                Console.WriteLine("6-Ordenar datos");
                Console.WriteLine("7-Reiniciar");
                Console.WriteLine();

                do
                {
                    Console.Write("Ingrese una opcion del menu:");
                    if (!int.TryParse(Console.ReadLine(), out intOpcion))
                    {
                        Console.WriteLine("opcion mal ingresada, por favor verificar la opcion ingresada");
                    }
                    else
                    {
                        break;
                    }

                } while (true);
                #endregion

                #region opcionElegida
                string opcionElegida;
                switch (intOpcion)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 2:
                        ModificarDatosPorindice(repositorios);
                        break;
                    case 3:
                        MostrarDatos(repositorios);
                        break;
                    case 4:
                        EstadisticasDeDatos(repositorios);
                        break;
                   
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                #endregion 

            } while (true);
        }

        private static void ModificarDatosPorindice(RepositporiosDeTemperaturas repositorios)
        {
            Console.Clear();
            Console.WriteLine("Modificacion de datos x indice");
            Console.WriteLine();
            MostrarDatos(repositorios);
            var iIndice = 0;
            do
            {
                Console.WriteLine("Ingrese el elemnto a modificar:");
                if (!int.TryParse(Console.ReadLine(), out iIndice))
                {
                    Console.WriteLine("Indice mal ingresado ");
                    
                }
                else if (iIndice<1 || iIndice> repositorios.getTemperaturas(iIndice).Grados)
                {
                    Console.WriteLine("Indice fuera del rango permitido");
                }
                {
                    break;
                }


            } while (true);
            Console.WriteLine($"En la posicion {iIndice} tiene {repositorios.getTemperaturas(iIndice).Grados}");
            Console.WriteLine("Ingrese la nueva temperatura ");
            var NuevaTemperatura = double.Parse(Console.ReadLine());
            repositorios.ModificarTemperatura(NuevaTemperatura,iIndice);
        }

        private static void EstadisticasDeDatos(RepositporiosDeTemperaturas repositorios)
        {
            Console.Clear();
            Console.WriteLine("Estadistica de datos");
            Console.WriteLine();
            var Tabla = new ConsoleTable("Dato", "Resultado");
            Tabla.AddRow("Mayor Temperatura", repositorios.getMayorTemperatura());
            Tabla.AddRow("Menor Temperatura", repositorios.getMenorTemperatura());
            Tabla.AddRow("Promedio de Temperaturas", repositorios.getPromedioTemperaturas());
            Tabla.Write(Format.Alternative);
            Console.ReadLine();
        }

        private static void MostrarDatos(RepositporiosDeTemperaturas repositorios)
        {
            Console.Clear();
            Console.WriteLine("Lista de datos");
            Console.WriteLine();
            var iCantidad = repositorios.getCantidad();
            var Lista = repositorios.getLista();
            var Tabla=new ConsoleTable("Temperaturas","Fahrenheint","Reaumur");
            foreach (var temperaturas in Lista)
            {
                Tabla.AddRow(temperaturas.Grados, temperaturas.getGradosFahrenheit(), temperaturas.getGradosReaumur());
            }
            Tabla.AddRow($"Tiene:",iCantidad ,$"temperaturas ingresadas");
            Tabla.Write(Format.Alternative);
            Console.ReadLine();
        }
    }
}
