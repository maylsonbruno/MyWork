using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleIntegracao.Model;

namespace ConsoleIntegracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrganizationService service = ConnectionFactory.GetService();
             CreateAccount create = new CreateAccount();
             create.Account(service);       
        }     
    }
}
