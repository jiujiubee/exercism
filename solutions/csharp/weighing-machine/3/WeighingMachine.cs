using System.Reflection.Metadata.Ecma335;

class WeighingMachine
{
    private double _weight;
    public WeighingMachine(int precision) => Precision = precision;
    public int Precision { get; set; }
    public double Weight
    {
        get { return _weight; }
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            _weight = value;
        }
    }

    public double TareAdjustment { get; set; } = 5;
    public string DisplayWeight => $"{(_weight - TareAdjustment).ToString($"F{Precision}")} kg";
}
