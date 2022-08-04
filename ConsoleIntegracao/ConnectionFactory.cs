using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIntegracao
{
    public class ConnectionFactory
    {
        public static IOrganizationService GetService()
        {
            string connectionString =
                   "AuthType=OAuth;" +
                   "Username=MaylsonCosta@Dynacoops2.onmicrosoft.com;" +
                   "Password=teste321#;" +
                   "Url=https://orgf0f5cc49.crm2.dynamics.com/;" +
                   "AppId=bf34dd1e-01e2-4f04-9641-35e01be51cb5;" +
                   "RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;";

            CrmServiceClient crmServiceClient = new CrmServiceClient(connectionString);
            return crmServiceClient.OrganizationWebProxyClient;
        }
    }
}
