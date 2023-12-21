using BankingAppMVC.Assemblers;
using BankingAppMVC.Repository;
using BankingAppMVC.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace BankingAppMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<UserAssembler>();
            container.RegisterType<ITransactionRepository, TransactionRepository>();
            container.RegisterType<ITransactionService, TransactionService>();
            container.RegisterType<TransactionAssembler>();
            container.RegisterType<IRoleRepository, RoleRepository>();
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<RoleAssembler>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<CustomerAssembler>();
            container.RegisterType<IDocumentRepository, DocumentRepository>();
            container.RegisterType<IDocumentService, DocumentService>();
            container.RegisterType<DocumentAssembler>();
            container.RegisterType<IAccountRepository, AccountRepository>();
            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<AccountAssembler>();
            container.RegisterType<IAccountTypeRepository, AccountTypeRepository>();
            container.RegisterType<IAccountTypeService, AccountTypeService>();
            container.RegisterType<AccountTypeAssembler>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}