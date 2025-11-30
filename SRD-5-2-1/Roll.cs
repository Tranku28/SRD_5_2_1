namespace SRD5_2_1;

public static class Roll
{
    public static int D2 => Random.Next(1, 2);
    public static int D3 => Random.Next(1, 3);
    public static int D4 => Random.Next(1, 4);
    public static int D6 => Random.Next(1, 6);
    public static int D8 => Random.Next(1, 8);
    public static int D10 => Random.Next(1, 10);
    public static int D12 => Random.Next(1, 12);
    public static int D20 => Random.Next(1, 20);
    public static int D100 => Random.Next(1, 100);
}