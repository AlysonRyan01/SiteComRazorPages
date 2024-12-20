using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SiteComRazorPages.Data;
using SiteComRazorPages.Models;

namespace SiteComRazorPages.Pages;

public class VendasFinais : PageModel
{
    public List<VendaFinal> ListaVendasFinais { get; set; }
    
    public void OnGet([FromServices] DataContext context)
    {
        var vendas = context.VendasFinais.AsNoTracking().ToList();
        ListaVendasFinais = vendas;
    }
}