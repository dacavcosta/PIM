using ControleFrotas.Domain.Enums;
using System.Collections.Generic;

namespace ControleFrotas.Domain.Model
{
    public class Veiculo : BaseEntity
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string Renavam { get; set; }
        public int QuantidadePortas { get; set; }
        public EnumTipoVeiculo Tipo { get; set; }
        public string NumeroChassi { get; set; }
        public List<Manutencao> Manutencoes { get; set; }
        public EnumTipoCombustivel TipoCombustivel { get; set; }
        public int Abastecimento { get; set; }
        public int Ano { get; set; }
        public EnumStatusVeiculo Status { get; set; }
        public List<Abastecimento> Abastecimentos { get; set; }
        public List<Uso> Usos { get; set; }
    }
}
