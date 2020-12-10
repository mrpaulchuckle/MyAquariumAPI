namespace MyAquariumAPI.Models
{
    public class Tank : BaseItem, ITank
    {
        public double? CarbonDioxideLevel { get; set; }
        public double? NitrateLevel { get; set; }
        public double? Temperature { get; set; }
        public double? Salinity { get; set; }
        public bool IsFavourite { get; set; }
    }
}
