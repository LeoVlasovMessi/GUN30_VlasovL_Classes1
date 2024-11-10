using System;

public class Helm
{
    private string name;
    public string Name { get; }

    public Helm(string name) 
    {
        this.name = name;
    }
    public Helm() : this("Helm")
    {
    }

    private float armor;
    public float Armor { 
        get 
        {
            return armor
        } 
        set 
        {
            if (value >= 0f && value <=1f) armor = value;
            if (value < 0f) { armor = 0f; Console }
            if (value > 1f) armor = 1f;
        } 
    }
}