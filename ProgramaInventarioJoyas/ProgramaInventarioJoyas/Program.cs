using ProgramaInventarioJoyas;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrabajoenParejasPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> infoClientes = new List<Cliente>();
            Cliente nuevoCliente = null;
            AbrirMenuPrincipal(nuevoCliente, infoClientes);
        }
        static public void AbrirMenuPrincipal(Cliente nuevoCliente, List<Cliente> infoClientes)
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
            do
            {
                switch (opcion)
                {
                    case 1: //Crear Cliente - funciona
                        {
                            opcionCorrecta = true;
                            //nuevoCliente = new Cliente();
                            AgregarCliente(nuevoCliente, infoClientes);
                            AbrirMenuPrincipal(nuevoCliente, infoClientes);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            //nuevoCliente = new Cliente();
                            EncontrarCliente(infoClientes);
                            //Instanciar objeto
                            Cliente.AgregarJoyaDelCliente(nuevoCliente.cantidadTotalJoyas);
                            Cliente.AgregarJoyaCliente();
                            AbrirMenuPrincipal(nuevoCliente, infoClientes);
                            break;
                        }
                    case 3: //Funciona
                        {
                            opcionCorrecta = true;
                            Console.Clear();
                            VerInfoTotalClientes(infoClientes);
                            AbrirMenuPrincipal(nuevoCliente, infoClientes);
                            break;
                        }
                    case 4:  
                        {
                            opcionCorrecta = true;
                            Console.Clear();
                            EncontrarCliente(infoClientes);
                            Cliente.VerJoyasCliente(TipoDeJoya.tipoJoya, nuevoCliente.nombre, nuevoCliente.cantidadTotalJoyas, nuevoCliente.cedula);
                            AbrirMenuPrincipal(nuevoCliente, infoClientes);
                            break;
                        }
                    case 5: //funciona
                        {
                            opcionCorrecta = true;
                            Console.Clear();
                            Joyas.VerStock(TipoDeJoya.cantidadPorJoya,TipoDePiedra.cantidadPorPiedra );
                            AbrirMenuPrincipal(nuevoCliente, infoClientes);
                            break;
                        }
                    case 6: //Funciona
                        {
                            opcionCorrecta = true;
                            Console.Clear();
                            Joyas.IngresarInventarioJoya(TipoDeJoya.cantidadPorJoya, TipoDePiedra.cantidadPorPiedra);
                            AbrirMenuPrincipal(nuevoCliente, infoClientes);
                            break;
                        }
                    case 7: //Sin probar
                        {
                            opcionCorrecta = true;
                            Joyas.VerDisponibilidad();
                            AbrirMenuPrincipal(nuevoCliente, infoClientes);
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
                            AbrirMenuPrincipal(nuevoCliente, infoClientes);
                            break;
                        }
                }
            } while (opcionCorrecta == false); // Con esta condición nos aseguramos de que el algoritmo no se salga del rango de opciones
        }
        static public List<Cliente> AgregarCliente(Cliente nuevoCliente, List<Cliente> infoClientes)    // Acá se ingresan los datos personales del cliente.
        {
            //nuevoCliente = new Cliente();
            //Variable para seguir agregando cliente (?)
            int seguirIngresando = 0;
            do
            {
                nuevoCliente = new Cliente();
                //infoClientes = new List<Cliente>();
                Console.Clear();
                Console.WriteLine("-- Ingresar datos personales del cliente--");
                Console.WriteLine("Nombre completo");
                nuevoCliente.nombre = Console.ReadLine() ?? "".ToUpper();
                Console.WriteLine("Cédula (con esta se identificará su orden)");
                nuevoCliente.cedula = Console.ReadLine() ?? "";
                Console.WriteLine("Número de teléfono");
                nuevoCliente.telefono = Console.ReadLine() ?? "valor por defecto";
                Console.WriteLine("Mes de compra");
                nuevoCliente.mes = Console.ReadLine() ?? "".ToUpper();
                infoClientes.Add(nuevoCliente);
                Console.Clear();
                Console.WriteLine("¿Desea Ingresar otro cliente? Ingrese 1 en tal caso");
                Console.WriteLine("Ingrese 2 en caso contrario");
                seguirIngresando = Int32.Parse(Console.ReadLine() ?? "");
            }
            while (seguirIngresando == 1);
            Console.WriteLine("Cliente/s registrado");
            Console.WriteLine("Ingrese cualquier tecla para continuar");
            Console.ReadKey();
            return infoClientes;
        }
        static public string EncontrarCliente(List<Cliente> infoClientes)
        {
            string cedulabuscar = "";
            if (infoClientes == null || infoClientes.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No se encuentran clientes en este momento");
                Console.WriteLine("Intente ingresar usuarios primero");
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ingrese cédula del cliente");
                cedulabuscar = Console.ReadLine() ?? "";
                //joyas.Any(j => j.Nombre.ToLower() == nombre.ToLower()))
                if (!string.IsNullOrWhiteSpace(cedulabuscar) && infoClientes.Any(item => item != null && item.cedula == cedulabuscar))
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
                }

            }
            return cedulabuscar;
        }
        static public void VerInfoTotalClientes(List<Cliente> infoCliente)
        {
            if (infoCliente ==   null || infoCliente.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No hay clientes registrados");
                Console.WriteLine("Ingrese clientes para que esta opción esté disponible");
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                //Aquí se muestra la lista con toda la información de los clientes
                Console.WriteLine("INFORMACIÓN DE LOS CLIENTES");
                Console.WriteLine("NOMBRE -- CÉDULA -- TELÉFONO");
                foreach (Cliente Cliente in infoCliente) //Recorrer la lista 
                {
                    Console.WriteLine($"{Cliente.nombre}-{Cliente.cedula}-{Cliente.telefono}"); //mostrar la lista
                }
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
            }
        }
    }
}
