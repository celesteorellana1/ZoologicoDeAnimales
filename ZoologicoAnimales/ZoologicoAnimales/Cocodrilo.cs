using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Cocodrilo
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Cocodrilo(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionCocodrilo()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Cocodrilo:");
            Console.WriteLine("El Cocodrilo: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionCocodrilo()
        {
            Console.WriteLine("El Cocodrilo esta comiendo carne");
        }
        public void SonidoCocodrilo()
        {
            Console.WriteLine("El Cocodrilo comienza a quejarse");
        }
        public void MovimientosCocodrilo()
        {
            Console.WriteLine("El Cocodrilo se sumerge en el agua");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}