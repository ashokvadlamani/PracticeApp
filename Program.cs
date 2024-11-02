using PracticeApp;

public class Kethan
{
    static void Main()
    {
        Conversions conversions = new Conversions();
        conversions.();
        // FullTimeEmployee empIdName = new FullTimeEmployee(7, "name");
        // Console.WriteLine(empIdName.Name);
        MethodOverloading methodOverloading = new MethodOverloading();
        methodOverloading.AddNumbers(3, 4);
        methodOverloading.AddNumbers(3.0,4.0);
        methodOverloading.AddNumbers("hi");
        MethodOverriding methodOverriding = new MethodOverriding();
        methodOverriding.GetAddress("3");
        IStudentService a = new StudentService();
        IStudentService b = new StudentServiceFromDB();


        

    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Student student = new Student{
//     Id=1,
//     Name="kethan",
//     Address="warangal",
//     Standard = 10
// };
// Student student2 = student;
// student2.Name = "ashok";
// Console.WriteLine(student.Name);
// int a = 5;
// int b = a;
// b= 6;
// Console.WriteLine(a);










