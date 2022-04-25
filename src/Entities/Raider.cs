namespace p03_jogoRPG.src.Entities
{
  public class Raider : Hero
  {
    public Raider(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
    public override string Attack()
    {
      return this.Name + " atacou usando sua espada.";
    }
    public override string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + " atacou com bonus full usando sua espada.";
      }
      return this.Name + " atacou com bonus padrão usando sua espada.";
    }
  }
}