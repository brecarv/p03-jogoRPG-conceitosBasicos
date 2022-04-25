using static System.Console;

using p03_jogoRPG.src.Entities;

class Program
{
  static void Main(string[] args)
  {
    Arus heroA = new Arus("brecarv", 25, "Raider");
    Arus heroB = new Arus("ShaSha", 25, "Raider");

    WriteLine($"O héroi {heroA.Name} está no nível {heroA.Level} e é da classe {heroA.HeroType}");
    WriteLine($"O héroi {heroB.Name} está no nível {heroB.Level} e é da classe {heroB.HeroType}");
    WriteLine(heroA.Attack());
    WriteLine(heroB.Attack());
  }
}