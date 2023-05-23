using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamificação_02;

namespace Gamificacao_02
{
    // Classe CarrinhoDeCompras que compõe as classes de produtos adicionadas pelo usuário e as classes Promocao aplicadas
    class CarrinhoDeCompras
    {
        private List<ProdutoModel> produtos = new List<ProdutoModel>();
        private List<Promocao> promocoes = new List<Promocao>();

        // Método que adiciona um produto ao carrinho de compras
        public void AdicionarProduto(ProdutoModel produto)
        {
            produtos.Add(produto);
        }

        // Método que aplica uma promoção a um produto ou categoria de produtos
        public void AplicarPromocao(Promocao promocao)
        {
            promocoes.Add(promocao);
        }

        // Método que calcula o valor total dos produtos e descontos aplicados
        public double CalcularValorTotal()
        {
            double valorTotal = 0.0;

            foreach (ProdutoModel produto in produtos)
            {
                // Verifica se o produto possui alguma promoção aplicada
                double valorDesconto = 0.0;
                foreach (Promocao promocao in promocoes)
                {
                     if (promocao.Categoria == produto.Categoria)
                     {
                         valorDesconto += promocao.CalcularValorDesconto(produto.Preco);
                     }
                }

                valorTotal += produto.Preco - valorDesconto;
            }

            return valorTotal;
        }

        public void MostrarCarrinho()
        {
            Console.WriteLine("| Carrinho de Compras |");
            Console.WriteLine("Produtos adicionados:");

            foreach (ProdutoModel produto in produtos)
            {
                Console.WriteLine($"{produto.Nome} - {produto.Preco:C}");
            }

            Console.WriteLine($"Total: {CalcularValorTotal():C}");
            Console.WriteLine();
        }
    }
}
