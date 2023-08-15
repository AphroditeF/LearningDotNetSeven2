using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using Dapper;
using LearningDotNetSeven2.Models;
using Microsoft.Data.SqlClient;
using System.Globalization;

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
                ReleaseDate=DateTime.Now,
                Price=943.87m,
                VideoCard="RTX 2060"
            };

            Console.WriteLine(myComputer.Motherboard);

            string sql=@"INSERT INTO TutorialAppSchema.Computer (
                Motherboard,
                HasWiFi,
                HasLTE,
                ReleaseDate,
                Price,
                VideoCard
            ) VALUES('" + myComputer.Motherboard
                + "','" + myComputer.HasWiFi
                + "','" + myComputer.HasLTE
                + "','" + myComputer.ReleaseDate.ToString("yyyy-MM-dd")
                + "','" + myComputer.Price.ToString("0.00", CultureInfo.InvariantCulture)
                + "','" + myComputer.VideoCard
                + "')";

            Console.WriteLine(sql);

            int result = dbConnection.Execute(sql);
            Console.WriteLine("result:");
            Console.WriteLine(result);

            /*myComputer.*/

            string sqlSelect=@"SELECT Motherboard,
                HasWiFi,
                HasLTE,
                ReleaseDate,
                Price,
                VideoCard
                FROM TutorialAppSchema.Computer";


            IEnumerable<Computer>computers = dbConnection.Query<Computer>(sqlSelect);

            Console.WriteLine("'Motherboard','HasWiFi','HasLTE','ReleaseDate','Price','VideoCard'");

            foreach(Computer singleComputer in computers){
                Console.WriteLine("'" 
                + myComputer.Motherboard
                + "','" + myComputer.HasWiFi
                + "','" + myComputer.HasLTE
                + "','" + myComputer.ReleaseDate.ToString("yyyy-MM-dd")
                + "','" + myComputer.Price.ToString("0.00", CultureInfo.InvariantCulture)
                + "','" + myComputer.VideoCard
                + "'");
                
            
            }

            /*List<Computer>computers = dbConnection.Query<Computer>(sqlSelect).ToList();*/
        }
    }
}