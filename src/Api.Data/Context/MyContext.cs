using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<CategoriaServicoEntity> CategoriasServico { get; set; }
        public DbSet<TipoPagamentoEntity> TiposPagamentos { get;set; }
        public DbSet<ServicoEntity> Servicos { get;set; }
        public DbSet<FuncionarioEntity> Funcionarios { get;set; }
        public DbSet<ClienteEntity> Clientes { get; set; }
    }
}