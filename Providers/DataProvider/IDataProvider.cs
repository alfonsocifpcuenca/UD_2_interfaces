namespace Providers.DataProvider
{
    public interface IDataProvider
    {
        public List<Warrior> GetWarriors();
        public List<Scene> GetScenes();
    }
}
