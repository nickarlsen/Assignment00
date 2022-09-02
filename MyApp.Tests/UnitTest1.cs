namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Four_Returns_True()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"2004"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("True", output);
    }

    [Fact]
    public void Five_Returns_False()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"2005"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("False", output);
    }

    [Fact]
    public void Main_2100_Returns_False()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"2100"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("False", output);
    }

    [Fact]
    public void Main_2400_Returns_true()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"2400"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("True", output);
    }
}