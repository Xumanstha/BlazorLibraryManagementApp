
public class StudentStructure
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Gender { get; set; }
    public string? Address { get; set; }
    public string? PhoneNo { get; set; }
    public string? Faculty { get; set; }
    public string? Semester { get; set; }
    public bool IsEdit { get; set; } = false;
    public List<string> BorrowedBooks = new List<string>();
    
    public List<string> BooksId = new List<string>();
    public  int NumberOfBooks { get; set; } = 0;
    public StudentStructure(string id, string name, string gender, string address, string phoneno, string faculty, string semester)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Address = address;
        PhoneNo = phoneno;
        Faculty = faculty;
        Semester = semester;
    }
    public StudentStructure(string id, string name, string gender, string address, string phoneno, string faculty, string semester, int num, IEnumerable<string> initialbooks)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Address = address;
        PhoneNo = phoneno;
        Faculty = faculty;
        Semester = semester;
        NumberOfBooks = num;
        BorrowedBooks = new List<string>(initialbooks);
    }
    public StudentStructure()
    {
        BorrowedBooks = new List<string>();
        BooksId=new List<string>();
    }
    public void AddBooks(string book,string bookid)
    {
        BorrowedBooks.Add(book);
        BooksId.Add(bookid);
        NumberOfBooks++;
    }
    public void RemoveBook(string book,string bookid)
    {
        if (BorrowedBooks.Contains(book)&&BooksId.Contains(bookid))
        {
            BorrowedBooks.Remove(book);
            BooksId.Remove(bookid);
            NumberOfBooks--;
        }

    }
}
