namespace Application.Models
{
    public class ImageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public GameDTO Game { get; set; }
    }
}
