class Fox : Animal
{
    private string _sound;
    public Fox(string name) : base(name)
    {
        _sound = "Ring-ding-ding-ding-dingeringeding!";
    }
    public void MakeSound()
    {
        Console.WriteLine($"{GetName()} says {_sound}");
    }
}
