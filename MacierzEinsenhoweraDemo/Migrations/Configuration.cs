namespace MacierzEinsenhoweraDemo.Migrations
{
    using Models.Entities;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MatrixContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.MatrixContext context)
        {
            var matrixs = new List<Matrix>
            {
                new Matrix { MatrixID = 1, Name = "MacierzDemo" },
                new Matrix { MatrixID = 2, Name = "Inna" }
                
            };

            matrixs.ForEach(s => context.Matrixs.AddOrUpdate(s));

            var tasks = new List<MatrixTask>
            {
                new MatrixTask { MatrixTaskID = 1, Title = "pierwsze", Priority = "WP", ArraytID = 1 },
                new MatrixTask { MatrixTaskID = 2, Title = "drugie", Priority = "WP", ArraytID = 1 },

                new MatrixTask { MatrixTaskID = 6, Title = "zadanie", Priority = "WN", ArraytID = 1 },
                new MatrixTask { MatrixTaskID = 8, Title = "trz", Priority = "WN", ArraytID = 1 },

                new MatrixTask { MatrixTaskID = 9, Title = "test", Priority = "NP", ArraytID = 1 },

                new MatrixTask { MatrixTaskID = 10, Title = "test2", Priority = "NN", ArraytID = 1 },
                new MatrixTask { MatrixTaskID = 11, Title = "test3", Priority = "NN", ArraytID = 1 },
            };

            tasks.ForEach(s => context.MatrixTasks.AddOrUpdate(s));

            context.SaveChanges();
        }
    }
}
