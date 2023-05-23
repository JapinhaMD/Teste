using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao_02
{

    class Bolsas
    {
        public string Bolsa(CarrinhoDeCompras carrinho)
        {
            string opcaoBolsa = Console.ReadLine();

            switch (opcaoBolsa)
            {
                case "1":
                    Bolsa bolsasocial = new Bolsa
                    {
                        Nome = "Bolsa Social",
                        Preco = 150.0,
                        Categoria = CategoriaProduto.Bolsa,
                        Tamanho = "20",
                        Cor = "Preto",
                        Compartimentos = 3
                    };

                    carrinho.AdicionarProduto(bolsasocial);
                    Console.WriteLine("Bolsa Social adicionada ao carrinho de compras!");
                    Console.WriteLine();
                    break;

                case "2":
                    Bolsa bolsacasual = new Bolsa
                    {
                        Nome = "Bolsa Casual",
                        Preco = 100.0,
                        Categoria = CategoriaProduto.Bolsa,
                        Tamanho = "18",
                        Cor = "Rosa",
                        Compartimentos = 2
                    };

                    carrinho.AdicionarProduto(bolsacasual);
                    Console.WriteLine("Bolsa Casual adicionada ao carrinho de compras!");
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine("|Promoções para Bolsas|");
                    Console.WriteLine("10% de desconto para todas as Bolsas");
                    break;

                case "0":
                    break;
            }
            return opcaoBolsa;
        }
    }
}