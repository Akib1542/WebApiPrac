namespace Application.Models
{
    public class GameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public List<ImageDTO> Images { get; set; }
    }
}
