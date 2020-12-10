namespace MyAquariumAPI
{
    public interface IBaseItem
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
