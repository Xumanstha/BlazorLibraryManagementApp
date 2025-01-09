 public class student
 {
     public string? Id {  get; set; }
     public string? Name {  get; set; }
     public string? Gender {  get; set; }
     public string? Address {  get; set; }
     public string? PhoneNo {  get; set; }
     public string? Faculty {  get; set; }
     public string? Semester {  get; set; }
     public bool IsEdit{get; set;}=false;
     public student (string id,string name,string gender,string address,string phoneno,string faculty,string Semester)
     {
        Id=id;
        Name=name;
        Gender=gender;
        Address=address;
        PhoneNo=phoneno;
        Faculty=faculty;
        this.Semester=Semester;

     }
 }