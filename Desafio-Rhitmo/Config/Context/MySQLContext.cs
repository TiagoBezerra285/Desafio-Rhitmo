using Desafio_Rhitmo.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CartApi.Model.Context
{
    public class MySQLContext : DbContext
    {

        public MySQLContext()
        {
        
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<CadastroCartao> CadastroCartaos { get; set; }

    }

}

