namespace XunitService.Models;

public class CSharpStudent : Student
{
    public int CourseId { get; set; }

    public int GetCourseId()
    {
        return 100;
    }
}