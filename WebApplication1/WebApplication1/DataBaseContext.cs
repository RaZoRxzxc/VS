namespace WebApplication1
{
    public class DataBaseContext: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>()
                .HasAlternateKey(u => u.email);
            modelBuilder.Entity<UserEntity>()
                .HasData(new UserEntity
                {
                    family = "Иванов",
                    name = "",
                    patronymic = "",
                    email = "ivanov@exammple.com",
                    password = "password"
                });
        }
        public DbSet<UserEntity> Users => Set<UserEntity>();
    }
}
