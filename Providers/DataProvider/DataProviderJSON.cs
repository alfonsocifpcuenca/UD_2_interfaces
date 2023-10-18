namespace Providers.DataProvider
{
    public class DataProviderJSON : IDataProvider
    {
        public List<Scene> GetScenes()
        {
            Console.WriteLine($"Obtenemos las Scenes de JSON.");
            var scenes = new List<Scene>();
            return scenes;
        }

        public List<Warrior> GetWarriors()
        {
            Console.WriteLine($"Obtenemos los Warriors de JSON.");
            var warriors = new List<Warrior>();
            return warriors;
        }
    }
}
