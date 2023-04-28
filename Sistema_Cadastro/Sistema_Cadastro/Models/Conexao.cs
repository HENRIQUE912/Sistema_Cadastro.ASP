using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Cadastro.Models
{
    public class Conexao : DbContext
    {

        public DbSet<Instituicao> Instituicao { get; set; }

       
    }
}
