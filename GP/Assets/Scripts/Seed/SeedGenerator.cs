using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SeedGenerator
{
    public static Seed GenerateRandomSeed()
    {
        System.Random random = new System.Random();

        TalentType randomType = (TalentType)random.Next(2);
        Debug.Log(randomType);
        Talent randomFirstTalent = GetRandomTalent(randomType);
        Debug.Log(randomFirstTalent);
        Talent randomSecondTalent = GetRandomOppositeTalent(randomType, randomFirstTalent);
        Debug.Log(randomSecondTalent);

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
        Talent oppositeTalent;

        if (firstTalent == Talent.Innovative || firstTalent == Talent.Logical)
        {
            oppositeTalent = (firstTalent == Talent.Innovative) ? Talent.Logical : Talent.Innovative;
        }
        else
        {
            oppositeTalent = (type == TalentType.Intrinsic) ? Talent.Innovative : Talent.Logical;
        }

        return oppositeTalent;
    }
}
