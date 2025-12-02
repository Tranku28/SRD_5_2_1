namespace SRD5_2_1;

public class Random
{
    public static int Next(int minValue, int maxValue)
    {
        System.Random random = new();
        return random.Next(minValue, maxValue+1);
    }
}