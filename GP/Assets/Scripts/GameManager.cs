using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //SeedGenerator seedGenerator = new SeedGenerator();
    //CharacterGenerator characterGenerator = new CharacterGenerator();

    // Start is called before the first frame update
    void Start()
    {
        Seed seed = SeedGenerator.GenerateRandomSeed();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
