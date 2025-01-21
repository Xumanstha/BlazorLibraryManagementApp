public class BookStructure{
public string? Author{get;set;}
public string? Title{get;set;}
public string?Id{get;set;}
public string?PublishDate{get;set;}
public  int BookCount{get;set;}=0;
public  List<string> Bookid = new List<string>();
  public BookStructure(string title, string author, string code, int bookCount,string date)
  {
      Title = title;
      Author = author;
      Id = code;
      BookCount = bookCount;
      PublishDate=date;
  }
  public BookStructure(string title, string author, string code, int bookCount,string date,IEnumerable<string>initialid)
  {
      Title = title;
      Author = author;
      Id = code;
      BookCount = bookCount;
      PublishDate=date;
      Bookid=new List<string>(initialid);
  }
  public BookStructure()
  {
    Bookid=new List<string>();
  }
  public void AddBookid(string book)
    {
        Bookid.Add(book);
        BookCount++;
    }
    public void RemoveBookid(string book)
    {
      Bookid.Remove(book);
      BookCount--;
    }
}