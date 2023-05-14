using System;
using System.Collections.Generic;

public abstract class Character
{
    public int HealthPoints { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int ExperienceToLevelUp { get; set; }
    public float StatIncreasePerLevel { get; set; }

    public Character(string name, float statIncreasePerLevel)
    {
        Name = name;
        StatIncreasePerLevel = statIncreasePerLevel;
        Level = 1;
        Experience = 0;
        ExperienceToLevelUp = (int)Math.Pow(10, Level);
    }
}
