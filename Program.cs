using static System.Console;

using p03_jogoRPG.src.Entities;

class Program
{
  static void Main(string[] args)
  {
    Hero heroA = new Hero("brecarv", 25, "Raider");
    Farmer heroB = new Farmer("ShaSha", 25, "Farmer");

    WriteLine($"O héroi {heroA.Name} está no nível {heroA.Level} e é da classe {heroA.HeroType}");
    WriteLine($"O héroi {heroB.Name} está no nível {heroB.Level} e é da classe {heroB.HeroType}");
    WriteLine(heroA.Attack());
    WriteLine(heroB.Attack());
  }
}