using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting.Antlr3.Runtime.Misc;

using UnityEngine;

public class Character
{
    public Seed Seed { get; private set; }
    public StatChart Stats { get; set; }
    public CharacterClass CharacterClass { get; set; }
    public int Level { get; private set; }

    private int Tier { get; set; }

    public Character(Seed seed, StatChart stats, CharacterClass characterClass, int level, int tier)
    {
        Seed = seed;
        Stats = stats;
        CharacterClass = characterClass;
        Level = level;
        Tier = 1;
    }

    public void UseSkill(Skill skill)
    {
        //check for character class and tier
        //check for skill level

    }

}

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

public class StatChart
{
    public int strength;       // Fuerza
    public int stamina;        // Aguante
    public int mind;           // Mente
    public int agility;        // Agilidad
    public int dexterity;      // Destreza
    public int perception;     // Percepción

}

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


