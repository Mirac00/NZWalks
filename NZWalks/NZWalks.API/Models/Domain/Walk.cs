namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionsId { get; set; }
        public Guid WalkDifficultyyId { get; set; }

        //Nawigation Properties

        public Regions Regions { get; set; }
        public WalkDifficulty WalkDifficultyy { get; set; }

    }
}
