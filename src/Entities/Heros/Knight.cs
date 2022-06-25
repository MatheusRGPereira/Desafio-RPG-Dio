namespace RPG_Dio.src.Entities
{
    public class Knight : Hero
    {
        
        public Knight(string Name, int Level ,string HeroType, int AttackPoints, int DefPoints, int HealtPoints, int ManaPoints)
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
            return this.Name + " Atacou com sua Espada";
        }
         public string Attack(int dano)
        {
            if (dano >6)
            {
                return this.Name + " Atacou com muita precisão e deu um dano de  "+ dano;
            }
            else
            {
                return this.Name + " Atacou com sua espada e deu um dano de  "+ dano;
            }


    }

    }
}