using Microsoft.EntityFrameworkCore;

namespace Skeleton.Persistence
{
    public class SkeletonDbContext : DbContext
    {
        public SkeletonDbContext(DbContextOptions<SkeletonDbContext> options)
            : base(options)
        {
        }
    }
}