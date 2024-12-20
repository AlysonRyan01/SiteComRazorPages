using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SiteComRazorPages.Data;
using SiteComRazorPages.Models;

namespace SiteComRazorPages.Pages;

public class Produtos : PageModel
{
    public List<Produto> ListaProdutos { get; set; } = new();
    
    public void OnGet([FromServices] DataContext context)
    {
        var produtos = context.Produtos.AsNoTracking().Include(x => x.ProdutoImagens).ToList();
        ListaProdutos = produtos;
    }
}