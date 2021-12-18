using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpProva
{
    public class CalculaPecas
    {
        // public Pecas pecaS = new Pecas();
        public double _codigoPeca;
        public int quantidadePecas;
        public double valorUnitario;

        public double CodigoPeca
        {
            get
            {
                return _codigoPeca;
            }
            set
            {
                this._codigoPeca = value;
            }
        }
        public int QuantidadePeca 
        {
            get
            {
                return quantidadePecas;
            }
            set
            {
                this.quantidadePecas = value;
            }
        }
        public double ValorPeca
        {
            get
            {
                return valorUnitario;
            }
            set
            {
                this.valorUnitario = value;
            }
        }

    }
}