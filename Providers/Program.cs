using Providers.DataProvider;

namespace Providers
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Establecemos el proveedor de datos, esto se podria sacar a un archivo de configuración para no tener que tocar el código al cambiar de proveedor
            var dataProviderType = DataProviderType.SQL;

            // Aqui establecemos el proveedor de datos en función de dataProviderType
            IDataProvider dataProvider = null;
            switch (dataProviderType)
            {
                case DataProviderType.JSON:
                    dataProvider = new DataProviderJSON();
                    break;

                default:
                case DataProviderType.SQL:
                    dataProvider = new DataProviderSQL();
                    break;
            }

            // Obtenemos los datos para nuestra aplicación, independientemente del proveedor de datos, no nos importa si
            // los datos nos los proporcionan desde un JSON o desde SQL (o ampliar a XML u otros proveedores)
            var warriors = dataProvider.GetWarriors();
            var scenes = dataProvider.GetScenes();
        }
    }
}