using System;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class CharacterGenerator : MonoBehaviour
{
    public static Unity.Mathematics.Random random;
    public List<Character> characterList;
    //Awake method to initialize the random number generator and generate 4 characters
    private void Awake()
    {
        CharacterGenerator.random.InitState();
        //GenerateCharacters(4);
        //Initialize characterList and add the 4 characters to it using the GenerateCharacters method
        characterList = GenerateCharacters(4);
        SpawnCharacters(4);

    }

    private void SpawnCharacters(int charactersToSpawn)
    {
        GameObject characterDisplay = GameObject.Find("Character Display"); // Find the CharacterDisplay canvas in the scene
        for (int i = 0; i < charactersToSpawn; i++)
        {
            GameObject character = new GameObject();
            character.transform.SetParent(characterDisplay.transform); // Set the parent of the new GameObject to the CharacterDisplay canvas
            character.AddComponent<TextMeshProUGUI>();
            character.GetComponent<TextMeshProUGUI>().text = "Name: " + characterList[i].Name + "\n" + "Health Points: " + characterList[i].HealthPoints + "\n" + "Level: " + characterList[i].Level + "\n" + "Experience: " + characterList[i].Experience + "\n" + "Experience to level up: " + characterList[i].ExperienceToLevelUp + "\n";
            character.GetComponent<TextMeshProUGUI>().fontSize = 15;
            character.GetComponent<TextMeshProUGUI>().color = Color.red;
            character.GetComponent<TextMeshProUGUI>().color = Color.blue;
            character.GetComponent<TextMeshProUGUI>().color = Color.green;
            character.GetComponent<TextMeshProUGUI>().color = Color.yellow;
        }
    }


    static CharacterGenerator()
    {
        random = new Unity.Mathematics.Random();
    }

    private static readonly string[] names = { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Henry", "Isabelle", "Jack", "Kate", "Luke", "Mia", "Nancy", "Oliver", "Peggy", "Quincy", "Rachel", "Samantha", "Tom", "Ursula", "Victor", "Wendy", "Xander", "Yvette", "Zoe" };

    public static List<Character> GenerateCharacters(int amount)
    {
        List<Character> characters = new List<Character>();
        for (int i = 0; i < amount; i++)
        {
            characters.Add(GenerateCharacter());
        }

        foreach (Character character in characters)
        {
            Debug.Log("Name: " + character.Name);
            Debug.Log("Health Points: " + character.HealthPoints);
            Debug.Log("Level: " + character.Level);
            Debug.Log("Experience: " + character.Experience);
            Debug.Log("Experience to level up: " + character.ExperienceToLevelUp);
        }

        return characters;
    }

    public static Character GenerateCharacter()
    {
        if (ShouldGenerateHumanCharacter())
        {
            return GenerateHumanCharacter();
        }
        else
        {
            return GenerateNonHumanCharacter();
        }
    }

    public static bool ShouldGenerateHumanCharacter()
    {
        return random.NextFloat() < 0.5f;
    }

    public static T GenerateCharacterOfType<T>() where T : Character
    {
        string name = names[random.NextInt(0, names.Length)];
        float statIncrease = 0.1f;
        T character = (T)Activator.CreateInstance(typeof(T), name, statIncrease);
        character.HealthPoints = random.NextInt(1, 100);
        character.Level = random.NextInt(1, 100);
        character.Experience = random.NextInt(1, 100);
        character.ExperienceToLevelUp = (int)Mathf.Pow(10, character.Level);
        return character;
    }

    public static HumanCharacter GenerateHumanCharacter()
    {
        Debug.Log("C");
        HumanCharacter humanCharacter = GenerateCharacterOfType<HumanCharacter>();
        humanCharacter.Intelligence = random.NextInt(1, 100);
        humanCharacter.Strength = random.NextInt(1, 100);
        humanCharacter.Toughness = random.NextInt(1, 100);
        humanCharacter.Dexterity = random.NextInt(1, 100);
        humanCharacter.Speed = random.NextInt(1, 100);
        humanCharacter.Perception = random.NextInt(1, 100);
        Debug.Log("D");
        return humanCharacter;
    }

    public static NonHumanCharacter GenerateNonHumanCharacter()
    {
        NonHumanCharacter nonHumanCharacter = GenerateCharacterOfType<NonHumanCharacter>();
        //nonHumanCharacter.Race = "Orc";
        //nonHumanCharacter.Size = "Large";
        //nonHumanCharacter.Ability = "Brute Strength";
        return nonHumanCharacter;
    }
}
