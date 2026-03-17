using System;
using System.Collections.Generic;
using System.Text;
using TrabajoenParejasPOO;

namespace ProgramaInventarioJoyas
{
    internal class TipoDeJoya:Joyas
    {
        static int cantidadTotalAnillos = 0;
        static int cantidadTotalPulseras = 0;
        static int cantidadTotalCollares = 0;
        static int cantidadTotalTobilleras = 0;
        static int escogertipodeJoya; //Escoger el usuario el Anillo, pulsera, collar, etc
        static public List<string> tipoJoya = null; //Una lista con el tipo de joya que escoge el usuario
        static public List<int> cantidadPorJoya = new List<int>();
        static int precioJoya;
        static public void AgregarTipoJoyaPedido()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el tipo de joya que desee según su número");
            Console.WriteLine("1. Anillo \n2. Pulsera \n3. Collar \n4. Tobillera");
            escogertipodeJoya = Int32.Parse(Console.ReadLine() ?? "");

            switch (escogertipodeJoya)
            {
                case 1:
                    {
                        tipoJoya.Add("ANILLO");
                        if (cantidadTotalAnillos == 0)
                        {

                        }
                        else
                        {
                            cantidadTotalAnillos--;
                        }
                    }
                    break;

                case 2:
                    {
                        tipoJoya.Add("PULSERA");
                        //cantidadPulseras++;
                        if (cantidadTotalPulseras == 0)
                        {

                        }
                        else
                        {
                            cantidadTotalPulseras--;
                        }
                    }
                    break;

                case 3:
                    {
                        tipoJoya.Add("COLLAR");
                        //cantidadCollares++;
                        if (cantidadTotalCollares == 0)
                        {

                        }
                        else
                        {
                            cantidadTotalCollares--;
                        }
                    }
                    break;

                case 4:
                    {
                        tipoJoya.Add("TOBILLERA");
                        //cantidadTobilleras++;
                        if (cantidadTotalTobilleras == 0)
                        {

                        }
                        else
                        {
                            cantidadTotalTobilleras--;
                        }
                    }
                    break;
            }
        }
        public static List<int> IngresarInventarioTipoJoya() //Actualizar la información del stock para el tipo de joya- funciona
        {
            Console.Clear();
            Console.WriteLine($"Ingrese la cantidad de Anillos");
            cantidadTotalAnillos = Int32.Parse(Console.ReadLine() ?? "");
            cantidadPorJoya.Add(cantidadTotalAnillos);
            Console.WriteLine("Ingrese la cantidad total de pulseras");
            cantidadTotalPulseras = Int32.Parse(Console.ReadLine() ?? "");
            cantidadPorJoya.Add(cantidadTotalPulseras);
            Console.WriteLine("Ingrese la cantidad total de collares");
            cantidadTotalCollares = Int32.Parse(Console.ReadLine() ?? "");
            cantidadPorJoya.Add(cantidadTotalCollares);
            Console.WriteLine("Ingrese la cantidad total de tobilleras");
            cantidadTotalTobilleras = Int32.Parse(Console.ReadLine() ?? "");
            cantidadPorJoya.Add(cantidadTotalTobilleras);
            return cantidadPorJoya;
        }
        public static void VerPrecioJoyaTipoJoya(List<string> tipoJoya) //Funciona
        {
            foreach (string item in tipoJoya)
            {
                if (tipoJoya.Contains("ANILLO"))
                {
                    precioJoya = 45000;
                    Console.WriteLine($"El precio de la joya es {precioJoya}");
                }
                else if (tipoJoya.Contains("PULSERA"))
                {
                    precioJoya = 20000;
                    Console.WriteLine($"El precio de la joya es {precioJoya}");
                }
                else if (tipoJoya.Contains("COLLAR"))
                {
                    precioJoya = 30000;
                    Console.WriteLine($"El precio de la joya es {precioJoya}");
                }
                else if (tipoJoya.Contains("TOBILLERA"))
                {
                    precioJoya = 15000;
                    Console.WriteLine($"El precio de la joya es {precioJoya}");
                }
                else
                {
                    Console.WriteLine("Escogiste una opción no válida");
                }
            }
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
            Console.ReadKey();
        }

        static public void ActualizarInventarioTipoJoya()
        {
            Console.Clear();
            string tipoJoyaModificar = "";
            int nuevaCantidad = 0;
            Console.WriteLine("Ingrese el tipo de joya que desea modificar");
            Console.WriteLine("1. Anillo");
            Console.WriteLine("2. Pulsera");
            Console.WriteLine("3. Collares");
            Console.WriteLine("4. Tobilleras");
            tipoJoyaModificar = Console.ReadLine() ?? "";
            switch (tipoJoyaModificar)
            {
                case "1":
                    Console.Clear();
                    cantidadTotalAnillos = 0;
                    Console.WriteLine("Ingrese la nueva cantidad de anillos en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorJoya[0] = nuevaCantidad;

                    break;
                case "2":
                    Console.Clear();
                    cantidadTotalPulseras = 0;
                    Console.WriteLine("Ingrese la nueva cantidad de pulseras en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorJoya[1] = nuevaCantidad;
                    break;
                case "3":
                    Console.Clear();
                    cantidadTotalCollares = 0;
                    Console.WriteLine("Ingrese la nueva cantidad de collares en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorJoya[1] = nuevaCantidad;
                    break;
                case "4":
                    Console.Clear();
                    cantidadTotalTobilleras = 0;
                    Console.WriteLine("Ingrese la nueva cantidad de tobilleras en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorJoya[1] = nuevaCantidad;
                    break;
            }
        }
    }
}
