using System;
using LearningDotNetSeven2.Models;

namespace LearningDotNetSeven2
{
    internal class Program
    {
        static void Main(string[] args)
        {
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