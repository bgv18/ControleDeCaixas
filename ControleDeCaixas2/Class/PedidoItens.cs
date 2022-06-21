using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCaixas2
{
    public class PedidoItens
    {
        int Id { get; set; }
        int CodigoProduto { get; set; }
        string NomeProduto { get; set; }
        decimal Diamentro { get; set; }
        decimal Altura { get; set; }
        decimal Largura { get; set; }
        decimal Comprimento { get; set; }
        decimal Quantidade { get; set; }
        decimal Peso { get; set; }
        string Categoria { get; set; }
        bool Fragil { get; set; }
    }
}
