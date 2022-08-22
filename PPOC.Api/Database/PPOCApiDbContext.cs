using Microsoft.EntityFrameworkCore;
using PPOC.Api.Models;

namespace PPOC.Api.Database
{
    public class PPOCApiDbContext : DbContext
    {
        public PPOCApiDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
