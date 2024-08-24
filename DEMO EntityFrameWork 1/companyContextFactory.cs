using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_EntityFrameWork_1
{
    public class ITIDbContextFactory : IDesignTimeDbContextFactory<CompanyContext>
    {
        CompanyContext IDesignTimeDbContextFactory<CompanyContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CompanyContext>();
            optionsBuilder.UseSqlServer("Server = HESHAM\\HESHAMDB ; Database = Games; Trusted_Connection = True ; integrated security = true; trust server certificate= true; ");

            return new CompanyContext(optionsBuilder.Options);
        }
    }
}
