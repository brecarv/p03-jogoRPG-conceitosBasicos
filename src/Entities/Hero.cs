namespace p03_jogoRPG.src.Entities
{
  public class Hero
  {
    public Hero(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
    public string Name;
    public int Level;
    public string HeroType;

    public override string ToString()
    {
      return "O héroi " + this.Name + " está no nível " + this.Level + " e é da classe " + this.HeroType;
    }

    public string Attack()
    {
      return this.Name + " atacou com a sua espada.";
    }
  }
}