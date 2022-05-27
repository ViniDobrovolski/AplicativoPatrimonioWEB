using Microsoft.EntityFrameworkCore;


namespace SysAplicativo.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opcoes )
            : base(opcoes)
        {
        }
        
        public DbSet<DbUsuario> Usuarios { get; set; }

        public DbSet<DbPatrimonio> Patrimonios { get; set; }

        public DbSet<DbLocal> Locais { get; set; }

        public DbSet<DbFornecedor> Fornecedores { get; set; }

        public DbSet<DbDepartamento> Departamentos { get; set; }

        public DbSet<DbCategoria> Categorias { get; set; }




    }


}