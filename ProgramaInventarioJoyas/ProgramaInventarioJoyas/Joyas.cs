using System;
using System.Collections.Generic;
using System.Text;
using TrabajoenParejasPOO;

namespace ProgramaInventarioJoyas
{
    internal class Joyas
    {
        static bool disponible; //saber si la joya está disponible ó no
        static int escogertipodeJoya; //Escoger el usuario el Anillo, pulsera, collar, etc
        static public List<string> tipoJoya = new List<string>(); //Una lista con el tipo de joya que escoge el usuario
        static public int precioMaterial; //después miramos
        static public int escogerTipoPiedra; //Escoger el tipo de piedra que tiene la joya 
        static public List<string> tipoPiedra = new List<string>(); //El tipo de piedra que tiene cada joya
        //Variables con cantidad de cada uno
        //Contadores de cuantos hay por joya 
        //static int cantidadAnillos = 0;
        //static int cantidadPulseras = 0;
        //static int cantidadCollares = 0;
        //static int cantidadTobilleras = 0;
        //máximo de joyas que hay en stock por tipo de joya
        static int cantidadTotalAnillos = 0;
        static int cantidadTotalPulseras = 0;
        static int cantidadTotalCollares = 0;
        static int cantidadTotalTobilleras = 0;
        //Dictionary???????????????????????????????????
        static public List<int> cantidadPorJoya = new List<int>();
        //La información del diccionario está basado en dos listas

        static int precioJoya;

        static public void AgregarJoyaCliente() //Retorna un valor tipo diccionario
        {
            int seguirAgregando = 0; //saber si se desea agregar otra joya sin tener que salirse del menú
            do
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
                            //cantidadAnillos++;
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
                Console.Clear();
                Console.WriteLine("Ingrese la piedra que desea ser fabricada (Debe ser seleccionado el número enlistado). Tenemos:" +
                    "\n1. Diamante \n2. Zafiro \n3. Rubí \n4. Cuarzo Rozado \n5. Lapis Lazuli \n6. Perla");
                escogerTipoPiedra = Int32.Parse(Console.ReadLine() ?? "");

                switch (escogerTipoPiedra)
                {
                    case 1:
                        {
                            tipoPiedra.Add("Diamante");
                            Console.WriteLine("¿Desea agregar otra joya? Ingrese 1 en tal caso");
                            Console.WriteLine("Ingrese 2 en caso contrario");
                            seguirAgregando = Int32.Parse(Console.ReadLine() ?? "");
                            break;
                        }


                    case 2:
                        {
                            tipoPiedra.Add("Zafiro");
                            Console.WriteLine("¿Desea agregar otra joya? Ingrese 1 en tal caso");
                            Console.WriteLine("Ingrese 2 en caso contrario");
                            seguirAgregando = Int32.Parse(Console.ReadLine() ?? "");
                            break;
                        }


                    case 3:
                        {
                            precioMaterial = 45000;
                            tipoPiedra.Add("Rubí");
                            Console.WriteLine("¿Desea agregar otra joya? Ingrese 1 en tal caso");
                            Console.WriteLine("Ingrese 2 en caso contrario");
                            seguirAgregando = Int32.Parse(Console.ReadLine() ?? "");
                            break;
                        }


                    case 4:
                        {
                            tipoPiedra.Add("Cuarzo Rosado");
                            Console.WriteLine("¿Desea agregar otra joya? Ingrese 1 en tal caso");
                            Console.WriteLine("Ingrese 2 en caso contrario");
                            seguirAgregando = Int32.Parse(Console.ReadLine() ?? "");
                            break;
                        }


                    case 5:
                        {
                            tipoPiedra.Add("Lápiz lasuli");
                            Console.WriteLine("¿Desea agregar otra joya? Ingrese 1 en tal caso");
                            Console.WriteLine("Ingrese 2 en caso contrario");
                            seguirAgregando = Int32.Parse(Console.ReadLine() ?? "");
                            break;
                        }

                    case 6:
                        {
                            tipoPiedra.Add("Perla");
                            Console.WriteLine("¿Desea agregar otra joya? Ingrese 1 en tal caso");
                            Console.WriteLine("Ingrese 2 en caso contrario");
                            seguirAgregando = Int32.Parse(Console.ReadLine() ?? "");
                            break;
                        }
                }

                //int precioTotal = precioJoya + precioMaterial;
                //Console.Clear();
                //Console.WriteLine($"El precio total es de: {precioTotal}");

            }
            while (seguirAgregando == 1);
            string cambiarMetodo = "";
            Console.WriteLine("Presione 1 para regresar al menú principal");
            Console.WriteLine("Presione 2 para ver el precio de las joyas");
            Console.WriteLine("Presione 3 para ver la lista de joyas");
            cambiarMetodo = Console.ReadLine() ?? "Valor por defecto";
            if (cambiarMetodo == "1")
            {
                Program.AbrirMenuPrincipal();
            }
            else if (cambiarMetodo == "2")
            {
                VerPrecioJoya(tipoJoya);
            }
            else if (cambiarMetodo == "3")
            {
                VerJoyasDetalle(tipoJoya, tipoPiedra);
            }
        }

        static void VerPrecioJoya(List<string> tipoJoya) //Funciona
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
            }
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
            Console.ReadKey();
            Program.AbrirMenuPrincipal();
        }
        static public List<int> IngresarInventario() //Actualizar la información del stock- funciona
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
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad total de diamantes");
            //leer cantidad
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
            Console.ReadKey();
            Program.AbrirMenuPrincipal();
            return cantidadPorJoya;
        }
        static public void VerStock(List<int> cantidadPorJoya) //En este método se le pregunta a la clase joya de la cantidad de joyas que hay por tipo de joya
        { //funciona
            string cambiarMetodo = "";
            List<string> tipoJoya = new List<string>(); //lista donde está cada tipo de joya
            tipoJoya.Add("Anillo");
            tipoJoya.Add("Pulsera");
            tipoJoya.Add("Collar");
            tipoJoya.Add("Tobillera");
            if (cantidadPorJoya.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No hay stock registrado");
                Console.WriteLine("Intente ingresar el inventario primero");
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
                Program.AbrirMenuPrincipal();
            }
            else
            {
                Console.WriteLine("Tipo de joya - Cantidad --");

                for (int i = 0; i < tipoJoya.Count; i++)
                {
                    Console.WriteLine(tipoJoya[i] + " - " + cantidadPorJoya[i]);
                }
                Console.WriteLine("¿Desea modificar la información del inventario/stock?");
                Console.WriteLine("Ingrese 0 en tal caso, ingrese 1 para regresar al menú");
                cambiarMetodo = Console.ReadLine() ?? "";
                if (cambiarMetodo == "0")
                {
                    ActualizarInventario();
                }
                else
                {
                    Program.AbrirMenuPrincipal();
                }
            }
        }
        static void ActualizarInventario()
        {
            Console.Clear();
            string seguirModificando = "";
            string infoAmodificar = "";
            bool opcionCorrecta = false;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese el tipo de dato que desea modificar");
                    Console.WriteLine("1. Cantidad total de un tipo de joya");
                    Console.WriteLine("2. Cantidad total de un tipo de piedra");
                    Console.WriteLine("3. Regresar al menú principal");
                    infoAmodificar = Console.ReadLine() ?? "";
                    if (infoAmodificar == "1")
                    {
                        Console.Clear();
                        opcionCorrecta = true;
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
                    else if (infoAmodificar == "2")
                    {
                        opcionCorrecta = true;
                        string tipoPiedraModificar = "";
                        int nuevaCantidad = 0;
                        Console.WriteLine("Ingrese el tipo de piedra que desea modificar");
                        switch (tipoPiedraModificar)
                        {
                            case "1":
                                Console.Clear();
                                cantidadTotalAnillos = 0;
                                Console.WriteLine("Ingrese la nueva cantidad de diamantes en stock");
                                nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");

                                break;
                            case "2":
                                Console.Clear();
                                cantidadTotalPulseras = 0;
                                Console.WriteLine("Ingrese la nueva cantidad de zafiros en stock");
                                nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                                break;
                            case "3":
                                Console.Clear();
                                cantidadTotalCollares = 0;
                                Console.WriteLine("Ingrese la nueva cantidad de rubíes en stock");
                                nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                                break;
                            case "4":
                                Console.Clear();
                                cantidadTotalTobilleras = 0;
                                Console.WriteLine("Ingrese la nueva cantidad de cuarzo rosado en stock");
                                nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                                break;
                            case "5":
                                Console.Clear();
                                Console.WriteLine("Ingrese la nueva cantidad de lápizlásuli en stock");
                                nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                                break;
                            case "6":
                                Console.Clear();
                                Console.WriteLine("Ingrese la nueva cantidad de lápizlásuli en stock");
                                nuevaCantidad = Int32.Parse(Console.ReadLine() ?? "");
                                break;
                        }
                    }
                    else if (infoAmodificar == "3")
                    {
                        opcionCorrecta = true;
                        Program.AbrirMenuPrincipal();
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una opción válida");
                    }
                }
                while (opcionCorrecta == false);
                Console.Clear();
                Console.WriteLine("Información modificada");
                Console.WriteLine("¿Desea seguir modificando información? Ingrese 0 en tal caso");
                Console.WriteLine("Ingrese 1 en caso contrario");
                seguirModificando = Console.ReadLine() ?? "";
            }
            while (seguirModificando == "0");
            Program.AbrirMenuPrincipal();
        }
        static public void VerDisponibilidad() //Este método le pregunta a la clase joyas, si esa joya en específico está disponible ó no
        { //Sin probar
          //Ingresar la joya que se quiere ver si está en stock
          //Si la disponibilidad es falsa, entonces se muestran los resultados del condicional
            if (disponible == false)
            {
                Console.Clear();
                Console.WriteLine("La joya se encuentra en stock.");
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
                Program.AbrirMenuPrincipal();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("La joya no se encuentra en stock");
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
                Program.AbrirMenuPrincipal();
            }
        }
        static public void VerJoyasDetalle(List<string> TipoJoya, List<string> TipoPiedra)
        {
            Console.WriteLine("Tipo de joya - Tipo de piedra para la joya");

            for (int i = 0; i < TipoJoya.Count; i++)
            {
                Console.WriteLine(TipoJoya[i] + " - " + TipoPiedra[i]);
            }
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
            Console.ReadKey();
            Program.AbrirMenuPrincipal();
        }
    }
}
