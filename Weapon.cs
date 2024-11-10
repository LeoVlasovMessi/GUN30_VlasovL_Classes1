using System;

public class Weapon
{

    private string name;
    public string Name { get { return name; } }
    private float minDamage;
    public float MinDamage { get { return maxDamage; } private set { maxDamage = value; } }
    private float maxDamage;
    public float MaxDamage { get { return maxDamage; } private set { maxDamage = value; } }

    public Weapon(string name)
    {
        this.name = name;
    }
    public Weapon(string name, float minDamage, float maxDamage) : this(name)
    {
        MinDamage = minDamage;
        MaxDamage = maxDamage;
        SetDamageParams(minDamage, maxDamage);
    }
    public void SetDamageParams(float minDamage, float maxDamage)
    {
        if (minDamage<1f) { minDamage = 1f; Console.WriteLine("Минимально возможный урон = 1f (Неверно введены данные)"); }
        if (maxDamage<=1f) { maxDamage = 10f; }
        if (minDamage>maxDamage)
        {
            float mid = minDamage;
            minDamage = maxDamage;
            maxDamage = mid;
            Console.WriteLine("Неверные данные (minDamage > maxDamage )" + name);
        }
    }
    public float GetDamage()
    {
        return (minDamage+maxDamage)/2;
    }
}