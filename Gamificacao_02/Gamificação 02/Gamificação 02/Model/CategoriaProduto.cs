using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao_02
{
    // Enumerador que define as categorias de produtos
    public enum CategoriaProduto
    {
        Camiseta,
        Calca,
        Sapato,
        Bolsa,
        Acessorio
    }

    public class CategoriaModel
    {
        public long? CategoriaID { get; set; }
        public Guid CategoriaIDGUID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

    }
}
