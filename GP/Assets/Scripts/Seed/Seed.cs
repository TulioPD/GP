using System;

using UnityEngine;

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
    Iphy_I,
    Imen_I,
    I_L_I,
    Ispa_I,
    Ienv_I,
    I_I_L,
    Ephy_L,
    Emen_L,
    E_L_I,
    Espa_L,
    Eenv_L,
    E_I_L,
    unknown
}

public class Seed
{
    private TalentType randomType;
    private Talent randomFirstTalent;
    private Talent randomSecondTalent;

    public TalentType Type { get; private set; }
    public Talent FirstTalent { get; private set; }
    public Talent SecondTalent { get; private set; }
    public SeedName SeedName { get; private set; }

    public Seed(TalentType type, Talent firstTalent, Talent secondTalent, SeedName seedName)
    {
        Type = type;
        FirstTalent = firstTalent;
        SecondTalent = secondTalent;
        SeedName = seedName;
    }

    public Seed(TalentType randomType, Talent randomFirstTalent, Talent randomSecondTalent)
    {
        this.randomType = randomType;
        this.randomFirstTalent = randomFirstTalent;
        this.randomSecondTalent = randomSecondTalent;
        this.SeedName = GetSeedName(randomType, randomFirstTalent, randomSecondTalent);
    }

    private SeedName GetSeedName(TalentType randomType, Talent randomFirstTalent, Talent randomSecondTalent)
    {
        switch (randomType)
        {
            case TalentType.Intrinsic:
                // For Intrinsic, you can choose from the first set of SeedName values.
                // Depending on the combination of randomFirstTalent and randomSecondTalent, return the appropriate SeedName.
                if (randomFirstTalent == Talent.Physical && randomSecondTalent == Talent.Mental)
                    return SeedName.Iphy_I;
                else if (randomFirstTalent == Talent.Mental && randomSecondTalent == Talent.Physical)
                    return SeedName.Imen_I;
                else if (randomFirstTalent == Talent.Logical && randomSecondTalent == Talent.Logical)
                    return SeedName.I_L_I;
                // Handle other combinations...
                else
                    return SeedName.I_I_L; // Default or fallback value for Intrinsic.

            case TalentType.Extrinsic:
                // For Extrinsic, you can choose from the second set of SeedName values.
                // Depending on the combination of randomFirstTalent and randomSecondTalent, return the appropriate SeedName.
                if (randomFirstTalent == Talent.Physical && randomSecondTalent == Talent.Mental)
                    return SeedName.Ephy_L;
                else if (randomFirstTalent == Talent.Mental && randomSecondTalent == Talent.Physical)
                    return SeedName.Emen_L;
                else if (randomFirstTalent == Talent.Logical && randomSecondTalent == Talent.Logical)
                    return SeedName.E_L_I;
                // Handle other combinations...
                else
                    return SeedName.E_I_L; // Default or fallback value for Extrinsic.

            default:
                // Handle any other cases or errors.
                return SeedName.unknown; // Default value in case of unknown TalentType.
        }
    }


    public void DebugPrintSeed()
    {
        string seedType = (Type == TalentType.Intrinsic) ? "Intrinsic" : "Extrinsic";
        string firstTalent = FirstTalent.ToString();
        string secondTalent = SecondTalent.ToString();

        Debug.Log("Seed Type: " + seedType);
        Debug.Log("First Talent: " + firstTalent);
        Debug.Log("Second Talent: " + secondTalent);
        Debug.Log("Seed Name: " + SeedName);
    }
}
