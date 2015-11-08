using System.Collections.Generic;

namespace BusinessObjects
{
    public class Configuration
    {
        Dictionary<string, IConfigItem> _configList = new Dictionary<string, IConfigItem>();

        public IConfigItem this[string key]
        {
            get
            {
                return _configList[key];
            }
            set
            {
                _configList.Add(key, value);
            }
        }
    }
}
