
var dog1 = new Dog();

dog1.Bark(dog1.Name);

public class Dog
{
    public string Name { get; set; } = "Blixten";

    public string Bark(string name)
    {
        return $"{name} says voff voff";
    }
}