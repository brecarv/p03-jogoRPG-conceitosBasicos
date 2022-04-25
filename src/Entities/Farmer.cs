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
      return this.Name + " atacou usando seus cavalos.";
    }
    public override string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + " atacou com bonus full usando seus cavalos.";
      }
      return this.Name + " atacou com bonus padrão usando seus cavalos.";
    }
  }
}