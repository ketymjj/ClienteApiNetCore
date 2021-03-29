using CadastroCliente.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<ClienteModel> ClienteModel { get; set; }

    }
}
