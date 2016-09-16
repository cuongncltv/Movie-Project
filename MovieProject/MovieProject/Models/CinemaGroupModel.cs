using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MovieProject.Models.Framework;

namespace MovieProject.Models
{
    public class CinemaGroupModel
    {
        private MovieDbContext context = null;

        public CinemaGroupModel()
        {
            context = new MovieDbContext();
        }

        public List<Cinema_Group> GetList()
        {
            var list = context.Database.SqlQuery<Cinema_Group>("sp_Group_Get_All").ToList();
            return list;
        }

        public int Create(string groupName)
        {
            object[] sqlParams = {
                new SqlParameter("@GrName", groupName),
            };
            int res = context.Database.ExecuteSqlCommand("sp_Group_Insert", sqlParams);
            return res;
        }
    }
}