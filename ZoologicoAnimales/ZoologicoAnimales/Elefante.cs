using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Elefante
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Elefante(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionElefante()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Elefante:");
            Console.WriteLine("El Elefante: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionElefante()
        {
            Console.WriteLine("El Elefante esta tomando Agua");
        }
        public void SonidoElefante()
        {
            Console.WriteLine("El Elefante levanta la trompa y berrea");
        }
        public void MovimientosElefante()
        {
            Console.WriteLine("El Elefante corre");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}