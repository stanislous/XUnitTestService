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
    
    [Fact]
    public void StudentReturnPartOfTheNameByGettingFirstNameAndLastName()
    {
        var firstName = "Shehan";
        var lastName = "Eranga";
        var expectedName = "Eranga";

        var actualFullName = _student.CreateFullName(firstName, lastName);

        Assert.Contains(expectedName, actualFullName);
    }
    
    [Fact]
    public void ShouldPassTheExam()
    {
        //Arrange
        var marks = 85;
        //Act
        var actualValue = _student.IsPassedTheExam(marks);
        //Assert
        Assert.True(actualValue);
    }
    
    [Fact]
    public void ShouldFailTheExam()
    {
        //Arrange
        var marks = 65;
        //Act
        var actualValue = _student.IsPassedTheExam(marks);
        //Assert
        Assert.False(actualValue);
    }
}