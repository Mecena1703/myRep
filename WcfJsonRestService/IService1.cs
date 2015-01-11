using System.ServiceModel;

namespace WcfJsonRestService
{
    [ServiceContract]
    public interface IService1
    {
      
        [OperationContract]
        Guitar GetGuitarData(string id);

        [OperationContract]
        Guitar[] GetGuitars(string id);
    }
}
