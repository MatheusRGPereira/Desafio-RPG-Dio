namespace RPG_Dio.src.Entities.Oponents
{
    public class Orc : Oponent
    {
        public Orc(string Name, int Level , string Breed, int AttackPoints,int DefPoints, int HealtPoints, int ManaPoints)
        :base(Name,Level,Breed,AttackPoints,DefPoints,HealtPoints,ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.Breed = Breed;
            this.AttackPoints = AttackPoints;
            this.DefPoints = DefPoints;
            this.HealtPoints = HealtPoints;
            this.ManaPoints = ManaPoints;
        }

         public override string Attack()
        {
            return this.Name +  " Atacou";
        }

            public string Attack(int Damage)
        {
            if (Damage >6)
            {
                return this.Name + " Atacou com muita precisão e deu um dano de  "+ Damage;
            }
            else
            {
                return this.Name + " Atacou com seu machado e deu um dano de  "+ Damage;
            }

    }
}
}