using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using app.Models;
using System.Data.Entity;

namespace app.Controllers
{
    public class Connection : DbContext
    {
        public DbSet<Usuario> ObjRegisterUser { get; set; }
    }
}