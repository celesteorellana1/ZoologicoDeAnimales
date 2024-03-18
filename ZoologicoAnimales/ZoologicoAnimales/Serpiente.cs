using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Serpiente
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Serpiente(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionSerpiente()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones de la serpiente:");
            Console.WriteLine("La serpiente: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionSerpiente()
        {
            Console.WriteLine("El Serpiente esta deborando un raton");
        }
        public void SonidoSerpiente()
        {
            Console.WriteLine("La serpiente comienza a comienza a hacer ZZZZZZZ");
        }
        public void MovimientosSerpiente()
        {
            Console.WriteLine("La serpiente se esconde entre los arbustos");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}