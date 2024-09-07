namespace ConsoleApp17.Entities;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public int PageCount { get; set; }

    //one to many
    public int AuthorId { get; set; }
    public Author Author { get; set; }

    public int BookTypeId { get; set; }

    public BookType BookType { get; set; }
    public IEnumerable<Student> Students { get; set; }
}
