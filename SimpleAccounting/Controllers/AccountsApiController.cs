using SimpleAccounting.DAL;
using SimpleAccounting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Threading.Tasks;

namespace SimpleAccounting.Controllers
{
    public class AccountsApiController : ApiController
    {
        private readonly AccountingContext dbContext;

        public AccountsApiController(AccountingContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ICollection<Account>> GetAll()
        {
            return await dbContext.Accounts.ToListAsync();
        }

        [HttpGet]
        [ActionName("types")]
        public async Task<ICollection<AccountType>> Types()
        {
            return await dbContext.AccountTypes.ToListAsync();
        }
    }
}
