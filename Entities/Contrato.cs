using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface00.Entities
{
    public class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }

        public List<Parcela> Parcelas { get; set; } = new List<Parcela>();

        public void CalcularParcelas(int parcelas)
        {
            double valorParcela = ValorTotal / parcelas;

            for (int i = 1; i <= parcelas; i++)
            {
                Parcela parcela = new Parcela()
                {
                    Data = Data.AddMonths(i),
                    Valor = (valorParcela + valorParcela * 0.01 * i) + (valorParcela * 0.02)
                };

                Parcelas.Add(parcela);
            }
        }
    }
}
