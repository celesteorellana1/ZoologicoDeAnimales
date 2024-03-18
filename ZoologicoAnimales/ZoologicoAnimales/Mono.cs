using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Mono
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Mono(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionMono()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Mono:");
            Console.WriteLine("El Mono: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionMono()
        {
            Console.WriteLine("El Mono esta comiendo bananos");
        }
        public void SonidoMono()
        {
            Console.WriteLine("El Mono comienza a gritar uah uah uah");
        }
        public void MovimientosMono()
        {
            Console.WriteLine("El Mono salta en las lianas!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
