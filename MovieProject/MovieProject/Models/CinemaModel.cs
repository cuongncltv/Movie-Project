using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieProject.Models.Framework;

namespace MovieProject.Models
{
    public class CinemaModel
    {
        private MovieDbContext context = null;

        public CinemaModel()
        {
            context = new MovieDbContext();
        }

        public List<Cinemas>  ListAll()
        {
            var list = context.Database.SqlQuery<Cinemas>("sp_Cinema_Get_All").ToList();
            return list;
        }
    }
}