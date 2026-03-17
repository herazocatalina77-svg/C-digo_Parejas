using System;
using System.Collections.Generic;
using System.Text;
using TrabajoenParejasPOO;

namespace ProgramaInventarioJoyas
{
    internal class Cliente
    {
        public string nombre = "";
        public string cedula = "";
        string telefono = "";
        public string mes = "";
        public int cantidadTotalJoyas;
        static public List<string> infoCliente = new List<string>();
        //static public Dictionary<string, string> clienteJoya = new Dictionary<string, string> (); //cliente, tipo de joyas
        public void AgregarCliente()    // Acá se ingresan los datos personales del cliente.
        {
            //Variable para seguir agregando cliente (?)
            int seguirIngresando = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-- Ingrese sus datos personales --");

                Console.WriteLine("Nombre completo");
                nombre = Console.ReadLine() ?? "valor por defecto";
                infoCliente.Add(nombre);

                Console.WriteLine("Cédula (con esta se identificará su orden)");
                cedula = Console.ReadLine() ?? "valor por defecto";
                infoCliente.Add(cedula);

                Console.WriteLine("Número de teléfono");
                telefono = Console.ReadLine() ?? "valor por defecto";
                infoCliente.Add(telefono);

                Console.WriteLine("Mes de compra");
                mes = Console.ReadLine() ?? "".ToUpper();
                Console.Clear();
                Console.WriteLine("¿Desea Ingresar otro cliente? Ingrese 1 en tal caso");
                Console.WriteLine("Ingrese 2 en caso contrario");
                seguirIngresando = Int32.Parse(Console.ReadLine() ?? "");
            }
            while (seguirIngresando == 1);
            Console.WriteLine("Cliente/s registrado");
            Console.WriteLine("Ingrese cualquier tecla para continuar");
            Console.ReadKey();
            Program.AbrirMenuPrincipal();

        }
        static public void VerInfoTotalClientes()
        {
            if (infoCliente.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No hay clientes registrados");
                Console.WriteLine("Ingrese clientes para que esta opción esté disponible");
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
                Program.AbrirMenuPrincipal();
            }
            else
            {
                Console.Clear();
                //Aquí se muestra la lista con toda la información de los clientes
                foreach (string infoCliente in infoCliente) //Recorrer la lista 
                {
                    Console.WriteLine(infoCliente); //mostrar la lista
                }
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
                Program.AbrirMenuPrincipal();
            }
        }
        static public int AgregarJoyaDelCliente(int cantidadTotalJoyas)  // Se determina la cantidad de joyas que el cliente.tiene guardadas en el programa
        {
            //Agregar únicamente la cantidad total de joyas al cliente en general
            cantidadTotalJoyas++;
            return cantidadTotalJoyas;
        }
        static public void VerJoyasCliente(List<string> tipoJoya, string nombre, int cantidadTotalJoyas, string cedula)
        { //no funciona :(
            Console.Clear();
            Console.WriteLine($"usuario: {nombre} \njoyas compradas : {cantidadTotalJoyas}");
            //for (int i = 0; i < tipoJoya.Count; i++)
            //{
            //    clienteJoya.Add(listaClientes[i], tipoJoya[i]);
            //}
            Console.WriteLine($"La cédula del cliente es {cedula}");
            foreach (string joya in tipoJoya) //Recorrer la lista 
            {
                Console.WriteLine(tipoJoya); //mostrar la lista
            }
            Console.WriteLine("presione cualquier tecla para regresar al menú principal");
            Console.ReadKey();
            Program.AbrirMenuPrincipal();

        }
    }
}