using System;
namespace Coche_Solid.DESINGPATTERN
{
    // The RealSubject contains some core business logic. Usually, RealSubjects
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the RealSubject's code.
    public class RealSubject : ISubject
    {
        public RealSubject()
        {
        }

        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
