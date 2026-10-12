
var dog1 = new Dog
{
    Name = ""
};
var dog2 = new Dog
{
    Name = "Enzo"
};

dog1.Bark(dog1.Name);
dog2.Bark(dog2.Name);

public class Dog
{
    public string Name { get; set; } = "";

    public string Bark(string name)
    {
        ArgumentNullException.ThrowIfNull(name);
        return $"{name} says voff voff";
    }
}