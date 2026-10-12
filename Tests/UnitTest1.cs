using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Interfaces;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void DogBarks()
    {
        var dog1 = new Dog();

        var actual = dog1.Bark(dog1.Name);

        Assert.Equal("Blixten says voff voff", actual);
    }
    [Fact]
    public void WrongDogBark()
    {
        var dog1 = new Dog();

        var actual = dog1.Bark(dog1.Name);

        Assert.Equal("Pelle says voff voff", actual);
    }

}
