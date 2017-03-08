using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MacierzEinsenhoweraDemo.Models.Entities;

namespace MacierzEinsenhoweraDemo.DAL
{
    public class MatrixContext : DbContext
    {
        public MatrixContext()
            : base("MatrixContext")
        {
        }

        public DbSet<Matrix> Matrixs { get; set; }
        public DbSet<MatrixTask> MatrixTasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}