namespace SRD_5_2_1.Domain;

public struct Roll
{
    public int Value {get; set;}
    private Roll(int maxValue)
    {
        Value = Random.Range(1, maxValue);
    }
    public static Roll D3() => new(3);

    public static Roll D4() => new(4);
    public static Roll D6() => new(6);

    public static Roll D8() => new(8);

    public static Roll D10() => new(10);

    public static Roll D12() => new(12);

    public static Roll D20() => new(20);
}