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
        public string telefono = "";
        public string mes = "";
        public int cantidadTotalJoyas;
        //static public List<string> infoCliente = new List<string>();
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
                //Regresa al menpu principal
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
            TipoDeJoya.tipoJoya = new List<string>();
            TipoDePiedra.tipoPiedra = new List<string>();
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

        }
    }
}