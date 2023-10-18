namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Definimos los characters
            Warrior aragorn = new Warrior("Aragorn", 100, 14);
            Elf legolas = new Elf("Legaolas", 80, 10);
            Magician gandalf = new Magician("Gandalf", 20, 200);

            // Mostramos la información de Legolas
            Console.WriteLine($"{legolas.Name} has {legolas.LifeLevel} life points.");
            
            // Aragorn ataca a Legolas (IAttackable)
            Console.WriteLine($"{aragorn.Name} attack to {legolas.Name} with {aragorn.Power} points.");
            aragorn.Attack(legolas);
 
            // Mostramos la información de Legolas
            Console.WriteLine($"{legolas.Name} has {legolas.LifeLevel} life points.");
        }
    }
}