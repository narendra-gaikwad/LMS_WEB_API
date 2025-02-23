namespace LMS_WEB_API.Models
{
    //public class Book
    //{
    //    public int Id { get; set; }
    //    public string Title { get; set; }
    //    public string Author { get; set; }
    //    public string ISBN { get; set; }
    //    public int TotalCopies { get; set; } = 0;  // Default to 0
    //    public int IssuedCopies { get; set; } = 0; // Default to 0

    //}

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int TotalCopies { get; set; } = 0;  // Default to 0
        public int IssuedCopies { get; set; } = 0; // Default to 0
        public bool IsIssued { get; set; } = false; // ✅ Add this property with a default value
    }


    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int TotalCopies { get; set; }
        public int IssuedCopies { get; set; }
        public int AvailableCopies { get; set; } // This will be calculated in API response
    }
}
