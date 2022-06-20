using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SysmapApi.Models;

namespace SysmapApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();
        private static int id = 1;

        [HttpPost]
        public void CadastrarProduto ( [FromBody] Produto produto )
        {
            produto.ProdutoId = id++;
            produto.DataCriacao = DateTime.Now;
            produtos.Add(produto);
            Console.WriteLine(produto.Nome);
        }

        [HttpGet]
        public IEnumerable<Produto> ConsultarProduto ()
        {
            return produtos;
        }

        [HttpGet("{Id}")]
        public Produto ConsultarProdutoPorId ( int id )
        {
            return produtos.Find(p => p.ProdutoId == id);
        }


    }
}
