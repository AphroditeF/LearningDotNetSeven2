using System;
using LearningDotNetSeven2.Models;

namespace LearningDotNetSeven2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString= "Server=(local);Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";
            IDbConnection dbConnection = new SqlConnection(connectionString);

            string sqlCommand="SELECT GETDATE()";

            DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);

            Console.WriteLine(rightNow);
            
            Computer myComputer=new Computer(){
                Motherboard="Z690",
                HasWiFi=true,
                HasLTE=false,
                RealeaseDate=DateTime.Now,
                Price=943.87m,
                VideoCard="RTX 2060"
            };
            Console.WriteLine(myComputer.Motherboard);
        }
    }
}