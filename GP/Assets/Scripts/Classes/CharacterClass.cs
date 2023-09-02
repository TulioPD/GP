public class CharacterClass
{
    public enum Class
    {
        Warrior,
        Mage,
        Rogue,
        Ranger,
        Cleric
    }

    public Class characterClass;
    public int level;
    public int experience;

    public void LevelUp()
    {
        level++;
    }

}