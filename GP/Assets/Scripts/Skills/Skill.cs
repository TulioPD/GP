public enum SkillType
{
    Attack,
    Buff,
    Debuff,
    Heal,
    Utility,
    Other
}

public class Skill
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Level { get; private set; }
    public SkillType SkillType { get; private set; }

    public void DoSomething()
    {
        // create a switch statement to check for skill type and do something
        switch (SkillType)
        {
            case SkillType.Attack:
                // do something
                break;
            case SkillType.Buff:
                // do something
                break;
            case SkillType.Debuff:
                // do something
                break;
            case SkillType.Heal:
                // do something
                break;
            case SkillType.Utility:
                // do something
                break;
            case SkillType.Other:
                // do something
                break;
            default:
                // do something
                break;
        }
    }


}