using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCaixas2 
{
    internal class Box
    {
        private static int _Id;
        private static double _Altura;
        private static double _Largura;
        private static double _Comprimento;
        private static double _Volume = _Altura * _Largura*_Comprimento;
        private static int _Quantidade;

        public double Altura
        {
            get { return _Altura; }
            set { _Altura = value; }         
        }
        public double Largura
        {
            set { _Largura = value; }
            get { return _Largura; }
        }
        public double Comprimento 
        {
            set { _Comprimento = value; }
            get { return _Comprimento; }
        }
        public int Quantidade
        {
            get { return _Quantidade; }
            set { _Quantidade = value; }
        }



    }
}
