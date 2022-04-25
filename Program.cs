using static System.Console;

using p03_jogoRPG.src.Entities;

class Program
{
  static void Main(string[] args)
  {
    Hero heroA = new Raider("brecarv", 25, "Raider");
    Farmer heroB = new Farmer("ShaSha", 25, "Farmer");

    WriteLine($"O héroi {heroA.Name} está no nível {heroA.Level} e é da classe {heroA.HeroType}");
    WriteLine(heroA.Attack());
    WriteLine(heroA.Attack(1));
    WriteLine(heroA.Attack(10));

    WriteLine($"O héroi {heroB.Name} está no nível {heroB.Level} e é da classe {heroB.HeroType}");
    WriteLine(heroB.Attack());
    WriteLine(heroB.Attack(1));
    WriteLine(heroB.Attack(10));
  }
}