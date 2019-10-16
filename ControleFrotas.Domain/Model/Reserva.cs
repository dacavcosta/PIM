using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFrotas.Domain.Model
{
    public class Reserva : BaseEntity
    {
        public DateTime DataSolicitacao { get; set; }
        public int QuantidadePassageiros { get; set; }
        public string Destino { get; set; }
        public string FimDestino { get; set; }
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}
