namespace RPG_Dio.src.Entities
{
    public class Wizard : Hero
    {
          public Wizard(string Name, int Level ,string HeroType, int AttackPoints, int DefPoints, int HealtPoints, int ManaPoints)
         :base(Name,Level,HeroType,DefPoints,AttackPoints,HealtPoints,ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.AttackPoints = AttackPoints;
            this.DefPoints = DefPoints;
            this.HealtPoints = HealtPoints;
            this.ManaPoints = ManaPoints;

        }
        public override string Attack()
        {
            return this.Name + " Atacou com sua Magia";
        }
          public string Attack(int dano)
        {
            if (dano >6)
            {
                return this.Name + " Atacou com sua Magia elevada e deu um dano critico de "+ dano;
            }
            else
            {
                return this.Name + " Atacou com sua Magia e deu um dano de "+ dano;
            }

            
        }
    }
}