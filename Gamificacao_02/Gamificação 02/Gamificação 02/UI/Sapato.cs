using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao_02
{
    class Sapatos
    {
        public string Sapato(CarrinhoDeCompras carrinho)
        {
            string opcaoSapato = Console.ReadLine();

            switch (opcaoSapato)
            {
                case "1":
                    Sapato sapatoSocial = new Sapato
                    {
                        Nome = "Sapato Social",
                        Preco = 150.0,
                        Categoria = CategoriaProduto.Sapato,
                        Tamanho = "39",
                        Cor = "Preto",
                        Material = "Couro"
                    };

                    carrinho.AdicionarProduto(sapatoSocial);
                    Console.WriteLine("Sapato Social adicionado ao carrinho de compras!");
                    Console.WriteLine();
                    break;

               
            }
            return opcaoSapato;
        }
    }
}