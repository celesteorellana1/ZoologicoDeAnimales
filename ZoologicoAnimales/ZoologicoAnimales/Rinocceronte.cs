using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Rinoceronte
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Rinoceronte(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionRinoceronte()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Rinoceronte:");
            Console.WriteLine("El Rinoceronte: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionRinoceronte()
        {
            Console.WriteLine("El Rinoceronte esta comiendo de un arbol");
        }
        public void SonidoRinoceronte()
        {
            Console.WriteLine("El Rinoceronte comienza a barritar muy fuerte");
        }
        public void MovimientosRinoceronte()
        {
            Console.WriteLine("El Rinoceronte comienza a pelear");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}