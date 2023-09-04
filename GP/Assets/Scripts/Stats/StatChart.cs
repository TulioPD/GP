
public class StatChart
{
    public int strength;       
    public int stamina;        
    public int mind;           
    public int agility;        
    public int dexterity;      
    public int perception;     


    //Mixed stats

    public int health;         
    public int dodge;
    public int accuracy;
    public int criticalChance;
    public int criticalDamage;
    public int criticalDodge;

    public StatChart()
    {
        this.strength = 1;
        this.stamina = 1;
        this.mind = 1;
        this.agility = 1;
        this.dexterity = 1;
        this.perception = 1;
        this.health = 100;
        this.dodge = 0;
        this.accuracy = 0;
        this.criticalChance = 0;
        this.criticalDamage = 0;
        this.criticalDodge = 0;
    }
}