using SRD5_2_1.Core;

bool found = false;
for (int i = 0; !found; i++)
{
    if (Roll.Multiple(DiceType.D100, 3) == 3)
    {
        Console.WriteLine($"Found on {i}");
        found = true;
    }
}
