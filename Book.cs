public class Book{
public string? Author{get;set;}
public string? Title{get;set;}
public string?Id{get;set;}
public string?PublishDate{get;set;}
public int? BookCount{get;set;}

  public Book(string title, string author, string code, int bookCount,string date)
  {
      Title = title;
      Author = author;
      Id = code;
      BookCount = bookCount;
      PublishDate=date;
  }
}