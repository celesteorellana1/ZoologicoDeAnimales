using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Oso
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Oso(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionOso()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Oso:");
            Console.WriteLine("El Oso: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionOso()
        {
            Console.WriteLine("El Oso esta comiendo mieeeel");
        }
        public void SonidoOso()
        {
            Console.WriteLine("El Oso Grune rawwwww!!");
        }
        public void MovimientosOso()
        {
            Console.WriteLine("El Oso comienza a trepar el arbol");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}