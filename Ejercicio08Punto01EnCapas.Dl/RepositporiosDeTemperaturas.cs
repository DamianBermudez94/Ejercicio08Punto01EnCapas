using Ejercicio08Punto01EnCapas.BL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio08Punto01EnCapas.Dl
{
    public class RepositporiosDeTemperaturas
    {
        public List<Celsius> Temperaturas { get; set; } = new List<Celsius>()
        { 
        new Celsius(17.8),
        new Celsius(15.8),
        new Celsius(8),
        new Celsius(4),
        new Celsius(5.8)
        };

        // Constructor por defecto
        public RepositporiosDeTemperaturas()
        {


        }

        // Metodo para almacenar elementos a la lista
        public void Agregar (Celsius celsius)
        {
            Temperaturas.Add(celsius);
        }

        // Muestra la cantidad de elementos almacenados que hay en lista
        public int getCantidad()
        {
            return Temperaturas.Count;

        }

        // Metodo que muestra la lista de temperaturas almacenadas
        public List<Celsius> getLista()
        {
            return Temperaturas;
        }

        public double getMayorTemperatura()
        {
            return Temperaturas.Max(t=> t.Grados);
        }

        public double getMenorTemperatura()
        {
            return Temperaturas.Min(t => t.Grados);
        }

        public double getPromedioTemperaturas()
        {
            return Temperaturas.Average(t => t.Grados);
        }

        public Celsius getTemperaturas(int iIndice)
        {
            return Temperaturas[iIndice];
        }

        public void ModificarTemperatura(double nuevaTemperatura, int iIndice)
        {
            Temperaturas[iIndice].Grados = nuevaTemperatura;
        }

    }

}
