class Costume
{
    // attributes (member variables)
    public string _headWear;
    public string _gloves;
    public string _shoes;
    public string _upperGarment;
    public string _lowerGarment;
    public string _accessory;

    // behaviors (member functions, or *methods*)
    public void ShowWardrobe()
    {
        string result = "";
        result += "Head covering: " + _headWear + "\n";
        result += "Hand covering: " + _gloves + "\n";
        result += "Foot covering: " + _shoes + "\n";
        result += "Torso covering: " + _upperGarment + "\n";
        result += "Leg covering: " + _lowerGarment + "\n";
        result += "Accessory: " + _accessory + "\n";
        Console.WriteLine(result);
    }
}