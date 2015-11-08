using BusinessObjects;
using System.ServiceModel;

namespace WCFTest
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        StringConfigItem GetData(int value);
    }
}
