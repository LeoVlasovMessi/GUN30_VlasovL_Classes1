using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Unicode;
using System.Xml.Linq;
using Uroki;

Console.WriteLine("Подготовка к бою");
Console.WriteLine("Введите имя бойца:");

var unit = new Unit(Console.ReadLine());

Console.WriteLine("Введите начальное здоровье бойца (10-100):");

if (int.TryParse(Console.ReadLine(), out int health))
{
    unit.Health = health;
}
else 
{
    Console.WriteLine("Неверно введено значение здоровья.. Попробуйте заново");
}

Console.WriteLine("Введите название шлема: ");
var helm = new Helm(Console.ReadLine());

Console.WriteLine("Введите значение защиты шлема (0-1): ");
if (float.TryParse(Console.ReadLine(), out float armor_helm))
{
    helm.Armor = armor_helm;
}
else
{
    Console.WriteLine("Неверно введено значение защиты шлема.. Попробуйте заново");
}

Console.WriteLine("Введите название кирасы: ");
var shell = new Shell(Console.ReadLine());
Console.WriteLine("Введите значение защиты кирасы (0-1): ");
if (float.TryParse(Console.ReadLine(), out float armor_shell))
{
    shell.Armor = armor_shell;
}
else
{
    Console.WriteLine("Неверно введено значение защиты кирасы.. Попробуйте заново");
}

Console.WriteLine("Введите название сапог: ");
var boots = new Boots(Console.ReadLine());
Console.WriteLine("Введите значение защиты сапог (0-1): ");
if (float.TryParse(Console.ReadLine(), out float armor_boots))
{
    boots.Armor = armor_boots;
}
else
{
    Console.WriteLine("Неверно введено значение защиты сапог.. Попробуйте заново");
}

float Min = 0;
float Max = 0;

Console.WriteLine("Введите название оружия: ");
var weapon =  new Weapon(Console.ReadLine());
Console.WriteLine("Введите минимальный урон оружия (0-20):");
if (float.TryParse(Console.ReadLine(), out float minDamage))
{
    Min = minDamage;
}
else
{
    Console.WriteLine("Неверно введено значение минимального урона.. Попробуйте заново");
}

Console.WriteLine("Введите максимальный урон оружия (20-40):");
if (float.TryParse(Console.ReadLine(), out float maxDamage))
{
    Max = maxDamage;
}
else
{
    Console.WriteLine("Неверно введено значение максимального урона.. Попробуйте заново");
}

weapon.MaxDamage = Max;
weapon.MinDamage = Min;

weapon.SetDamageParams(Min, Max);

unit.weapon = weapon;
unit.helm = helm;
unit.shell = shell;
unit.boots = boots;

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Информация о юните ");
Console.WriteLine("Имя: " + unit.Name);
Console.WriteLine("общий уровень брони: " + unit.Armor);
Console.WriteLine("Здоровье: " + unit.Health);
Console.WriteLine("Фактическое здоровье: " + unit.RealHealth());
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Информация о броне ");
Console.WriteLine("Название шлема: " + helm.Name);
Console.WriteLine("Защита шлема: " + helm.Armor);
Console.WriteLine("Название кирасы: " + shell.Name);
Console.WriteLine("Защита кирасы: " + shell.Armor);
Console.WriteLine("Название сапог: " + boots.Name);
Console.WriteLine("Защита сапог: " + boots.Armor);
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Информация об оружии ");
Console.WriteLine("Название оружия: " + weapon.Name);
Console.WriteLine("MinDamage = " + weapon.MinDamage);
Console.WriteLine("MaxDamage = " + weapon.MaxDamage);