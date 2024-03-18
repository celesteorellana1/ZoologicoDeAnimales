using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Program
    {
        static void Main(string[] args)


        {
            bool abandonar = false;
            do
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine("BIENVENIDOS AL PROGRAMA DEL ZOOLOGICO");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Ingrese el numero de la accion que desee realizar");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Visitar Leon");
                Console.WriteLine("2. Visitar Elefante");
                Console.WriteLine("3. Visitar Jirafa");
                Console.WriteLine("4. Visitar Tigre");
                Console.WriteLine("5. Visitar Mono");
                Console.WriteLine("6. Visitar oso");
                Console.WriteLine("7. Visitar Cocodrilo");
                Console.WriteLine("8. Visitar Serpiente");
                Console.WriteLine("9. Visitar Pinguino");
                Console.WriteLine("10. Visitar Lobo");
                Console.WriteLine("11. Visitar Cebra");
                Console.WriteLine("12. Visitar Rinoceronte");
                Console.WriteLine("13. Visitar Panda");
                Console.WriteLine("14. Visitar Pavoreal");
                Console.WriteLine("15. Visitar Tortuga");
                if (!int.TryParse(Console.ReadLine(), out int ingresoUsuario))
                {
                    Console.WriteLine("Ingresa un numero valido.");
                    continue;
                }
                switch (ingresoUsuario)
                {
                    case 0: abandonar = true; 
                        break;
                    case 1:
                        Leon leon = new Leon("Marco", 4.50, 2.10, "Masculino");
                        leon.InformacionLeon();
                        leon.AlimentacionLeon();
                        leon.SonidoLeon();
                        leon.MovimientosLeon();
                        break;
                    case 2:
                        Elefante elefante = new Elefante("Sebastian", 240, 5.20, "Masculino");
                        elefante.InformacionElefante();
                        elefante.AlimentacionElefante();
                        elefante.SonidoElefante();
                        elefante.MovimientosElefante();
                        break;
                    case 3:
                        Jirafa jirafa = new Jirafa("Luna", 180, 3.5, "Femenino");
                        jirafa.InformacionJirafa();
                        jirafa.AlimentacionJirafa();
                        jirafa.SonidoJirafa();
                        jirafa.MovimientosJirafa();
                        break;
                    case 4:
                        Tigre tigre = new Tigre("Luis", 200, 1.30, "Masculino");
                        tigre.InformacionTigre();
                        tigre.AlimentacionTigre();
                        tigre.SonidoTigre();
                        tigre.MovimientosTigre();
                        break;
                    case 5:
                        Mono mono = new Mono("Jorge", 0.50, 0.45, "Masculino");
                        mono.InformacionMono();
                        mono.AlimentacionMono();
                        mono.SonidoMono();
                        mono.MovimientosMono();
                        break;
                    case 6:
                        Oso oso = new Oso("Winny", 350, 1.40, "Masculino");
                        oso.InformacionOso();
                        oso.AlimentacionOso();
                        oso.SonidoOso();
                        oso.MovimientosOso();
                        break;
                    case 7:
                        Cocodrilo cocodrilo = new Cocodrilo("Santi", 240, 0.90, "Masculino");
                        cocodrilo.InformacionCocodrilo();
                        cocodrilo.AlimentacionCocodrilo();
                        cocodrilo.SonidoCocodrilo();
                        cocodrilo.MovimientosCocodrilo();
                        break;
                    case 8:
                        Serpiente serpiente = new Serpiente("Eva", 2.50, 1.00, "Femenino");
                        serpiente.InformacionSerpiente();
                        serpiente.AlimentacionSerpiente();
                        serpiente.SonidoSerpiente();
                        serpiente.MovimientosSerpiente();
                        break;
                    case 9:
                        Pinguino pinguino = new Pinguino("Dexter", 60, 0.50, "Masculino");
                        pinguino.InformacionPinguino();
                        pinguino.AlimentacionPinguino();
                        pinguino.SonidoPinguino();
                        pinguino.MovimientosPinguino();
                        break;
                    case 10:
                        Lobo lobo = new Lobo("Robert", 50, 50.00, "Masculino");
                        lobo.InformacionLobo();
                        lobo.AlimentacionLobo();
                        lobo.SonidoLobo();
                        lobo.MovimientosLobo();
                        break;
                    case 11:
                        Cebra cebra = new Cebra("Celeste", 210, 1.25, "Femenino");
                        cebra.InformacionCebra();
                        cebra.AlimentacionCebra();
                        cebra.SonidoCebra();
                        cebra.MovimientosCebra();
                        break;
                    case 12:
                        Rinoceronte rinoceronte = new Rinoceronte("Lan", 650, 1.95, "Maculino");
                        rinoceronte.InformacionRinoceronte();
                        rinoceronte.AlimentacionRinoceronte();
                        rinoceronte.SonidoRinoceronte();
                        rinoceronte.MovimientosRinoceronte();
                        break;
                    case 13:
                        Panda panda = new Panda("Stive", 40, 0.50, "Masculino");
                        panda.InformacionPanda();
                        panda.AlimentacionPanda();
                        panda.SonidoPanda();
                        panda.MovimientosPanda();
                        break;
                    case 14:
                        PavoReal pavoreal = new PavoReal("Robyn", 7.00, 0.35, "Masculino");
                        pavoreal.InformacionPavoReal();
                        pavoreal.AlimentacionPavoReal();
                        pavoreal.SonidoPavoReal();
                        pavoreal.MovimientosPavoReal();
                        break;
                    case 15:
                        Tortuga tortuga = new Tortuga("Dinamita", 1.00, 0.20, "Femenino");
                        tortuga.InformacionTortuga();
                        tortuga.AlimentacionTortuga();
                        tortuga.SonidoTortuga();
                        tortuga.MovimientosTortuga();
                        break;
                    default: 
                        break;
                }
                    Console.Clear();
            } while (!abandonar);
       
            Console.ReadLine();


        }
    }
}