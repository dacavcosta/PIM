using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFrotas.Domain.Model
{
    public class Uso : BaseEntity
    {
        public int KmInicial { get; set; }
        public int KmFinal { get; set; }
        public string Destino { get; set; }
        public string Relatorio { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Retorno { get; set; }
        public string Autorizacao { get; set; }
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
