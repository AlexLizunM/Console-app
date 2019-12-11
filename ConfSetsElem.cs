using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace ConsoleApp1
{
    class ConfSetsElem : ConfigurationElement
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)base["name"];
            }
            set
            {
                base["name"] = value;
            }
        }
        /*[ConfigurationProperty("setting")]
        public string Name1
        {
            get
            {
                return (string)base["Name1"];
            }
            set
            {
                base["Name1"] = value;
            }
        }

        public string Value
        {
            get
            {
                return (string)base["value"];
            }
            set
            {
                base["value"] = value;
            }
        }*/
    }
}
