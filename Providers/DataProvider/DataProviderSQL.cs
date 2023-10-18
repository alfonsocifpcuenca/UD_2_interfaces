namespace Providers.DataProvider
{
    public class DataProviderSQL : IDataProvider
    {
        public List<Scene> GetScenes()
        {
            Console.WriteLine($"Obtenemos las Scenes de DB.");
            var scenes = new List<Scene>();
            return scenes;
        }

        public List<Warrior> GetWarriors()
        {
            Console.WriteLine($"Obtenemos los Warriors de DB.");
            var warriors = new List<Warrior>();
            return warriors;
        }
    }
}
