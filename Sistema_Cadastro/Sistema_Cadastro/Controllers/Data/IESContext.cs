using Microsoft.EntityFrameworkCore;
using Sistema_Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Cadastro.Controllers.Data
{
    public class IESContext : DbContext
    {

        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {
        }

        public DbSet<Instituicao> Instituicoes { get; set; }
    }
}
