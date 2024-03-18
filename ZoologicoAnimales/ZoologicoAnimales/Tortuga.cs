using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Tortuga
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Tortuga(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionTortuga()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones de la tortuga:");
            Console.WriteLine("La tortuga: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionTortuga()
        {
            Console.WriteLine("La tortuga esta comiendo algas marinas");
        }
        public void SonidoTortuga()
        {
            Console.WriteLine("La tortuga quiere morder y hace guazzzzzz!!");
        }
        public void MovimientosTortuga()
        {
            Console.WriteLine("La Tortuga empieza a nadar rapido");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
