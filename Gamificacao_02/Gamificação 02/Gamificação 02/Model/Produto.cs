using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamificacao_02;

namespace Gamificação_02
{
    public class ProdutoModel
    { 
        public long? ProdutoID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
        public CategoriaModel? CategoriaModel { get; set; }
        public CategoriaProduto Categoria { get; set; }
    }


}
