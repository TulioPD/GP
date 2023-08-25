using System;

using UnityEngine;

public class Seed
{
    public enum TalentType
    {
        Intrinsic,
        Extrinsic
    }

    public enum Talent
    {
        Physical,
        Mental,
        Logical,
        Spatial,
        Environmental,
        Innovative
    }
    public enum SeedName
    {
        
    }

    public TalentType Type { get; private set; }
    public Talent FirstTalent { get; private set; }
    public Talent SecondTalent { get; private set; }

    public Seed(TalentType type, Talent firstTalent, Talent secondTalent)
    {
        Type = type;
        FirstTalent = firstTalent;
        SecondTalent = secondTalent;
    }

    public static Seed GenerateRandomSeed()
    {
        System.Random random = new System.Random();

        TalentType randomType = (TalentType)random.Next(2);
        Talent randomFirstTalent = GetRandomTalent(randomType);
        Talent randomSecondTalent = GetRandomOppositeTalent(randomType, randomFirstTalent);

        return new Seed(randomType, randomFirstTalent, randomSecondTalent);
    }

    private static Talent GetRandomTalent(TalentType type)
    {
        Array values = Enum.GetValues(typeof(Talent));
        Talent[] talents = (Talent[])values;

        int startIndex = (type == TalentType.Intrinsic) ? 0 : 3;
        int randomIndex = new System.Random().Next(startIndex, startIndex + 3);

        return talents[randomIndex];
    }

    private static Talent GetRandomOppositeTalent(TalentType type, Talent firstTalent)
    {
        Talent[] oppositeTalents = new Talent[3];

        switch (firstTalent)
        {
            case Talent.Physical:
            case Talent.Mental:
            case Talent.Logical:
                oppositeTalents = new Talent[] { Talent.Spatial, Talent.Environmental, Talent.Innovative };
                break;
            case Talent.Spatial:
            case Talent.Environmental:
            case Talent.Innovative:
                oppositeTalents = new Talent[] { Talent.Physical, Talent.Mental, Talent.Logical };
                break;
        }

        int randomIndex = new System.Random().Next(3);
        return oppositeTalents[randomIndex];
    }
    public void DebugPrintSeed()
    {
        string seedType = (Type == TalentType.Intrinsic) ? "Intrinsic" : "Extrinsic";
        string firstTalent = FirstTalent.ToString();
        string secondTalent = SecondTalent.ToString();

        Debug.Log("Seed Type: " + seedType);
        Debug.Log("First Talent: " + firstTalent);
        Debug.Log("Second Talent: " + secondTalent);
    }
}
