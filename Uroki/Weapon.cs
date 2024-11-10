using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroki
{
    public class Weapon
    {

        private string name;
        public string Name { get { return name; } }
        private float minDamage;
        public float MinDamage { get { return minDamage; } set { minDamage = value; } }
        private float maxDamage;
        public float MaxDamage { get { return maxDamage; } set { maxDamage = value; } }

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
        public Weapon() : this("UnknownWeapon") { }
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
            this.minDamage = minDamage; this.maxDamage = maxDamage;
        }
        public float GetDamage()
        {
            return (minDamage+maxDamage)/2;
        }
    }
}
