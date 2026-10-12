
var dog1 = new Dog
{
    Name = "Blixten"
};
var dog2 = new Dog
{
    Name = "Enzo"
};

dog1.Bark(dog1.Name);
dog2.Bark(dog2.Name);

public class Dog
{
    public string Name { get; set; } = string.Empty;

    public string Bark(string name)
    {
        return $"{name} says voff voff";
    }
}