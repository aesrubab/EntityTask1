namespace ConsoleApp17.Entities;

public class Author : BaseEntity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public IEnumerable<Book> Books { get; set; }
}
