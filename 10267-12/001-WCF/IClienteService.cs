using System.Collections.Generic;
using System.ServiceModel;

namespace _001_WCF
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract(Name = "GetById")]
        Cliente Get(int id);

        [OperationContract(Name = "GetTop10")]
        List<Cliente> Get();
    }
}
