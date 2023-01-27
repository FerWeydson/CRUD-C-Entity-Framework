using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using teste_api.Entities;

namespace teste_api.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions <AgendaContext> options) :base(options)
        {
            
        }
        //propriedade que refere a entidade - classe no programa e ao mesmo tempo tabela no db
        public DbSet<Contato> Contatos { get; set; }
    }
}