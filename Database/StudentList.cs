using System;
using Librarymanagementapp.Models;

namespace Librarymanagementapp.Database;

public class StudentList
{
     public static List<StudentStructure> students = new List<StudentStructure>()
{
new StudentStructure("1", "Suman", "Male", "Devinagar", "0299028982", "BScCSIT", "3"),
new StudentStructure("2", "Saroj", "Male", "Drivertole", "786382638", "BScCSIT", "3"),
new StudentStructure("3", "Bikram", "Male", "Devinagar", "89374988747", "BScCSIT", "3")
};
}
