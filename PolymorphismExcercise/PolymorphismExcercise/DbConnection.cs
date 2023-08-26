namespace PolymorphismExcercise
{
    public class DbConnection
    {
        public string ConnectionString = "default";
        public TimeSpan Time { get; set; }       

        public DbConnection(string connect)
        {
           ConnectionString = connect;
        }
        
        
    }
}