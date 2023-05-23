using Gamificacao_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificação_02
{
    public class CarrinhoUI
    {

        public void MenuCarrinho()
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Adicionar Item");
                Console.WriteLine("2 - Retirar Item");
                Console.WriteLine("3 - Vizualizar Carrinho");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":
                        new CarrinhoDeCompras().MostrarCarrinho();
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

        

        public void AdicionarItem(int id)
        {
            
        }
    }
}
            
        
