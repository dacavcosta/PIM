using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Text;

namespace ControleFrotas.Domain.Model
{
    public class Peca : BaseEntity
    {
        public string Nome { get; set; }
        public string Veiculo { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int ManutencaoId { get; set; }
        public Manutencao Manutencao { get; set; }
    }
}
