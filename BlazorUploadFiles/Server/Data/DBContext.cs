using BlazorUploadFiles.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorUploadFiles.Server.Data
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<UploadResult> Uploads => Set<UploadResult>();
    }
}
