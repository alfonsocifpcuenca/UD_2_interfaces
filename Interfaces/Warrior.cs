namespace Interfaces
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, int lifeLevel, int power) : base(name, lifeLevel, power)
        {
        }
        public void TakeDamage(int damage)
        {
            this.LifeLevel -= damage;
        }

        public void Attack(IAttackable target)
        {
            target.TakeDamage(this.Power);
        }
    }
}
