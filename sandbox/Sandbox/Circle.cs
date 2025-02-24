class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        this.SetRadius(radius);
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public double GetCircumference()
    {
        return 2 * Math.PI * _radius;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}