namespace PolymorphismExcercise
{
    public class DbCommand
    {
        public DbConnection connection { get; set; }
        public DbCommand(DbConnection dbconnection)
        {
            connection = dbconnection; ;
        }

        public void Execute()
        {
            SqlConnection sql = new SqlConnection(connection.ConnectionString);
            
            sql.OpenConnection();

            Console.WriteLine("Input SQL Comman: ");
            var command = Console.ReadLine();
            Console.WriteLine($"'{command}' has been executed.");

            sql.CloseConnection();
        }
    }
}