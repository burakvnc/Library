namespace LibraryApp.Application.DTO
{
    public class BookDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
