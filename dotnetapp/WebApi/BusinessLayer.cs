using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    internal class BusinessLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        public string SaveUser(UserModel user)
        {
            return (dal.SaveUser(user));
        }
        public bool AuthenticateUser(LoginModel login)
        {
            return dal.AuthenticateUser(login.email, login.password);
        }
    }
}