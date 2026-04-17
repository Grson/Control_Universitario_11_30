using Xunit;

namespace UniversityGrades.Tests;

public class GradesTests
{
    [Fact]
    public void Test_PassingGrade()
    {
        int grade = 75;
        Assert.True(grade >= 60);
    }

    [Fact]
    public void Test_FailingGrade()
    {
        int grade = 45;
        Assert.False(grade >= 60);
    }
}
