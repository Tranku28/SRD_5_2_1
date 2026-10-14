namespace SRD_5_2_1.Domain;

public class Random
{
    private static System.Random random = new();
    public static int Range(int min, int max)
    {
        if (min > max)
        {
            throw new ArgumentException("The minimum value must be less than or equal to the maximum value.");
        }
        
        return random.Next(min, max+1);
    }
}