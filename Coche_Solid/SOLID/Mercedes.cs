using System;
namespace Coche_Solid
{
    /// <summary>
    /// Open an close responsability
    /// </summary>
    public class Mercedes : Coche
    {
        public Mercedes()
        {
        }

        public override int NumAsientos()
        {
            return 5;
        }

        public override double PrecioCoche()
        {
            return 2000;
        }
    }
}
