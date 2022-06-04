using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWeb.Models
{
    public class Produto
    {
        public int id {get; set;}
        public string nomeProduto { get; set; }
        public string tipoProduto { get; set; }
    }

    public class ProdutoDbContext : DbContext
    {
        DbSet<Produto> produtos { get; set; }
    }
}
