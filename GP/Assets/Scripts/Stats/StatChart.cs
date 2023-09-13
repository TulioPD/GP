
using System;

public class StatChart
{
    public int strength;       
    public int stamina;        
    public int mind;           
    public int agility;        
    public int dexterity;      
    public int perception;


    //Mixed stats

    public int health => GetTotalHealth();
    public int dodge => GetTotalDodge();
    public int accuracy => GetTotalAccuracy();
    public int criticalChance => GetTotalCriticalChance();
    public int criticalDamage => GetTotalCriticalDamage();
    public int criticalDodge => GetTotalCriticalDodge();
    public int movementSpeed => GetTotalMovementSpeed();

    public StatChart()
    {
        this.strength = 1;
        this.stamina = 1;
        this.mind = 1;
        this.agility = 1;
        this.dexterity = 1;
        this.perception = 1;
    }

    public StatChart(int strength, int stamina, int mind, int agility, int dexterity, int perception)
    {
        this.strength = strength;
        this.stamina = stamina;
        this.mind = mind;
        this.agility = agility;
        this.dexterity = dexterity;
        this.perception = perception;
    }

    private int GetTotalHealth()
    {
        return 10;
    }

    private int GetTotalDodge()
    {
        return 10;
    }
    private int GetTotalAccuracy()
    {
        return 10;
    }

    private int GetTotalCriticalChance()
    {
        return 10;
    }

    private int GetTotalCriticalDamage()
    {
        return 10;
    }

    private int GetTotalCriticalDodge()
    {
        return 10;
    }

    private int GetTotalMovementSpeed()
    {
        return 1;
    }
}