public class Player
{

    public int RollDie() => new Random().Next(1, 19);

    //appearently 0 is ok as return value so just NextDouble * 100;
    public double GenerateSpellStrength()
    {
        double returnVal = 0;
        while (returnVal == 0)
        {
            returnVal = new Random().NextDouble();
        }
        return returnVal + new Random().Next(0,99);

    }

}
