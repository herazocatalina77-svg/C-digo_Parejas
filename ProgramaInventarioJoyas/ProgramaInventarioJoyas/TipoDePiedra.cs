using System;
using System.Collections.Generic;
using System.Text;
using TrabajoenParejasPOO;

namespace ProgramaInventarioJoyas
{
    internal class TipoDePiedra:Joyas
    {
        protected static int escogerTipoPiedra; //Escoger el tipo de piedra que tiene la joya 
        public static List<string> tipoPiedra = new List<string>(); //El tipo de piedra que tiene cada joya
        public static List<int> cantidadPorPiedra = new List<int>(); //El tipo de piedra que tiene cada joya
        static int cantidadTotalDiamantes = 0;
        static int cantidadTotalZafiros = 0;
        static int cantidadTotalRubi = 0;
        static int cantidadTotalCuarzoRosado = 0;
        static int cantidadTotallazpislasuli = 0;
        static int cantidadTotalperla = 0;
        static int precioPiedra = 0;
        public static void AgregarTipoPiedra()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la piedra que desea ser fabricada (Debe ser seleccionado el número enlistado). Tenemos:" +
                "\n1. Diamante \n2. Zafiro \n3. Rubí \n4. Cuarzo Rozado \n5. Lapis Lazuli \n6. Perla");
            escogerTipoPiedra = Int32.Parse(Console.ReadLine() ?? "");

            switch (escogerTipoPiedra)
            {
                case 1:
                    {
                        tipoPiedra.Add("DIAMANTE");
                        cantidadTotalDiamantes--;
                        break;
                    }


                case 2:
                    {
                        tipoPiedra.Add("ZAFIRO");
                        cantidadTotalZafiros--;
                        break;
                    }


                case 3:
                    {
                        tipoPiedra.Add("RUBI");
                        cantidadTotalRubi--;
                        break;
                    }


                case 4:
                    {
                        tipoPiedra.Add("CUARZOROSADO");
                        cantidadTotalCuarzoRosado--;
                        break;
                    }


                case 5:
                    {
                        tipoPiedra.Add("LAPISLAZULI");
                        cantidadTotallazpislasuli--;
                        break;
                    }

                case 6:
                    {
                        tipoPiedra.Add("Perla");
                        cantidadTotalperla--;
                        break;
                    }
            }
            //int precioTotal = precioJoya + precioMaterial;
            //Console.Clear();
            //Console.WriteLine($"El precio total es de: {precioTotal}");

        }
        public static void IngresarInventarioPiedras()
        {
            Console.Clear();
            Console.WriteLine($"Ingrese la cantidad de diamantes");
            cantidadTotalDiamantes = Int32.Parse(Console.ReadLine() ?? "");
            cantidadPorPiedra.Add(cantidadTotalDiamantes);
            Console.WriteLine("Ingrese la cantidad total de zafiros");
            cantidadTotalZafiros = Int32.Parse(Console.ReadLine() ?? "");
            cantidadPorPiedra.Add(cantidadTotalZafiros);
            Console.WriteLine("Ingrese la cantidad total de rubies");
            cantidadTotalRubi = Int32.Parse(Console.ReadLine() ?? "");
            cantidadPorPiedra.Add(cantidadTotalRubi);
            Console.WriteLine("Ingrese la cantidad total de cuarzos rosados");
            cantidadTotalCuarzoRosado = Int32.Parse(Console.ReadLine() ?? "");
            cantidadPorPiedra.Add(cantidadTotalCuarzoRosado);
            //lapislasuli
            //perla
        }
       
        public static void ActualizarInventarioTipoPiedra()
        {
            string tipoPiedraModificar = "";
            int nuevaCantidad = 0;
            Console.WriteLine("Ingrese el tipo de piedra que desea modificar");
            Console.WriteLine("1.Diamante");
            Console.WriteLine("2.Zafiro");
            Console.WriteLine("3.Rubí");
            Console.WriteLine("4.Cuarzo Rosado");
            Console.WriteLine("5.Lapizlasuli");
            Console.WriteLine("6.Perla");
            tipoPiedraModificar = Console.ReadLine() ?? "";
            switch (tipoPiedraModificar)
            {
                case "1":
                    Console.Clear();
                    cantidadTotalDiamantes = 0;
                    Console.WriteLine("Ingrese la nueva cantidad de diamantes en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorPiedra[0] = nuevaCantidad;

                    break;
                case "2":
                    Console.Clear();
                    cantidadTotalZafiros = 0;
                    Console.WriteLine("Ingrese la nueva cantidad de zafiros en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorPiedra[2] = nuevaCantidad;
                    break;
                case "3":
                    Console.Clear();
                    cantidadTotalRubi = 0;
                    Console.WriteLine("Ingrese la nueva cantidad de rubíes en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorPiedra[3] = nuevaCantidad;
                    break;
                case "4":
                    Console.Clear();
                    cantidadTotalCuarzoRosado = 0;
                    Console.WriteLine("Ingrese la nueva cantidad de cuarzo rosado en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorPiedra[4] = nuevaCantidad;
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Ingrese la nueva cantidad de lápizlásuli en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorPiedra[5] = nuevaCantidad;
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Ingrese la nueva cantidad de lápizlásuli en stock");
                    nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                    cantidadPorPiedra[6] = nuevaCantidad;
                    break;
            }
        }
        static void VerPrecioJoyaTipoJoya(List<string> tipoJoya) //Funciona
        {
            foreach (string t in tipoPiedra)
            {

                if (tipoJoya.Contains("DIAMANTE"))
                {
                    precioPiedra = 45000;
                    Console.WriteLine($"El precio de la joya es {precioPiedra}");
                }
                else if (tipoJoya.Contains("ZAFIRO"))
                {
                    precioPiedra = 20000;
                    Console.WriteLine($"El precio de la joya es {precioPiedra}");
                }
                else if (tipoJoya.Contains("RUBI"))
                {
                    precioPiedra = 30000;
                    Console.WriteLine($"El precio de la joya es {precioPiedra}");
                }
                else if (tipoJoya.Contains("CUARZOROSADO"))
                {
                    precioPiedra = 65000;
                    Console.WriteLine($"El precio de la joya es {precioPiedra}");
                }
                else if (tipoJoya.Contains("LAPISLAZULI"))
                {
                    precioPiedra = 95000;
                    Console.WriteLine($"El precio de la joya es {precioPiedra}");
                }
                else if (tipoJoya.Contains("PERLA"))
                {
                    precioPiedra = 15000;
                    Console.WriteLine($"El precio de la joya es {precioPiedra}");
                }
                else
                {
                    Console.WriteLine("Escogiste una opción no válida");
                }
            }
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
            Console.ReadKey();
            Program.AbrirMenuPrincipal();
        }
    }
}
