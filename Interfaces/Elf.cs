namespace Interfaces
{
    public class Elf : Character, IAttackable
    {
        public Elf(string name, int lifeLevel, int power) : base(name, lifeLevel, power)
        {
        }

        public void TakeDamage(int damage)
        {
            this.LifeLevel -= damage;
        }
    }
}
