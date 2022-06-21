using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCaixas2
{
    public class Frete
    {
        int Id { get; set; }
        string NumeroRastreio { get; set; }
        int IdPedido { get; set; }
        string CodigoServicoEntrega { get; set; }
    }
}
