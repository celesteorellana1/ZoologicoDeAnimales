using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Panda
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Panda(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionPanda()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Panda:");
            Console.WriteLine("El Panda: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionPanda()
        {
            Console.WriteLine("El Panda esta comiendo bambu");
        }
        public void SonidoPanda()
        {
            Console.WriteLine("El Panda comienza a bostezar gzzzzzz!!");
        }
        public void MovimientosPanda()
        {
            Console.WriteLine("El Panda escala con sus garras un arbol gigante");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}