using System.Collections.Generic;
using System.Threading.Tasks;
using Database.Model;


namespace Data.Impl
{
    public interface IAccountService
    {
        Task<IList<Account>> getAccountsAsync();
        Task<Account> AddAccountAsync(Register register);
        
        //Task<Account> ValidateUser(string username, string password);
    }
}