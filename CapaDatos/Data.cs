using CapaDatos.Tables;
using System.Data.Entity;

namespace CapaDatos
{
    public class Data : DbContext
    {
        public Data() : base("name=TrabajoPracticoObligatorio2")
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        
        
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        
        public DbSet<Consulta> Consulta { get; set; }
        
        public DbSet<Producto> Producto { get; set; }
        
    }
    
    
}
