using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultantApp.Repositories.Account
{
    public class AccountsRepository : IRepository<Account>
    {

        private List<Account> accounts;

        public Account Create(Account entity)
        {
            this.accounts.Add(entity);
            return entity;
        }

        public void Delete(Account entity)
        {
            this.accounts.Remove(entity);
        }

        public IEnumerable<Account> GetAll()
        {
            return this.accounts;
        }

        public Account GetById(Guid id)
        {
            var account = from a in this.accounts
                       where a.Id == id
                       select a;
            return account.SingleOrDefault();
        }

        public void Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
