using System;
using Librarymanagementapp.Models;

namespace Librarymanagementapp.Database;

public class BookList
{
 public static List<BookStructure> books = new List<BookStructure>()
       {
                 new BookStructure("C_Programming", "hari","Cp",5,"05/06/2003",new List<string>{"Cp001","Cp002","Cp003","Cp004","Cp005"}),
   new BookStructure("C++","Ram","CPP",8,"04/15/2002",new List<string>{"CPP001","CPP002","CPP003","CPP004","CPP005","CPP006","CPP007","CPP008"}),
   new BookStructure("Java","Sita","JV",3,"07/20/2005",new List<string>{"JV001","JV002","JV003"})
       };
       public static List<string> BookIDs=new List<string>()
       {
             "Cp001","Cp002","Cp003","Cp004","Cp005","CPP001","CPP002","CPP003","CPP004","CPP005","CPP006","CPP007","CPP008","JV001","JV002","JV003"
       };
}
