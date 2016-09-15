using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MovieProject.Models.Framework;

namespace MovieProject.Models
{
    public class AccountModel
    {
        private MovieDbContext context = null;

        public AccountModel()
        {
            context = new MovieDbContext();
        }
        
        public bool Login(string email, string password)
        {
            object[] sqlParams = {
                new SqlParameter("@email", email),
                new SqlParameter("@password",password),
            };
            var res = context.Database.SqlQuery<bool>("sp_Login_Admin @email, @password",sqlParams).SingleOrDefault();
            return res;
        }
    }
}