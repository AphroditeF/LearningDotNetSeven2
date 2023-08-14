namespace LearningDotNetSeven2.Models
{
    public class Computer
    {
        public string Motherboard { get; set; } = "";
        public int CPUCores { get; set; }
        public bool HasWiFi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime RealeaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; } = "";
    }
}
