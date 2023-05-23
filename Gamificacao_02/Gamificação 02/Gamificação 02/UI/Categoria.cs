using System;

namespace Gamificacao_02
{
    public class CategoriaUI
    {

        public void MenuDeFuncionalidades()
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Listar categorias");
                Console.WriteLine("2 - Cadastrar categoria");
                Console.WriteLine("3 - Alterar categoria");
                Console.WriteLine("4 - Excluir categoria");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ListarCategorias();
                        break;
                    case "2":
                        CadastrarCategoria();
                        break;
                    case "3":
                        AlterarCategoria();
                        break;
                    case "4":
                        ExcluirCategoria();
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
                Console.Clear();
            } while (continuar);
        }

        private void CadastrarCategoria()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de categoria:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Descricao: ");
            string descricao = Console.ReadLine();
            var proximoID = Program.categorias.Max((e) => e.CategoriaID) + 1;
            CategoriaModel categoria = new CategoriaModel
            {
                CategoriaID = proximoID ?? 1,
                CategoriaIDGUID = Guid.NewGuid(),
                Nome = nome,
                Descricao = descricao
            };
            Program.categorias.Add(categoria);


            Console.WriteLine();
            Console.WriteLine("Categoria cadastrada com sucesso!");
        }

        private void ListarCategorias()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias:");
            foreach (var categoria in Program.categorias)
            {
                Console.WriteLine($"ID: {categoria.CategoriaID} | Guid: {categoria.CategoriaIDGUID} | Nome: {categoria.Nome}");
            }
        }





        private void AlterarCategoria()
        {
            Console.Clear();
            Console.WriteLine("Alteração de categoria:");
            Console.Write("Digite o ID da categoria que deseja alterar: ");
            int id = int.Parse(Console.ReadLine());
            CategoriaModel categoria = Program.categorias.Find(c => c.CategoriaID == id);
            if (categoria == null)
            {
                Console.WriteLine("Categoria não encontrada!");
                return;
            }
            Console.Write($"Novo nome para a categoria {categoria.Nome}: ");
            string nome = Console.ReadLine();
            categoria.Nome = nome;

            Console.WriteLine();
            Console.WriteLine("Categoria alterada com sucesso!");
        }

        private void ExcluirCategoria()
        {
            Console.Clear();
            Console.WriteLine("Exclusão de categoria:");
            Console.Write("Digite o ID da categoria que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());
            CategoriaModel categoria = Program.categorias.Find(c => c.CategoriaID == id);
            if (categoria == null)
            {
                Console.WriteLine("Categoria não encontrada!");
                return;
            }

            if (Program.produtos.Exists(p => p.CategoriaModel.CategoriaID == id))
            {
                Console.WriteLine("Não é possível excluir a categoria, pois existem produtos vinculados a ela!");
                return;
            }

            Program.categorias.Remove(categoria);

            Console.WriteLine();
            Console.WriteLine("Categoria excluída com sucesso!");
        }
    }

}



	

