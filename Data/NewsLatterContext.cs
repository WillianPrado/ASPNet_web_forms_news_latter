using sucesso_e_motivacao.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sucesso_e_motivacao.Data
{
    public class NewsLatterContext : DbContext
    {
        public NewsLatterContext() : base(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)
        {
            // Construtor da classe DbContext
        }
        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Image> Image { get; set; }
    }
}