using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiWindowsForms.Models;

namespace WebApiWindowsForms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private static List<Produto> _produtos = new List<Produto>
    {
        new Produto { Id = 1, Nome = "Notebook", Preco = 3500.00m, Estoque = 10 },
        new Produto { Id = 2, Nome = "Mouse", Preco = 50.00m, Estoque = 30 },
        new Produto { Id = 3, Nome = "Teclado", Preco = 120.00m, Estoque = 15 }
    };

    }
}
