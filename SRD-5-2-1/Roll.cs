using System;

namespace SRD5_2_1;

public static class Roll
{
    private static readonly Random Rnd = new();
    public static int D6 => Rnd.Next(1, 6);
}