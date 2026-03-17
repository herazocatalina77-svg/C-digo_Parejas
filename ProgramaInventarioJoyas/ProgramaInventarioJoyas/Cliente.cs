using System;
using System.Collections.Generic;
using System.Text;
using TrabajoenParejasPOO;

namespace ProgramaInventarioJoyas
{
    internal class Cliente
    {
        public string nombre { get; set; }
        public string cedula { get; set; }
        string telefono = "";
        public string mes = "";
        public int cantidadTotalJoyas;
        //static public List<string> infoCliente = new List<string>();
        public void AgregarCliente()    // Acá se ingresan los datos personales del cliente.
        {
            //Variable para seguir agregando cliente (?)
            int seguirIngresando = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-- Ingrese sus datos personales --");

                Console.WriteLine("Nombre completo");
                //nombre = Console.ReadLine() ?? "valor por defecto";
                nombre = Console.ReadLine() ?? "valor por defecto";
                //infoCliente.Add(nombre);

                Console.WriteLine("Cédula (con esta se identificará su orden)");
                //cedula = Console.ReadLine() ?? "valor por defecto";
                cedula = Console.ReadLine() ?? "valor por defecto";
                //infoCliente.Add(cedula);

                Console.WriteLine("Número de teléfono");
                telefono = Console.ReadLine() ?? "valor por defecto";
                //infoCliente.Add(telefono);

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
        static public void AgregarJoyaCliente()
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
                Joyas.VerPrecioJoyas(TipoDeJoya.tipoJoya);
            }
            else if (cambiarMetodo == "3")
            {
                Joyas.VerJoyasDetalle(TipoDeJoya.tipoJoya, TipoDePiedra.tipoPiedra);
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