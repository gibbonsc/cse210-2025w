class Cylinder:Circle
{
    private double _height;

    public Cylinder(double radius, double height):base(radius)
    {
        this.SetHeight(height);
    }
    public void SetHeight(double height)
    {
        _height = height;
    }
    public double GetHeight()
    {
        return _height;
    }
    public double GetVolume()
    {
        return this.GetArea() * _height;
    }
    public double GetSurfaceArea()
    {
        return 2 * this.GetArea() + this.GetCircumference() * _height;
    }
}