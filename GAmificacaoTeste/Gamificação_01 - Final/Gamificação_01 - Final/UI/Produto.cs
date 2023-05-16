﻿using JRJ.Modas;
using System;
using System.Collections.Generic;


namespace JRJ.Modas
{
    public class ProdutoUI
    {
        private List<CategoriaModel> _categorias;
        private List<ProdutoModel> _produtos;
        public ProdutoUI(List<ProdutoModel> produtos)
        {
            _produtos = produtos;
        }
        public void GerenciarProdutos()
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Listar produtos");
                Console.WriteLine("2 - Cadastrar produto");
                Console.WriteLine("3 - Alterar produto");
                Console.WriteLine("4 - Excluir produto");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ListarProdutos();
                        break;
                    case "2":
                        CadastrarProduto();
                        break;
                    case "3":
                        AlterarProduto();
                        break;
                    case "4":
                        ExcluirProduto();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (continuar);
        }

        public void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("Lista de produtos:");
            foreach (var produto in _produtos)
            {
                Console.WriteLine($"ID: {produto.ProdutoID} | Nome: {produto.Nome} | Preço: {produto.Preco} | Categoria: {produto.Categoria.Nome}");
            }
        }



        public void CadastrarProduto()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de produto:");

            ProdutoModel produto = new ProdutoModel();

            var proximoID = _produtos.Max((e) => e.ProdutoID) + 1;

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            double preco;
            while (true)
            {
                Console.Write("Preço: ");
                try
                {
                    preco = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Preço inválido. Digite um valor numérico válido.");
                }
            }
            produto.Preco = preco;

            int idCategoria;
            while (true)
            {
                Console.Write("ID da categoria: ");
                try
                {
                    idCategoria = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("ID inválido. Digite um valor numérico válido.");
                }
            }

            produto.Categoria = _categorias.Find(c => c.CategoriaID == idCategoria);

            if (produto.Categoria == null)
            {
                Console.WriteLine("Categoria não encontrada.");
            }
            else
            {
                _produtos.Add(produto);
                Console.WriteLine("Produto cadastrado com sucesso!");
            }
        }

        private void AlterarProduto()
        {
            Console.Clear();
            Console.WriteLine("Alteração de produto:");

            Console.Write("ID do produto: ");
            int idProduto = int.Parse(Console.ReadLine());

            ProdutoModel produto = _produtos.Find(p => p.ProdutoID == idProduto);

            if (produto != null)
            {
                Console.Write($"Nome ({produto.Nome}): ");
                string nome = Console.ReadLine();
                if (!string.IsNullOrEmpty(nome))
                {
                    produto.Nome = nome;
                }

                Console.Write($"Preço ({produto.Preco}): ");
                string precoStr = Console.ReadLine();
                if (!string.IsNullOrEmpty(precoStr))
                {
                    produto.Preco = double.Parse(precoStr);
                }

                Console.Write($"ID da categoria ({produto.Categoria.CategoriaID}): ");
                string idCategoriaStr = Console.ReadLine();
                if (!string.IsNullOrEmpty(idCategoriaStr))
                {
                    long idCategoria = long.Parse(idCategoriaStr);
                    produto.Categoria = _categorias.Find(c => c.CategoriaID == idCategoria);
                }

                Console.WriteLine("Produto alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }

        private void ExcluirProduto()
        {
            Console.Clear();
            Console.WriteLine("Exclusão de produto:");

            Console.Write("ID do produto: ");
            int idProduto = int.Parse(Console.ReadLine());

            ProdutoModel produto = _produtos.Find(p => p.ProdutoID == idProduto);

            if (produto != null)
            {
                _produtos.Remove(produto);
                Console.WriteLine("Produto excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }
    }
}
