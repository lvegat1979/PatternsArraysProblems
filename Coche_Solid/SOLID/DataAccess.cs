using System;
namespace Coche_Solid
{
    public class DataAccess
    {
        private IConnection connection;

        public DataAccess(IConnection connection)
        {
            this.connection = connection;

        }

        public DataAccess()
        {
        }

        public string GetDatos()
        {
            return this.connection.getDatos();
        }
    }
}
