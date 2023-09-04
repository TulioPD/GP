using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterGenerator
{
    //unused class. Might use it for character generation later or character edit.
    public static Seed GenerateSeed()
    {
        return SeedGenerator.GenerateRandomSeed();
        
    }

    public static Character GenerateCharacter ()
    {
        Character newCharacter = new Character("Character test!", GenerateSeed(), new StatChart(), 1, 1 );
        return newCharacter;
    }
}
