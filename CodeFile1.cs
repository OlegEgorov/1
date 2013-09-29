using System;
using System.Threading;
class Programm
{
    public static void Main()
    {
        Console.ReadKey();
    }
}
class Human : IComparable, ICloneable
{
    private int weigth, growth;
    public Human(int weigth, int growth) //конструктор
    {
        this.weigth = weigth; this.growth = growth;
    }
    public int CompareTo(object human) // реализуем метод CompareTo интерфейса IComporable 
    {
        if (((Human)human).growth < growth) return 1;
        else if (((Human)human).growth == growth) return 0;
             else return -1;
    }
    public object Clone() // реализуем метод Clone интерфейса ICloneable
    {
        return new Human(weigth, growth);
    }
    public static int operator +(Human one, Human two) // перегружаем операторы
    {
        return (one.growth + one.weigth) + (two.growth + two.weigth);
    }
    public static int operator -(Human one, Human two)
    {
        return (one.growth + one.weigth) - (two.growth + two.weigth);
    }
    public static int operator *(Human one, Human two)
    {
        return (one.growth + one.weigth) * (two.growth + two.weigth);
    }
    public static int operator /(Human one, Human two)
    {
        if ((two.growth + two.weigth) != 0) return (one.growth + one.weigth) / (two.growth + two.weigth);
        else return 0;
    }
    public static bool operator <(Human one, Human two)
    {
        int res = one.CompareTo(two);
        return (res < 0)? true : false;
    }
    public static bool operator >(Human one, Human two)
    {
        int res = one.CompareTo(two);
        return (res > 0)? true : false;
    }
    public virtual void Talk()                   // виртуальный метод
    {
        Console.WriteLine("\t I'm Human");
    }
}
class Man : Human
{
    private string name;
    public Man(int weigth, int growth, string name)     // конструктор
        : base(weigth, growth)
    {
        this.name = name;
    }
    public override void Talk()          // перезаданный метод
    {
        Console.WriteLine("\t I'm Man");
    }
    public void SayName()
    {
        Console.WriteLine("\t My name is {0}", name);
    }
}
class Woman : Human
{
    private string name;
    public Woman(int weigth, int growth, string name)  // конструктор
        : base(weigth, growth)
    {
        this.name = name;
    }
    public override void Talk()    // перезаданный метод
    {
        Console.WriteLine("\t I'm Woman");
    }
    public void SayName()
    {
        Console.WriteLine("\t My name is {0}", name);
    }
}