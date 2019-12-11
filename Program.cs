using System;
using System.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting1 = GetSetsElem(1);
            Console.WriteLine(setting1.Name);
        }

        public static ConfSetsElem GetSetsElem(int setsName)
        {
            var settingsConfigSection = ConfigurationManager.GetSection("settingsCollection") as SettingsConfigSection;

            if (settingsConfigSection == null || settingsConfigSection.Settings == null || settingsConfigSection.Settings.Count < 1)
                return null;

            return settingsConfigSection.Settings[setsName];
        }
    }
}