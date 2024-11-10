using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uroki;

namespace Uroki
{
    public class Helm
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        public Helm(string name)
        {
            this.name = name;
        }
        public Helm() : this("Helm")
        {
        }

        private float armor;
        public float Armor
        {
            get
            {
                return armor;
            }
            set
            {
                if (value >= 0f && value <=1f) armor = value;
                if (value < 0f) { armor = 0f; Console.WriteLine("Некорректно задано свойство"); }
                if (value > 1f) { armor = 1f; Console.WriteLine("Некорректно задано свойство"); }
            }
        }
    }

    public class Shell
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        public Shell(string name)
        {
            this.name = name;
        }
        public Shell() : this("Shell")
        {
        }

        private float armor;
        public float Armor
        {
            get
            {
                return armor;
            }
            set
            {
                if (value >= 0f && value <=1f) armor = value;
                if (value < 0f) { armor = 0f; Console.WriteLine("Некорректно задано свойство"); }
                if (value > 1f) { armor = 1f; Console.WriteLine("Некорректно задано свойство"); }
            }
        }
    }
}

public class Boots
{
    private string name;
    public string Name { get { return name; } set { name = value; } }

    public Boots(string name)
    {
        this.name = name;
    }
    public Boots() : this("Boots")
    {
    }

    private float armor;
    public float Armor
    {
        get
        {
            return armor;
        }
        set
        {
            if (value >= 0f && value <=1f) armor = value;
            if (value < 0f) { armor = 0f; Console.WriteLine("Некорректно задано свойство"); }
            if (value > 1f) { armor = 1f; Console.WriteLine("Некорректно задано свойство"); }
        }
    }
}
