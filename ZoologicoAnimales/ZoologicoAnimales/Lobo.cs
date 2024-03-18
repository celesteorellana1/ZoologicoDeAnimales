using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Lobo
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Lobo(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionLobo()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Lobo:");
            Console.WriteLine("El Lobo: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionLobo()
        {
            Console.WriteLine("El Lobo esta comiendo carne");
        }
        public void SonidoLobo()
        {
            Console.WriteLine("El Lobo comienza a aullar");
        }
        public void MovimientosLobo()
        {
            Console.WriteLine("El Lobo corre tras las cebras para devorarlas");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
