namespace MongoDotnetDemo.Models
{
    public class DatabaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; } 
        public string? CategoryCollectionName { get; set; }
        public string? ProductionCollectionName { get; set; }

    }
}
