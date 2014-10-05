using SimpleAccounting.DAL;
using SimpleAccounting.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Helpers;

namespace SimpleAccounting.Controllers
{
    public class CompanyApiController : ApiController
    {
        private readonly AccountingContext dbContext;

        public CompanyApiController(AccountingContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        [ActionName("register")]
        public async Task<HttpResponseMessage> Register(Company company)
        {
            if(ModelState.IsValid)
            {
                company.Password = Crypto.HashPassword(company.Password);
                dbContext.Companies.Add(company);

                await dbContext.SaveChangesAsync();

                return Request.CreateResponse(HttpStatusCode.OK, company);
            }
            
            return Request.CreateErrorResponse(HttpStatusCode.BadGateway, ModelState);
        }

        [HttpPost]
        [ActionName("add-user")]
        public async Task<HttpResponseMessage> AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                user.Password = Crypto.HashPassword(user.Password);
                dbContext.Users.Add(user);
                await dbContext.SaveChangesAsync();

                return Request.CreateResponse(HttpStatusCode.OK, user);
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadGateway, ModelState);
        }

        public async Task<IEnumerable<Company>> Get()
        {
            return await dbContext.Companies.ToListAsync();
        }
    }
}