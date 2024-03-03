using ConsoleApp1;

namespace TestProject;

public class StudentServiceTest
{
    private readonly StudentService _student = new();

    [Fact]
    public void StudentReturnFullNameByGettingFirstNameAndLastName()
    {
        var firstName = "Shehan";
        var lastName = "Eranga";
        var expectedFullName = "shehan Eranga";

        var actualFullName = _student.CreateFullName(firstName, lastName);

        Assert.Equal(expectedFullName, actualFullName, ignoreCase: true);
    }
}