using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Web;

namespace _004_WCFDataService
{
    public class Service : DataService<AdventureWorksLT2008Entities>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;

            //config.SetEntitySetAccessRule("Contatos", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);

            config.SetServiceOperationAccessRule("GetCliente", ServiceOperationRights.ReadSingle);

            //config.MaxExpandDepth = 1;
            //config.MaxExpandCount = 1;
            config.SetEntitySetPageSize("Clientes", 5);
            config.SetEntitySetPageSize("Enderecos", 10);
        }

        protected override void HandleException(HandleExceptionArgs args)
        {
            base.HandleException(args);

            Debug.Print("{0} {1} -> {2} {3}",
                DateTime.Now.ToShortDateString(),
                DateTime.Now.ToShortTimeString(),
                args.Exception.GetType().Name,
                args.Exception.Message);
        }

        [WebGet]
        [SingleResult]
        public Cliente GetCliente(int id)
        {
            return CurrentDataSource.Clientes.FirstOrDefault(x => x.CustomerID == id);
        }
    }
}

/*
http://localhost:46243/Service.svc/
http://localhost:46243/Service.svc/Clientes/
http://localhost:46243/Service.svc/Clientes(1)/
http://localhost:46243/Service.svc/Clientes(1)/FirstName/
http://localhost:46243/Service.svc/Clientes?$select=FirstName/
http://localhost:46243/Service.svc/Clientes/$count/
http://localhost:46243/Service.svc/Clientes?$filter=CustomerID%20ge%206%20and%20CustomerID%20le%2010/
http://localhost:46243/Service.svc/Clientes?$orderby=FirstName/
http://localhost:46243/Service.svc/Clientes?$top=3/
http://localhost:46243/Service.svc/Clientes?$skip=5&$top=5
http://localhost:46243/Service.svc/Clientes?$skiptoken=5
http://localhost:46243/Service.svc/GetCliente?id=1
*/