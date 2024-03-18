using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class PavoReal
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public PavoReal(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionPavoReal()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del pavo real:");
            Console.WriteLine("El Elefante: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionPavoReal()
        {
            Console.WriteLine("El pavo real esta comiendo semillas");
        }
        public void SonidoPavoReal()
        {
            Console.WriteLine("El pavo real comienza a cantar glugluglu");
        }
        public void MovimientosPavoReal()
        {
            Console.WriteLine("El pavo real extiende sus alas");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
