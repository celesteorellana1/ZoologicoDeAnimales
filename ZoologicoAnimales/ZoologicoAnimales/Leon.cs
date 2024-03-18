using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Leon
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }
        public Leon(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionLeon()
        {
            Console.WriteLine("-----------------------------------------------------------------\n");
            Console.WriteLine($"Datos y especificaciones del Leon:");
            Console.WriteLine($"El Leon: {Nombre}, que pesa: {Peso}, su altura es de: {Altura}, y su genero es: {Genero}.");
        }

        public void AlimentacionLeon()
        {
            Console.WriteLine("El Leon se alimenta de carne.");
        }

        public void SonidoLeon()
        {
            Console.WriteLine("El Leon tiene un rugido fuerte.");
        }

        public void MovimientosLeon()
        {
            Console.WriteLine("El Leon puede corer con mucha velocidad");
        }
    }
}

