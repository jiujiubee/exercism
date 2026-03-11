using System.Reflection.Metadata.Ecma335;

class WeighingMachine
{
    private float _weight;
    public WeighingMachine(int precision) => Precision = precision;
    public int Precision { get; set; }
    public float Weight
    {
        get { return _weight; }
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            _weight = value;
        }
    }

    public float TareAdjustment { get; set; } = 5;
    public string DisplayWeight => $"{(_weight - TareAdjustment)} kg";
}
