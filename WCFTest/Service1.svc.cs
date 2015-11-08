using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        StringConfigItem allConfigItems;

        public StringConfigItem GetData(int value)
        {
            return allConfigItems;
        }

        public Service1()
        {
            allConfigItems = new StringConfigItem("AllModules");
            allConfigItems.PutValue("A", null);
            allConfigItems.PutValue("B", null);
            allConfigItems.PutValue("C", null);
            allConfigItems.PutValue("D", null);
            allConfigItems.PutValue("E", null);
            allConfigItems.PutValue("F", null);
            allConfigItems.PutValue("G", null);
            allConfigItems.PutValue("H", null);
            allConfigItems.PutValue("I", null);
            allConfigItems.PutValue("J", null);
            allConfigItems.PutValue("K", null);
            allConfigItems.PutValue("L", null);
            allConfigItems.PutValue("M", null);
            allConfigItems.PutValue("N", null);
        }
    }
}
