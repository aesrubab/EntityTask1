namespace ConsoleApp17.Entities;

public class StudentBook
{
    public int StudentId { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public Student Student { get; set; }
}
