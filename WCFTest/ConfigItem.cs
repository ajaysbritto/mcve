using System;
using System.Runtime.Serialization;

namespace BusinessObjects
{
    [Serializable]
    [KnownType(typeof(StringConfigItem))]
    [DataContract(Name = "StringConfigItem")]
    public class StringConfigItem : IConfigItem
    {
        SerializableDictionary<string, string> _stringValue = new SerializableDictionary<string, string>();
        private string _moduleName = "";

        public StringConfigItem(string moduleName)
        {
            ModuleName = moduleName;
        }

        public StringConfigItem()
        {

        }

        [DataMember(Name = "ModuleName")]
        public string ModuleName
        {
            get
            {
                return _moduleName;
            }

            set
            {
                _moduleName = value;
            }
        }

        [DataMember(Name = "StringValue")]
        public SerializableDictionary<string, string> StringValue
        {
            get
            {
                return _stringValue;
            }

            set
            {
                _stringValue = value;
            }
        }

        public void PutValue(string key, string value)
        {
            _stringValue.Add(key, value);
        }

        public string GetValue(string key)
        {
            return _stringValue[key];
        }
    }
}
