using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGenerator
{
    Character Character { get; set; }
    Seed Seed { get; set; }

    public CharacterGenerator(Character character, Seed seed)
    {
        Character = character;
        Seed = seed;
    }

    public Character GenerateCharacter ()
    {
        Character.Name = "Test Name!";
        return Character;
    }
}
