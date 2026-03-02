class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    public int RemainingMinutesInOven(int cur) => 40 - cur;
    public int PreparationTimeInMinutes(int layer) => 2*layer;
    public int ElapsedTimeInMinutes(int layer, int cur)
    {
        return PreparationTimeInMinutes(layer) + cur;
    }
}
