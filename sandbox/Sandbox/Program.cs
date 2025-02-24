class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Circular World!");
        Circle myCircle = new Circle(100.0);
        Console.WriteLine("myCircle's Radius: " + myCircle.GetRadius());
        Console.WriteLine("myCircle's Circumference: " + myCircle.GetCircumference());
        Console.WriteLine("myCircle's Area: " + myCircle.GetArea());

        Cylinder myPuck = new Cylinder(10.0, 2.0);
        Console.WriteLine("myPuck's Radius: " + myPuck.GetRadius());
        Console.WriteLine("myPuck's Height: " + myPuck.GetHeight());
        Console.WriteLine("myPuck's base Circumference: " + myPuck.GetCircumference());
        Console.WriteLine("myPuck's base Area: " + myPuck.GetArea());
        Console.WriteLine("myPuck's Volume: " + myPuck.GetVolume());
        Console.WriteLine("myPuck's total Surface Area: " + myPuck.GetSurfaceArea());
    }
}