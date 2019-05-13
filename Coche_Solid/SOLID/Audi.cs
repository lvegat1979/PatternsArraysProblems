using System;
namespace Coche_Solid
{
    /// <summary>
    /// Open and close responsability
    /// </summary>
    public class Audi : Coche
    {
        public Audi()
        {
        }

        public override double PrecioCoche()
        {
            return 103000;
        }

        public override int NumAsientos()
        {
            return 5;
        }
    }
}
