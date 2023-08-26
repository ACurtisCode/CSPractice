using System;

namespace PolymorphismExcercise
{
    public class Program
    {
         static void Main(string [] args)
        {
            DbConnection dbconnection = new DbConnection("password field + routing location + storage location");
            
            DbCommand controller = new DbCommand(dbconnection);

            controller.Execute();
        }

    }
}