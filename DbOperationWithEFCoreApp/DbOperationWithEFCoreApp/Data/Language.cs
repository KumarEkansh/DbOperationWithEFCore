namespace DbOperationWithEFCoreApp.Data
{
    public class Language
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    // foreign key for one -to many relation ship
        public ICollection<Book> Books { get; set; }
    }
}
