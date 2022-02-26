using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCaixas2 
{
    internal class Box
    {
        private int _Id { get; set; }
        private double _Altura { get; set; }
        private double _Largura { get; set; }
        private double _Comprimento { get; set; }
        private double _Volume { get; set; }
        private int _Quantidade { get; set; }

        public double CalculoVolume()
        {
            _Volume = _Altura * _Largura * _Comprimento;
            return _Volume;
        }
    }
}
