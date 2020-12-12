namespace MyAquariumAPI.DTO
{
    public class BaseItemDTO : IBaseItemDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
