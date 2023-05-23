using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao_02
{
    class Promocao
    {
        public enum TipoDesconto
        {
            Porcentagem,
            ValorFixo,
            Categoria
        }

        public TipoDesconto Desconto { get; set; }
        public double ValorDesconto { get; set; }
        public CategoriaProduto Categoria { get; internal set; }

        // Método que calcula o valor total do desconto a ser aplicado
        public double CalcularValorDesconto(double precoOriginal)
        {
            if (Desconto == TipoDesconto.Porcentagem)
            {
                return precoOriginal * (ValorDesconto / 100.0);
            }
            else
            {
                return ValorDesconto;
            }
        }

    }
}
