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
}