
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SysmapApi.Models;

namespace SysmapApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class VendaProdutoController
    {

        private static List<VendaProduto> vendaProdutos = new List<VendaProduto>();
        private static List<Venda> vendas = new List<Venda>();

        private static int id = 10;

        [HttpPost]
        public void CadastrarVendaProduto ( [FromBody] VendaProduto vendaProduto )
        {
            vendaProduto.VendaProdutoId = id++;
            vendaProduto.DataCriacao = DateTime.Now;
            vendaProdutos.Add(vendaProduto);
        }

        [HttpGet]
        public IEnumerable<VendaProduto> ConsultarVendaProduto ()
        {
            return vendaProdutos;
        }

        [HttpGet("{Id}")]
        public VendaProduto ConsultarProdutoPorId ( int id )
        {
            return vendaProdutos.Find(p => p.VendaProdutoId == id);
        }


    }
}
