using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.Context;

public class AkimLib2DbContextDesignFactory : IDesignTimeDbContextFactory<AkimLib2DbContext>
{
    public AkimLib2DbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AkimLib2DbContext>();
        optionsBuilder.UseSqlite("Data Source=akim_lib_2.db");
        return new AkimLib2DbContext(optionsBuilder.Options);
    }
}