using ProgramaInventarioJoyas;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrabajoenParejasPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbrirMenuPrincipal();
        }
        static public void AbrirMenuPrincipal()
        {
            int opcion;
            bool opcionCorrecta = false;
            //RECORDAR TRY CATCH
            Console.Clear();
            Console.WriteLine(" °. Bienvenido/a al sistema de la joyería .°");
            Console.WriteLine("1. Agregar clientes");
            Console.WriteLine("2. Agregar pedido a cliente");
            Console.WriteLine("3. Mostrar información total de los clientes");
            Console.WriteLine("4. Ver la cantidad de joyas compradas por cliente");
            Console.WriteLine("5. Ver Stock");
            Console.WriteLine("6. Ingresar Stock- inventario");
            Console.WriteLine("7. Ver disponibilidad de una joya");
            Console.WriteLine("8. Salir");
            opcion = Int32.Parse(Console.ReadLine() ?? "");
            Cliente nuevoCliente = null;

            do
            {
                switch (opcion)
                {
                    case 1: //Crear Cliente - funciona
                        {
                            opcionCorrecta = true;
                            nuevoCliente = new Cliente();
                            nuevoCliente.AgregarCliente();
                            break;
                        }
                    case 2: //1/2, conectado con el case 4
                        {
                            Console.Clear();
                            nuevoCliente = new Cliente();
                            EncontrarCliente(Cliente.infoCliente);
                            Cliente.AgregarJoyaDelCliente(nuevoCliente.cantidadTotalJoyas);
                            Joyas.AgregarJoyaCliente();
                            break;
                        }
                    case 3: //Funciona
                        {
                            opcionCorrecta = true;
                            Console.Clear();
                            Cliente.VerInfoTotalClientes();
                            break;
                        }
                    case 4: //no funciona
                        {
                            opcionCorrecta = true;
                            Console.Clear();
                            EncontrarCliente(Cliente.infoCliente);
                            Cliente.VerJoyasCliente(TipoDeJoya.tipoJoya, nuevoCliente.nombre, nuevoCliente.cantidadTotalJoyas, nuevoCliente.cedula);
                            break;
                        }
                    case 5: //funciona
                        {
                            opcionCorrecta = true;
                            Console.Clear();
                            Joyas.VerStock(TipoDeJoya.cantidadPorJoya,TipoDePiedra.cantidadPorPiedra );
                            break;
                        }
                    case 6: //Funciona
                        {
                            opcionCorrecta = true;
                            Console.Clear();
                            Joyas.IngresarInventarioJoya(TipoDeJoya.cantidadPorJoya, TipoDePiedra.cantidadPorPiedra);
                            break;
                        }
                    case 7: //Sin probar
                        {
                            opcionCorrecta = true;
                            Joyas.VerDisponibilidad();
                            break;
                        }
                    case 8:
                        {
                            opcionCorrecta = true;
                            Console.Clear();
                            Console.WriteLine("byeee");
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese una opción válida");
                            Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                            Console.ReadKey();
                            AbrirMenuPrincipal();
                            break;
                        }
                }
            } while (opcionCorrecta == false); // Con esta condición nos aseguramos de que el algoritmo no se salga del rango de opciones
        }

        static public string EncontrarCliente(List<string> infoCliente)
        {
            string cedulabuscar = "";
            if (infoCliente.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No se encuentran clientes en este momento");
                Console.WriteLine("Intente ingresar usuarios primero");
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
                AbrirMenuPrincipal();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ingrese cédula del cliente");
                cedulabuscar = Console.ReadLine() ?? "";
                if (cedulabuscar != null && infoCliente.Contains(cedulabuscar))
                {
                    //Usuario encontrado
                    return cedulabuscar;
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado.");
                    Console.WriteLine("Intente ingresar el usuario primero ó rectificar que la cédula sea correcta");
                    Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                    Console.ReadKey();
                    AbrirMenuPrincipal();
                }

            }
            return cedulabuscar;
        }
    }
}
