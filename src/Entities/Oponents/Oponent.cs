namespace RPG_Dio.src.Entities.Oponents
{
    public class Oponent
    {
        
  public Oponent(string Name, int Level , string Breed, int AttackPoints, int DefPoints, int HealtPoints, int ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.Breed = Breed;
            this.AttackPoints = AttackPoints;
            this.DefPoints = DefPoints;
            this.HealtPoints = HealtPoints;
            this.ManaPoints = ManaPoints;
        }
        public string Name;
        public int Level;
        public string Breed;

        public int AttackPoints;

        public int DefPoints;

        public int HealtPoints;

        public int ManaPoints;


        public override string ToString()
        {
            return this.Name + " Level: " + this.Level + " Raça: " + this.Breed + " Ataque: "+this.AttackPoints + 
            " Defesa: " + this.DefPoints + " HP: " + this.HealtPoints + " MP: " + this.ManaPoints;;
        }
         public virtual string Attack()
        {
            return this.Name +  " Atacou";
        }

          public virtual int CalcularDano(int AttackPoints, int DefPoints)
        {
            return AttackPoints - (10 - DefPoints);
        }

        public int ReceberDano(int damageTaken, int healtPoints)
        {
            return healtPoints - damageTaken;
        }

    }
}