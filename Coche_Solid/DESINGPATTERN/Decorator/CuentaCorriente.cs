using System;
namespace Coche_Solid.DESINGPATTERN.Decorator
{
    public class CuentaCorriente : ICuentaBancaria
    {
        public CuentaCorriente()
        {
        }

        public void AbrirCuenta(Cuenta cuenta)
        {
            Console.WriteLine("Se abrio un cuenta Corriente para" + cuenta.Cliente);
        }
    }
}
