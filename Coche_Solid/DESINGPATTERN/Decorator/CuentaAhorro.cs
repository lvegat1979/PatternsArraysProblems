using System;
namespace Coche_Solid.DESINGPATTERN.Decorator
{
    public class CuentaAhorro : ICuentaBancaria
    {
        public CuentaAhorro()
        {
        }

        public void AbrirCuenta(Cuenta cuenta)
        {
            Console.WriteLine("Se abrio un cuenta ahorro para" + cuenta.Cliente);
        }
    }
}
