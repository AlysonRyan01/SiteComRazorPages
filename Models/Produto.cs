using System.Text.Json.Serialization;

namespace SiteComRazorPages.Models;

public class Produto
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string TipoProduto { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Serie { get; set; }
    public decimal Preco { get; set; }
    public string Garantia { get; set; }

    [JsonIgnore]
    public int? CarrinhoId { get; set; }
    
    [JsonIgnore]
    public Carrinho? Carrinho { get; set; }

    public IList<ProdutoImagens> ProdutoImagens { get; set; }

    public Produto()
    {
        ProdutoImagens = new List<ProdutoImagens>();
    }
}