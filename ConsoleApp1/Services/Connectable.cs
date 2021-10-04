using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Services
{
    public class Connectable : IConnectable
    {
        public IConnection Connect()
        {
            return null;
        }

        public void GetData(string sqlConnectionString)
        {
            //change connection string to database with the given one
        }

        public void GetData(string filePath, string fileName)
        {
            //get data from the selected file in filePath
        }


    }
}
