using System;
namespace Coche_Solid.DESINGPATTERN.Decorator
{
    public abstract class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria cuentaBancaria;

        public CuentaDecorador(ICuentaBancaria cuenta)
        {
            this.cuentaBancaria = cuenta;
        }

        public virtual void AbrirCuenta(Cuenta cuenta)
        {
            this.cuentaBancaria.AbrirCuenta(cuenta);
        }
    }
}
