using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ConsoleIntegracao.Model
{
    public class CreateAccount
    {
        public  void Account(IOrganizationService service)
        {
            Console.WriteLine("Por Favor Informe o nome da Conta: ");
            string nomeConta = Console.ReadLine();

            Console.WriteLine("Quantidade de Produtos deseja Adquirir ");
            int quantProdutos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor da sua Renda Mensal: ");
            double renda = double.Parse(Console.ReadLine());

            Console.WriteLine("Deseja Adquirir Licenças para PowerBI: ");
            var licencasUsuario = Console.ReadLine().ToUpper();
            var licenca = false;
            if (licencasUsuario == "SIM")
            {
                licenca = true;
            }
            else
            {
                licenca = false;
            }

            Entity conta = new Entity("account");
            conta["name"] = nomeConta;
            conta["telephone1"] = "(11)9997890";
            conta["fax"] = "2412444";
            conta["websiteurl"] = "dynacoop.com.br";
            conta["cr520_quantidadedeprodutos"] = quantProdutos;
            conta["cr520_rendamensal"] = new Money((decimal)renda);
            conta["cr520_licencas"] = licenca;
            Guid accountId = service.Create(conta);

            Console.WriteLine("Você Deseja criar um contato para essa conta? (S/N)");
            var contatoUsuario = Console.ReadLine().ToUpper();

                if (contatoUsuario == "S")
            {
                Console.WriteLine("Informe seu Primeiro Nome");
                var primeiroNome = Console.ReadLine();
                Console.WriteLine("Informe seu Sobrenome");
                var sobreNome = Console.ReadLine();
                Console.WriteLine("Informe seu Cargo");
                var cargo = Console.ReadLine();

                Entity contato = new Entity("contact");
                contato["firstname"] = primeiroNome;
                contato["lastname"] = sobreNome;
                contato["jobtitle"] = cargo;
                contato["parentcustomerid"] = new EntityReference("account", accountId);
                service.Create(contato);
            }
            
            else if (contatoUsuario != "S" || contatoUsuario != "N")
            {
                Console.WriteLine("Por favor responda S PARA SIM E N PARA NÃO");
                return;
            }
            else
            {
                Environment.Exit(0);
            }
        }

    }
}
