using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class ApplicationUser:IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("Data Source = DESKTOP - 8MEVUBJ\\SQLEXPRESS; Initial Catalog = UserDb; User Id = sa; Password = magic;Integrated Security = True", throwIfV1Schema: false)
        {

        }

        
    }
}
