using System.Collections.Generic;
using System.Linq;

namespace _001_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClienteService" in code, svc and config file together.
    public class ClienteService : IClienteService
    {
        public Cliente Get(int id)
        {
            var e = new AdventureWorksLT2008Entities();
            return e.Clientes.FirstOrDefault(x => x.CustomerID == id);
        }

        public List<Cliente> Get()
        {
            var e = new AdventureWorksLT2008Entities();
            return e.Clientes.Take(10).ToList();
        }
    }
}
