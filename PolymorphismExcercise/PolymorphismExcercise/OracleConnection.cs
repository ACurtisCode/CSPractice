namespace PolymorphismExcercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connect) : base(connect)
        {
        }

        public void OpenConnection()
        {


            if (ConnectionString == null)
            {
                throw new Exception("Connection String is Null");
            }
            else
            {
                Console.WriteLine($"Connected to database {ConnectionString}");
            }
        }

        public void CloseConnection()
        {
            Console.WriteLine("The Connection has been closed.");
        }

    }
}