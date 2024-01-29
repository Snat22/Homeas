using Domain.Models;
using Infrastructure.Services;

var student1 = new Student();
student1.Id = 1;
student1.Firstname = "Salmon";
student1.Lastname = "Salmonov";
student1.Address = "Zarafshon2";
student1.BirthDate = new DateTime(2002,12,22);

var student2 = new Student();
student2.Id = 2;
student2.Firstname = "Satorrr";
student2.Lastname = "SaTorov";
student2.Address = "Ispechak";
student2.BirthDate = new DateTime(2000,10,12);

var student3 = new Student();
student3.Id = 3;
student3.Firstname = "Ismoil";
student3.Lastname = "LAtion";
student3.Address = "Iskandarkul";
student3.BirthDate = new DateTime(1002,06,22);

StudentServices student11 = new StudentServices();
student11.AddStudent(student1);
student11.AddStudent(student2);
student11.AddStudent(student3);

foreach (var it in student11.GetStudent())
{
    System.Console.WriteLine($"ID: {it.Id}");
    System.Console.WriteLine($"FirstName: {it.Firstname}");
    System.Console.WriteLine($"LastNAme: {it.Lastname}");
    System.Console.WriteLine($"Adressec: {it.Address}");
    System.Console.WriteLine($"BirthDay: {it.BirthDate}");
    System.Console.WriteLine("<--------------------------->");
}
 
 var updatedSudents = new Student();
 updatedSudents.Id = 2;
 updatedSudents.Address = "SALOHIYAT";
 updatedSudents.Firstname = "Salohoddin";
 updatedSudents.BirthDate = new DateTime(1234,02,15);


 student11.UpdateStudent(updatedSudents);

foreach (var it in student11.GetStudent())
{
    System.Console.WriteLine($"ID: {it.Id}");
    System.Console.WriteLine($"FirstName: {it.Firstname}");
    System.Console.WriteLine($"LastNAme: {it.Lastname}");
    System.Console.WriteLine($"Adressec: {it.Address}");
    System.Console.WriteLine($"BirthDay: {it.BirthDate}");
    System.Console.WriteLine("<--------------------------->");
}

student11.Delete(1);
foreach (var it in student11.GetStudent())
{
    System.Console.WriteLine($"ID: {it.Id}");
    System.Console.WriteLine($"FirstName: {it.Firstname}");
    System.Console.WriteLine($"LastNAme: {it.Lastname}");
    System.Console.WriteLine($"Adressec: {it.Address}");
    System.Console.WriteLine($"BirthDay: {it.BirthDate}");
    System.Console.WriteLine("<--------------------------->");
}


System.Console.WriteLine("Teachers");

var teacher1 = new Teacher();
teacher1.Id = 1;
teacher1.Firstname = "Salmon";
teacher1.Lastname = "Salmonov";


var teacher2 = new Teacher();
teacher2.Id = 2;
teacher2.Firstname = "Abdughafor";
teacher2.Lastname = "Qahorov";



TeacherServices teacher11 = new TeacherServices();
teacher11.AddTeacher(teacher1);
teacher11.AddTeacher(teacher2);

foreach (var it in teacher11.GetTeacher())
{
    System.Console.WriteLine($"ID: {it.Id}");
    System.Console.WriteLine($"FirstName: {it.Firstname}");
    System.Console.WriteLine($"LastNAme: {it.Lastname}");
    System.Console.WriteLine("<--------------------------->");
}
 
 var updateTeacher = new Teacher();
 updatedSudents.Id = 2;
 updateTeacher.Lastname = "Isfandiyor";
 updateTeacher.Firstname = "Salon";


 teacher11.UpdateTeacher(updateTeacher);

foreach (var it in teacher11.GetTeacher())
{
    System.Console.WriteLine($"ID: {it.Id}");
    System.Console.WriteLine($"FirstName: {it.Firstname}");
    System.Console.WriteLine($"LastNAme: {it.Lastname}");
    System.Console.WriteLine("<--------------------------->");
}





