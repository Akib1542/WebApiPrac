namespace Domain
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public Game Game { get; set; }
    }
}
