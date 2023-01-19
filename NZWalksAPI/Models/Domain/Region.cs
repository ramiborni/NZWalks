namespace NZWalksAPI.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public double area { get; set; }
        public double latitude { get; set; }
        public double longtitude { get; set; }
        public int population { get; set; }

        // Navigation Property
        public IEnumerable<Walk> walks { get; set; }

    }
}
