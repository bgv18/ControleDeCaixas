using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCaixas2 
{
    internal class Box
    {
        int Id { get; set; }
        string Nome { get; set; }
        decimal Altura { get; set; }
        decimal Largura { get; set; }
        decimal Profundidade { get; set; }
        decimal Volume { get; set; }
        int Quantidade { get; set; }

        public double CalculoVolume()
        {
            Volume = Altura * Largura * Profundidade;
            return (double)Volume;
        }
    }
}
