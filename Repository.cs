using Microsoft.EntityFrameworkCore;


namespace Repository {
    public class Context : DbContext {
        //public DbSet<Models.Sessao> Sessoes { get; set; }
        public DbSet<Models.Usuario> Usuarios { get; set; }
        public DbSet<Models.Perfil> Perfis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("Server=localhost;User Id=root;Database=Matue");
    }
}