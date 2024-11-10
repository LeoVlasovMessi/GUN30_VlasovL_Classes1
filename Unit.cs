using System;

public class Unit
{

    private string name;
    public string Name { get { return name; } }
    private float healht;
    public float Health { get { return Health; } }
    private float damage;
    private int DefaultDamage = 5;
    public float Damage
    {
        get
        {
            //прописать здесь логику в дальнейшем
            return 3333333;
        }
    }
    private float armor;
    public float Armor
    {
        get
        {
            //прописать здесь логику в дальнейшем
            return armor;
        }
    }

    public Unit(string name)
    {
        this.name = name;
    }

    public Unit() : this("Unknown Unit") { }

    public float RealHealth()
    {
        return Health * (1f+Armor);
    }

    public bool SetDamage(float value)
    {
        healht = Health - value*Armor;

        if (Health<=0f)
        {
            return true;
        }
        else return false;
    }

    public void EquipWeapon()
    {
        //прописать здусь логику и тд
    }

    public void EquipHelm()
    {
        //прописать здусь логику и тд
    }
    public void EquipShell()
    {
        //прописать здусь логику и тд
    }
    public void EquipBoots()
    {
        //прописать здусь логику и тд
    }

}