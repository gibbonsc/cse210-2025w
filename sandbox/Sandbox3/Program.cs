class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Inheritance World!");

        Fox fox = new Fox("Ylvis the fox");
        Bird bird = new Bird("Blackbird");
        fox.MakeSound();
        bird.MakeSound();
    }
}
