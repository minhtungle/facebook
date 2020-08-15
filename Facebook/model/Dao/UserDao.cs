using model.E.F;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Dao
{
    public class UserDao
    {
        FacebookDbContext db = null;
        public UserDao()
        {
            db = new FacebookDbContext();
        }
        public bool Add(string user_account, string user_pass)
        {
            try
            {
                account acc = new account();
                acc.user_account = user_account;
                acc.user_pass = user_pass;
                db.accounts.Add(acc);
                db.SaveChanges();
                return true;
            }

            catch
            {
                return false;
            }
        }
        public bool Check_exist(string user_account, string user_pass)
        {
            var result = db.accounts.SingleOrDefault(x => x.user_account.ToLower() == user_account.ToLower() && x.user_pass.ToLower() == user_pass.ToLower());
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

