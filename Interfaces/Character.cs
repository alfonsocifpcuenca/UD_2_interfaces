namespace Interfaces
{
    public class Character
    {
        public string Name { get; set; }
        public int LifeLevel { get; set; }
        public int Power { get; set; }


        public Character(string name, int lifeLevel, int power)
        {
            Name = name;
            LifeLevel = lifeLevel;
            Power = power;
        }
    }
}
