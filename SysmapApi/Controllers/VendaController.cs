
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
    public class VendaController
    {
        private static List<Venda> vendas = new List<Venda>();
        private static int id = 5;

        [HttpPost]
        public void CadastrarVenda ( [FromBody] Venda venda )
        {
            venda.VendaId = id++;
            venda.DataCriacao = DateTime.Now;
            vendas.Add(venda);
        }

        [HttpGet("{Id}")]
        public Venda ConsultarProdutoPorId ( int id )
        {
            return vendas.Find(p => p.VendaId == id);
        }

    }
}
