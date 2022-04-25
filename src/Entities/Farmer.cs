namespace p03_jogoRPG.src.Entities
{
  public class Farmer : Hero
  {
    public Farmer(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
    public override string Attack()
    {
      return this.Name + " atacou com seus cavalos.";
    }
    public override string Attack(int bonus)
    {
      return this.Name + " atacou com seus cavalos.";
    }
  }
}