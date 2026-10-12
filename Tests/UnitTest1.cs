using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Interfaces;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void DogBarks()
    {
        var dog1 = new Dog
        {
            Name = "Blixten"
        };

        var actual = dog1.Bark(dog1.Name);

        Assert.Equal("Blixten says voff voff", actual);
    }
    [Fact]
    public void WrongDogBark()
    {
        var dog2 = new Dog
        {
            Name = "Enzo"
        };

        var actual = dog2.Bark(dog2.Name);

        Assert.Equal("Enzo says voff voff", actual);
    }
    [Fact]
    public void DogIsNull()
    {
        var dog3 = new Dog();


        Assert.Throws<ArgumentNullException>(() => dog3.Bark(null!));
    }

}
