using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio08Punto01EnCapas.BL
{
   public  class  Celsius
    {
        private double grados;

        public double  Grados
        {
            get { return grados; }
            set 
            {
                if (value<-70 || value >70)
                {
                    throw new Exception("Temperatura ingresada fuera de lo rangos permitidos");
                }
                grados = value; 
            }
        }

        public object getGradosReaumur()
        {
            return 0.8 * Grados;
        }

        // metodo constructor
        // encargado de crea los objetos celsius
        public Celsius()
        { 

        }

        public Celsius(double tempCelsius) 
        {
            Grados = tempCelsius;
        }
        public double getGradosFahrenheit() 
        {
            return 1.8 * Grados+32;
        }
    }
}
