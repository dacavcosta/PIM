using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFrotas.Domain.Model
{
    public class Manutencao : BaseEntity
    {
        public DateTime Data { get; set; }
        public string Responsavel { get; set; }
        public string Descricao { get; set; }
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
        public List<Peca> Pecas { get; set; }
    }
}
