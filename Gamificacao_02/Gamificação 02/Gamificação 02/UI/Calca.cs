using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Gamificação_02;

namespace Gamificacao_02
{

    class Calcas
	{
		public string Calca(CarrinhoDeCompras carrinho)
		{
            string opcaoCalca = Console.ReadLine();
            switch (opcaoCalca)
            {
                case "1":
                    ProdutoModel calcaJeans = new ProdutoModel
                    { 
                     Nome = "Calca Jeans",
                     Preco = 120.0,
                     Categoria = CategoriaProduto.Calca
                    };

                    carrinho.AdicionarProduto(calcaJeans);
                    Console.WriteLine("Calca Jeans adicionada ao carrinho de compras!");
                    Console.WriteLine();
                    break;

                case "2":
                    ProdutoModel calcaSocial = new ProdutoModel
                    { 
                     Nome = "Calca Social",
                     Preco = 150.0, 
                     Categoria = CategoriaProduto.Calca
                    };

                    carrinho.AdicionarProduto(calcaSocial);
                    Console.WriteLine("Calca Social adicionada ao carrinho de compras!");
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine("|Promoções para Calcas|");
                    Console.WriteLine("15% de desconto para todas as Calcas");
                    break;

                case "0":
                    break;
            }
                return opcaoCalca;
        }
	}
}