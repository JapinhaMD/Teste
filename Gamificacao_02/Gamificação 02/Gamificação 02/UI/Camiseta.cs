using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Gamificação_02;

namespace Gamificacao_02
{
    class Camisetas
    {
        public string Camiseta(CarrinhoDeCompras carrinho)
        {
        string opcaoCamiseta = Console.ReadLine();
        switch (opcaoCamiseta)
        {
            case "1":
                ProdutoModel camisetaazul = new ProdutoModel
                { 
                    Nome = "Camiseta Azul", 
                    Preco = 70.0, Categoria = CategoriaProduto.Camiseta
                };

                carrinho.AdicionarProduto(camisetaazul);
                Console.WriteLine("Camiseta Azul adicionada ao carrinho de compras!");
                Console.WriteLine();
                break;

            case "2":
                ProdutoModel camisetabranca = new ProdutoModel    
                { 
                    Nome = "Camiseta Branca", 
                    Preco = 70.0, Categoria = CategoriaProduto.Camiseta
                };

                carrinho.AdicionarProduto(camisetabranca);
                Console.WriteLine("Camiseta Branca adicionada ao carrinho de compras!");
                Console.WriteLine();
                break;

            case "3":
                ProdutoModel camisetaestampada = new ProdutoModel
                { 
                    Nome = "Camiseta Estampada", 
                    Preco = 100.0, Categoria = CategoriaProduto.Camiseta
                };

                carrinho.AdicionarProduto(camisetaestampada);
                Console.WriteLine("Camiseta Estampada adicionada ao carrinho de compras!");
                Console.WriteLine();
                break; // Para adicionar mais produtos à loja, basta colocas mais cases

            case "4":
                Console.WriteLine("|Promoções para Camisetas|");
                Console.WriteLine("10% de desconto para todas as Camisetas");
                break;


            case "0":
                break;
        }
            return opcaoCamiseta;
        }
    }
}
