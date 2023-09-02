using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting.Antlr3.Runtime.Misc;

using UnityEngine;

public class Character
{
    public string Name { get; set; }
    public Seed Seed { get; private set; }
    public StatChart Stats { get; set; }
    public CharacterClass CharacterClass { get; set; }
    public int Level { get; private set; }

    private int Tier { get; set; }

    public Character(string Name,Seed seed, StatChart stats, int level, int tier)
    {
        this.Name = Name;
        this.Seed = seed;
        this.Stats = stats;
        this.Level = level;
        this.Tier = tier;
    }

    public void UseSkill(Skill skill)
    {
        //check for character class and tier
        //check for skill level

    }

}