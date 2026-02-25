namespace DbOperationWithEFCoreApp.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NoOfPages { get; set; }
        public bool IActive { get; set; }
        public DateTime CreatedOn { get; set; }

        //public int Country { get; set; }

        //For Foreign key purpose
        public int LanguageId { get; set; }
        public Language MyProperty { get; set; }
    }
}
