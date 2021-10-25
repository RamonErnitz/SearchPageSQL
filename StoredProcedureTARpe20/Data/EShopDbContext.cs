using Microsoft.EntityFrameworkCore;


namespace TARge20.Data
{
    public class EShopDbContext : DbContext
    {

        public EShopDbContext(DbContextOptions<EShopDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.

    }
}