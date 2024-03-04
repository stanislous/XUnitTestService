using XunitService.Models;

namespace XunitService;

public class StudentService
{
    public string CreateFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
    
    public bool IsPassedTheExam(int marks)
    {
        if(marks > 70)
            return true;
        return false;
    }

    public int GetStudentId(string email)
    {
        if (string.IsNullOrEmpty(email))
            throw new ArgumentException("Email is Required!");
        return 1;
    }

    public Student GetStudentCourseId(int courseId)
    {
        if (courseId == 100) return new CSharpStudent
        {
            Id = 12, 
            Email = "csharp@abc.com",
            Name = "csharp"
        };
        return new CSharpStudent()
        {
            Id = 45,
            Email = "java@abc.com",
            Name = "java"
        };
    }
}