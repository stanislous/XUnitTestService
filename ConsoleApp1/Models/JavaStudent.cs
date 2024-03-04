namespace XunitService.Models;

public class JavaStudent : Student
{
    public int CourseId { get; set; }

    public int GetCourseId()
    {
        return 200;
    }
}