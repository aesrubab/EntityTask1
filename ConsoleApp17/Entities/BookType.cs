namespace ConsoleApp17.Entities;

public class BookType : BaseEntity
{
    public string Name { get; set; }

    public IEnumerable<Book> Books { get; set;}
}

