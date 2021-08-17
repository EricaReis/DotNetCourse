namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext createDbContext(string[] arg)
        {
            var connectionString = "Server=localhost;Port=3306;Database=Course;Uid=root;Pwd=admin";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString);
            return new MyContext(optionsBuilder.options);
        }

    }
}