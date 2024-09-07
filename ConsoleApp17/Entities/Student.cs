
namespace ConsoleApp17.Entities;

public enum Gender
{
    Female,
    Male
}
public class Student : BaseEntity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string SchoolNumber { get; set; }
    public DateTime DateofBirth { get; set; }
    public Gender Gender { get; set; }
    public string Phonenumber { get; set; }
    public IEnumerable<Book> Books { get; set; }

}