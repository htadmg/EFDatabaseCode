using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clientes = new VendaWebContext().Cliente.ToList();
            Cliente cliente = clientes[0];

            var produtos = new VendaWebContext().Produto.ToList();
            Produto produto = produtos[0];

            var pedidos = new VendaWebContext().Pedido.ToList();
            Pedido pedido = pedidos[0];

            var pedidoProdutos = new VendaWebContext().PedidoProduto.ToList();
            PedidoProduto pedidoProduto = pedidoProdutos[0];
        }
    }
}
