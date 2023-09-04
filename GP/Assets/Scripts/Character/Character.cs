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

    public Character()
    {
        this.Name = "Character test!";
        this.Seed = SeedGenerator.GenerateRandomSeed();
        this.Stats = new StatChart();
        this.Level = 1;
        this.Tier = 1;
        Debug.Log("Character created!");
        //Debug.Log("Seed:");
        //this.Seed.DebugPrintSeed();
    }

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