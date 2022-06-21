using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCaixas2
{
    public class Pedido
    {
        int Id { get; set; }
        int CodigoPedidoERP { get; set; }
        int ProdutoItens { get; set; }
        int CepOrigem { get; set; }
        int CepDestino { get; set; }
        decimal Valor { get; set; }
        int CpfCnpjDestinatario { get; set; }
        string PaisDestinatario { get; set; }
        int Documento { get; set; }
        string Serie { get; set; }
        DateTime Data { get; set; }
    }
}
