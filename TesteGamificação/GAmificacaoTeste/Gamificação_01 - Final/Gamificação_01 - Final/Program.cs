// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using JRJ.Modas;

namespace JRJ.Modas
{
    public class Program
    {
        public static List<ProdutoModel> produtos = new List<ProdutoModel>();
        public static List<CategoriaModel> categorias = new List<CategoriaModel>();
        
        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Gerenciar produtos");
                Console.WriteLine("2 - Gerenciar categorias");
                Console.WriteLine("3 - Gerenciar clientes");
                Console.WriteLine("4 - Realizar venda");
                Console.WriteLine("5 - Mostrar relatório de vendas");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        new ProdutoUI().GerenciarProdutos();
                        break;
                    case "2":
                        new CategoriaUI().MenuDeFuncionalidades();

                        //var ui = new CategoriaUI(categorias);
                        //ui.MenuDeFuncionalidades();
                        break;
                    case "3":
                        //GerenciarClientes();
                        break;
                    case "4":
                        //RealizarVenda();
                        break;
                    case "5":
                        //MostrarRelatorioVendas();
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




    }
}