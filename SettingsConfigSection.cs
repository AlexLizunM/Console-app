using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace ConsoleApp1
{
    class SettingsConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true, IsKey = false, IsRequired = true)]
        public SettingsCollection Settings
        {
            get
            {
                return base[""] as SettingsCollection;
            }

            set
            {
                base[""] = value;
            }
        }
    }
}
