namespace NZWalk.API.Models.DTO
{
    public class AddRegionRequestDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        // ? is null value
        public string? RegionImageUrl { get; set; }
    }
}
