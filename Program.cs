using static System.Console;

using p03_jogoRPG.src.Entities;

class Program
{
  static void Main(string[] args)
  {
    Arus heroA = new Arus("brecarv", 25, "Raider");

    WriteLine($"O héroi {heroA.Name} está no nível {heroA.Level} e é da classe {heroA.HeroType}");
    WriteLine(heroA.ToString());
  }
}