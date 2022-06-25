namespace RPG_Dio.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level , string Herotype, int AttackPoints, int DefPoints, int HealtPoints, int ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
            this.AttackPoints = AttackPoints;
            this.DefPoints = DefPoints;
            this.HealtPoints = HealtPoints;
            this.ManaPoints = ManaPoints;
        }
        public string Name;
        public int Level;
        public string HeroType;
         public int AttackPoints;

        public int DefPoints;

        public int HealtPoints;

        public int ManaPoints;

        public override string ToString()
        {
            return  this.Name + " Level: " + this.Level + " Classe: " + this.HeroType + " Ataque: "+this.AttackPoints + 
            " Defesa: " + this.DefPoints + " HP: " + this.HealtPoints + " MP: " + this.ManaPoints;
        }

        public virtual string Attack()
        {
            return this.Name +  " Atacou";
        }

        public virtual int CalcularDano(int ataque, int defesaBoss)
        {
           
            return ataque - (5-defesaBoss);
        }
        

    }
}