class Bin
{
    private string _denomination;
    private double _value;
    private int _count;

    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }
    public void Transaction(int count) 
    // value parameter should be negative for debit, positive for credit
    {
        _count += count;
    }
    public string GetDenomination()
    {
        return _denomination;
    }
    public double GetValue()
    {
        return _value;
    }
    public int GetCount()
    {
        return _count;
    }
    // public void SetCount(int amount)
    // {
    //     _count = amount;
    // }
}