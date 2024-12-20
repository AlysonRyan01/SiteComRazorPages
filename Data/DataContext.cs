using Microsoft.EntityFrameworkCore;
using SiteComRazorPages.Data.Mappings;
using SiteComRazorPages.Models;

namespace SiteComRazorPages.Data;

public class DataContext : DbContext
{
    public DbSet<Carrinho> Carrinhos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Pagamento> Pagamentos { get; set; }
    public DbSet<ProdutoImagens> ProdutoImagens { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<RelatorioVendas> RelatoriosVendas { get; set; }
    public DbSet<VendaFinal> VendasFinais { get; set; }
    public DbSet<Cargo> Cargos { get; set; }
    
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CarrinhoMap());
        modelBuilder.ApplyConfiguration(new ClienteMap());
        modelBuilder.ApplyConfiguration(new PagamentoMap());
        modelBuilder.ApplyConfiguration(new ProdutoImagensMap());
        modelBuilder.ApplyConfiguration(new ProdutoMap());
        modelBuilder.ApplyConfiguration(new RelatorioVendasMap());
        modelBuilder.ApplyConfiguration(new VendaFinalMap());
        modelBuilder.ApplyConfiguration(new CargoMap());
    }
}