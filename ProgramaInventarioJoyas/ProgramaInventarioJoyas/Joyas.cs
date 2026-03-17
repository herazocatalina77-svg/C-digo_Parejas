using TrabajoenParejasPOO;

namespace ProgramaInventarioJoyas
{
    internal class Joyas
    {
        static bool disponible = false;
        static public void AgregarJoyaCliente() //Retorna un valor tipo diccionario
        {
            int seguirAgregando = 0; //saber si se desea agregar otra joya sin tener que salirse del menú
            do
            {
                //Llamar función agregar tipo joya
                TipoDeJoya.AgregarTipoJoyaPedido();
                //Llamar función agregar tipo piedra
                TipoDePiedra.AgregarTipoPiedra();
                Console.WriteLine("¿Desea seguir agregando joyas?");
                Console.WriteLine("Ingrese 1 en tal caso");
                Console.WriteLine("Imgrese 2 en caso contrario");
                seguirAgregando = Int32.Parse(Console.ReadLine() ?? "");
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
                VerPrecioJoyas(TipoDeJoya.tipoJoya);
            }
            else if (cambiarMetodo == "3")
            {
                VerJoyasDetalle(TipoDeJoya.tipoJoya, TipoDePiedra.tipoPiedra);
            }
        }

        static void VerPrecioJoyas(List<string> tipoJoya) //Funciona
        {

        }
        static public void IngresarInventarioJoya(List<int> cantidadPorJoya, List<int> cantidadPorPiedra) //Actualizar la información del stock para el tipo de joya- funciona
        {
            if (cantidadPorJoya.Count == 0 && cantidadPorPiedra.Count == 0)
            {
                //Función donde ingresa la el tipo de joya
                TipoDeJoya.IngresarInventarioTipoJoya();
                //Función donde ingresa el tipo de piedra
                TipoDePiedra.IngresarInventarioPiedras(); 
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
                Program.AbrirMenuPrincipal();
            }
            else
            {
                ActualizarInventario();
            }
        }
        static public void VerStock(List<int> cantidadPorJoya,List<int> cantidadPorPiedra) //En este método se le pregunta a la clase joya de la cantidad de joyas que hay por tipo de joya
        { //funciona
            string cambiarMetodo = "";
            List<string> tipoJoya = new List<string>(); //lista donde está cada tipo de joya
            tipoJoya.Add("Anillo");
            tipoJoya.Add("Pulsera");
            tipoJoya.Add("Collar");
            tipoJoya.Add("Tobillera");
            List<string> tipoPiedra = new List<string>(); //lista donde está cada tipo de joya
            tipoPiedra.Add("Diamante");
            tipoPiedra.Add("Zafiro");
            tipoPiedra.Add("Rubi");
            tipoPiedra.Add("Cuarzo Rosado");
            tipoPiedra.Add("Lapizlasuli");
            tipoPiedra.Add("Perla");
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
                Console.WriteLine("Tipo de joya - Cantidad ");

                for (int i = 0; i < tipoJoya.Count; i++)
                {
                    Console.WriteLine(tipoJoya[i] + " - " + cantidadPorJoya[i]);
                }
                Console.WriteLine("Tipo de piedra - Cantidad ");

                for (int i = 0; i < cantidadPorPiedra.Count; i++)
                {
                    Console.WriteLine(tipoPiedra[i] + " - " + cantidadPorJoya[i]);
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
                        opcionCorrecta = true;
                        //Llamar función de actualizar info en tipo de joya
                        TipoDeJoya.ActualizarInventarioTipoJoya(); 
                    }
                    else if (infoAmodificar == "2")
                    {
                        opcionCorrecta = true;
                        //Llamar la función de actualizar info de tipo de piedra
                        TipoDePiedra.ActualizarInventarioTipoPiedra();
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
