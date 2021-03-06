using System.Collections.Generic;
using System.Threading.Tasks;
using Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Db
{
    public class DbBankInfoService : IDbBankInfoService
    {
        DatabaseContext ctx = new DatabaseContext();

        //Accounts
        public async Task<List<BankInfo>> GetBankInfosAcyns()
        {
            List<BankInfo> bankInfos = await ctx.bankInfos.ToListAsync();   
            return bankInfos;
        }

        

        public async Task<BankInfo> addBankInfoAsync(BankInfo bankInfo)
        {
            foreach (var bankInfoExists in ctx.bankInfos)
            {
                if (bankInfoExists.cardNumber==bankInfo.cardNumber)
                {
                    return bankInfo;
                }
            }
            await ctx.bankInfos.AddAsync(bankInfo);
            await ctx.SaveChangesAsync();
            return bankInfo;
        }

        
        
    }
}