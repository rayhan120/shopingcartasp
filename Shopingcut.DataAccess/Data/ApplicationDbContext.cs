using Shopingcut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shopingcut.DataAccess.Data
{
    public class ApplicationDbContext :IdentityDbContext

    {
        private object get;

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base( options )
        {

            
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
