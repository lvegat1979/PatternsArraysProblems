using System;
namespace Coche_Solid
{
    /// <summary>
    /// Open and Close responsability
    /// </summary>
    public class Renault : Coche
    {
        public Renault()
        {
        }

        public override double PrecioCoche()
        {
            return 5000;
        }

        public override int NumAsientos()
        {
            return 5;
        }

    }
}
