// See https://aka.ms/new-console-template for more information
using Gamificacao_02;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Gamificação_02;


public class Program
{

    public static List<ProdutoModel> produtos = new List<ProdutoModel>();
    public static List<CategoriaModel> categorias = new List<CategoriaModel>();
    static void Main(string[] args)
    {    
        
           
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            Promocao promocoes = new Promocao();
        

            bool continuar = true;
            do
            {

            Console.WriteLine("    |Menu Principal|");
            Console.WriteLine("");
            Console.WriteLine("1 - Gerenciar Produtos");
            Console.WriteLine("2 - Gerenciar Categorias");
            Console.WriteLine("3 - Carrinho de Compras");
            Console.WriteLine("0 - Finalizar");



            string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                    new ProdutoUI().GerenciarProdutos();                  
                        break;
                    

                    case "2":

                    new CategoriaUI().MenuDeFuncionalidades();                         
                        break;


                    case "3":

                    new CarrinhoUI().MenuCarrinho();                  
                        break;

                    case "0":
                        continuar = false;
                        break;
                }
            } while (continuar);

            // Aplicar Promoções desejadas

            // Alterar promocoes 
            Promocao promocaocamiseta = new Promocao
            {
                Categoria = CategoriaProduto.Camiseta,
                Desconto = Promocao.TipoDesconto.Porcentagem,
                ValorDesconto = 10.0
            };

            Promocao promocaocalca = new Promocao
            {
                Categoria = CategoriaProduto.Calca,
                Desconto = Promocao.TipoDesconto.Porcentagem,
                ValorDesconto = 15.0
            };

            Promocao promocaosapato = new Promocao
            {
                Categoria = CategoriaProduto.Sapato,
                Desconto = Promocao.TipoDesconto.Porcentagem,
                ValorDesconto = 20.0
            };

            Promocao promocaobolsa = new Promocao
            {
                Categoria = CategoriaProduto.Bolsa,
                Desconto = Promocao.TipoDesconto.Porcentagem,
                ValorDesconto = 10.0
            };

            carrinho.AplicarPromocao(promocaocamiseta);
            carrinho.AplicarPromocao(promocaocalca);
            carrinho.AplicarPromocao(promocaosapato);
            carrinho.AplicarPromocao(promocaobolsa);

            double totalCompra = carrinho.CalcularValorTotal();
            Console.WriteLine($"Valor total da compra: R${totalCompra}");
    }
}










