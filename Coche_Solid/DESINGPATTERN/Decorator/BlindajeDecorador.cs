using System;
namespace Coche_Solid.DESINGPATTERN.Decorator
{
    public class BlindajeDecorador : CuentaDecorador
    {

        public BlindajeDecorador(ICuentaBancaria cuenta) : base(cuenta)
        {
        }

        public override void AbrirCuenta(Cuenta cuenta)
        {
            base.AbrirCuenta(cuenta);
            AgregarBlindajeCuenta(cuenta);

        }

        public void AgregarBlindajeCuenta(Cuenta cuenta) {

            Console.WriteLine("Added Blindaje" + cuenta.Cliente);
        }
    }
}
