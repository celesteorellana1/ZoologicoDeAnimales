using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Jirafa
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Jirafa(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionJirafa()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones de la Jirafa:");
            Console.WriteLine("La Jirafa: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionJirafa()
        {
            Console.WriteLine("La Jirafa come hojas del arbol");
        }
        public void SonidoJirafa()
        {
            Console.WriteLine("La Jirafa hace un ronquido");
        }
        public void MovimientosJirafa()
        {
            Console.WriteLine("La Jirafa comienza correr");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}