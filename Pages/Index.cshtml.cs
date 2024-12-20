using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SiteComRazorPages.Data;
using SiteComRazorPages.Models;

namespace SiteComRazorPages.Pages;

public class Index : PageModel
{
    public List<Cliente> ListaClientes { get; set; } = new();
    
    public void OnGet([FromServices] DataContext dataContext)
    {
        var clientes = dataContext.Clientes.AsNoTracking().ToList();
        ListaClientes = clientes;
    }
}