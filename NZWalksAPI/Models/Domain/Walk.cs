namespace NZWalksAPI.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string fullName { get; set; }
        public double length { get; set; }
        public Guid regionId { get; set; }
        public Guid walkDifficultyId { get; set; }

        // Navigation Properties
        public Region region { get; set; }
        public WalkDifficulty walkDifficulty { get; set; }
    }
}
