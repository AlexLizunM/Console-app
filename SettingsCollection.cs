using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace ConsoleApp1
{
    class SettingsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfSetsElem();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ConfSetsElem)element).Name;
        }

        protected override string ElementName
        {
            get
            {
                return "confSetElem";
            }
        }

        protected override bool IsElementName(string elementName)
        {
            return !String.IsNullOrEmpty(elementName) && elementName == "confSetElem";
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        public ConfSetsElem this[int index]
        {
            get
            {
                return base.BaseGet(index) as ConfSetsElem;
            }
        }

        public new ConfSetsElem this[string key]
        {
            get
            {
                return base.BaseGet(key) as ConfSetsElem;
            }
        }
    }
}
