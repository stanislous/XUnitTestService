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
}