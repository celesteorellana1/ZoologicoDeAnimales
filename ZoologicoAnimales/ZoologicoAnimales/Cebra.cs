using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Cebra
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Cebra(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void InformacionCebra()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones de la cebra:");
            Console.WriteLine("La cebra: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void AlimentacionCebra()
        {
            Console.WriteLine("La Cebra esta comiendo verduras");
        }
        public void SonidoCebra()
        {
            Console.WriteLine("La Cebra comienza a relinchar iuiaaa!!");
        }
        public void MovimientosCebra()
        {
            Console.WriteLine("La cebra se esconde detras de una roca");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
