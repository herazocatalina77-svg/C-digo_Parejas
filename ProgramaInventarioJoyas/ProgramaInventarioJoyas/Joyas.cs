using TrabajoenParejasPOO;

namespace ProgramaInventarioJoyas
{
    internal class Joyas
    {
        static bool disponible = false;
        public static void VerPrecioJoyas(List<string> tipoJoya) //Funciona
        {
            TipoDeJoya.VerPrecioJoyaTipoJoya(tipoJoya);
            TipoDePiedra.VerPrecioJoyaTipoPiedra(tipoJoya);
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
                    //Regresa al menú principal
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
                        //Regresa al menú principal
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
        }
        static public void VerDisponibilidad() //Este método le pregunta a la clase joyas, si esa joya en específico está disponible ó no
        { //Sin probar
          //Ingresar la joya que se quiere ver si está en stock
          //Si la disponibilidad es falsa, entonces se muestran los resultados del condicional
            string joyaDisponible = "";
            Console.WriteLine("Ingrese la joya que desea ver la disponibilidad");
            joyaDisponible = Console.ReadLine() ?? "";
            if (disponible == false)
            {
                Console.Clear();
                Console.WriteLine("La joya se encuentra en stock.");
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("La joya no se encuentra en stock");
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
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
        }
    }
}
