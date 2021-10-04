using System;

namespace ConsoleApp1.Interfaces
{
    public interface IConnectable
    {
        IConnection Connect();
    }

    public interface IConnection
    {
        IAsyncResult ExecuteQuery(string query);
    }

}
