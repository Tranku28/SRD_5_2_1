namespace SRD_5_2_1.Domain;

public class Level
{
    private const int LEVEL_CAP = 20;
    private readonly Dictionary<int, int> LevelUpThresholds = new()
    {
        {1, 0},
        {2, 300},
        {3, 900},
        {4, 2_700},
        {5, 6_500},
        {6, 14_000},
        {7, 23_000},
        {8, 34_000},
        {9, 48_000},
        {10, 64_000},
        {11, 85_000},
        {12, 100_000},
        {13, 120_000},
        {14, 140_000},
        {15, 165_000},
        {16, 195_000},
        {17, 225_000},
        {18, 265_000},
        {19, 305_000},
        {20, 355_000}
    };

    public Level(int value)
    {
        Value = value;
    }

    public int Value 
    {
        get;
        set
        {
            if (value < 1 || value > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(Value), Value, "Level cannot exceed the range of 1 to 20");
            }

            field = value;
            XP = LevelUpThresholds[Value];
        }
    }

    public int XP {get; set;}

    public bool CanLevelUp()
    {
        if (Value == 20) return false;

        if (XP >= LevelUpThresholds[Value+1]) return true;

        return false;
    }

    public bool Up()
    {
        if (!CanLevelUp()) return false;

        int nextLevel = Value + 1;

        if (nextLevel > LEVEL_CAP)
        {
            return false;
        }

        Value++;
        return true;
    }
}