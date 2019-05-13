using System;
using Coche_Solid.Algoritmos;
using Coche_Solid.DESINGPATTERN;
using Coche_Solid.DESINGPATTERN.Decorator;
using Coche_Solid.DESINGPATTERN.Proxy;

namespace Coche_Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche[] coches = { new Audi(), new Mercedes(), new Renault() };

            ImprimirPrecioCoche(coches);
            ImprimirAsientos(coches);

            ApiServices aps = new ApiServices();

            DataAccess db = new DataAccess(aps);

            WebServices ws = new WebServices();
            db = new DataAccess(ws);


            /*Proxy test*/
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);

            /*Decorator pattern*/
            Cuenta cuenta = new Cuenta(1, 100, "Luis Vega");
            ICuentaBancaria cuentaAhorro = new CuentaAhorro();
            ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cuentaAhorro);
            cuentaBlindada.AbrirCuenta(cuenta);

            ICuentaBancaria cuentaCorriente = new CuentaCorriente();
            cuentaCorriente.AbrirCuenta(cuenta);


            //Mising Number
            int[] missing = { 1, 2, 3 ,4, 5, 6, 7, 8, 9, 10, 12, 13, 14 };
            MissingNumber mis = new MissingNumber(); 

            Console.WriteLine( mis.GetMissingNumber(missing, 13));
            Console.ReadLine();
        }

        public static void ImprimirPrecioCoche(Coche[] arrayCoches)
        {
            foreach (var item in arrayCoches)
            {
                Console.WriteLine(item.PrecioCoche().ToString());
            }
        }

        public static void ImprimirAsientos(Coche[] arrayCoches)
        {
            foreach (var item in arrayCoches)
            {
                Console.WriteLine(item.NumAsientos().ToString());
            }
        }

    }

}
