namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Four_Returns_yay()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"2004"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("yay", output);
    }

    [Fact]
    public void Five_Returns_nay()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"2005"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("nay", output);
    }

    [Fact]
    public void Main_2100_Returns_nay()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"2100"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("nay", output);
    }

    [Fact]
    public void Main_2400_Returns_yay()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"2400"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("yay", output);
    }

    [Fact]
    public void Main_24020_Returns_yay()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"24020"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("yay", output);
    }

    [Fact]
    public void Main_24018_Returns_nay()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var args = new string[] {"24018"};
        Program.Main(args);


        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("nay", output);
    }
}