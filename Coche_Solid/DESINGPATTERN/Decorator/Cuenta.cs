using System;
namespace Coche_Solid.DESINGPATTERN.Decorator
{
    public class Cuenta
    {
        public int Id { get; set; }
        public double Monto { get; set; }
        public string Cliente { get; set; }
        public Cuenta(int id, double monto, string cliente)
        {
            this.Id = id;
            this.Monto = monto;
            this.Cliente = cliente;
            
        }
    }
}
