namespace Task2;

public class Dog : Animal
{
    public override void Eat()
    {
        GetName();
        System.Console.WriteLine($"Eating");
    }
}
