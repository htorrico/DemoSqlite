
using System.IO;
using DemoSqlite.Interfaces;
using Xamarin.Forms;
using DemoSqlite.Droid.Implementations;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace DemoSqlite.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                databaseFileName);
        }
    }
}