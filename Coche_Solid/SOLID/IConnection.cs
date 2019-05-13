using System;

namespace Coche_Solid
{
    /// <summary>
    /// Dependecy segregation
    /// </summary>
    public interface IConnection
    {
        string getDatos();
        void setDatos(); 
    }
}
