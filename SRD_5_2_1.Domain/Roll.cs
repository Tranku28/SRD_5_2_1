namespace SRD_5_2_1.Domain;

public struct Roll
{
    public int Value {get; set;}
    private Roll(int maxValue)
    {
        Value = Random.Range(1, maxValue);
    }
    public static Roll D3() => throw new NotImplementedException();

    public static Roll D4()
    {
        throw new NotImplementedException();
    }

    public static Roll D6()
    {
        throw new NotImplementedException();
    }

    public static Roll D8()
    {
        throw new NotImplementedException();
    }

    public static Roll D10()
    {
        throw new NotImplementedException();
    }

    public static Roll D12()
    {
        throw new NotImplementedException();
    }

    public static Roll D20()
    {
        throw new NotImplementedException();
    }

}