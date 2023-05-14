public class HumanCharacter : Character
{
    public int Intelligence { get; set; }
    public int Strength { get; set; }
    public int Toughness { get; set; }
    public int Dexterity { get; set; }
    public int Speed { get; set; }
    public int Perception { get; set; }

    public HumanCharacter(string name, float statIncreasePerLevel) : base(name, statIncreasePerLevel)
    {
        Intelligence = 0;
        Strength = 0;
        Toughness = 0;
        Dexterity = 0;
        Speed = 0;
        Perception = 0;
    }

    // other methods and properties specific to HumanCharacter
}
