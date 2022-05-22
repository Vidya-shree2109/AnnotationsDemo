using System;
using System.ComponentModel.DataAnnotations;

namespace AnnotationsDemo;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\t\t\t\t\tVALIDATION OF EMPLOYEE CLASS\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t----------------------------\t\t\t\t\t\n");

        Employee employee = new Employee();

        employee.Name = "XYZ";
        employee.Age = 20;
        employee.PhoneNumber = "4567853";
        employee.Email = "xyz@gmail.com";
        ValidationContext context = new ValidationContext(employee, null, null);
        List<ValidationResult> results = new List<ValidationResult>();
        bool valid = Validator.TryValidateObject(employee, context, results, true);
        if (!valid)
        {
            foreach (ValidationResult Totalresult in results)
            {
                Console.WriteLine("Member Name: {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                Console.WriteLine("Error Msg : {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
            }
        }
        else
        {
            Console.WriteLine("Name : " + employee.Name + "\n" + "Age : " + employee.Age + "\n" + "Phone Number : " + employee.PhoneNumber + "\n" + "Email : " + employee.Email);
        }
    }
}