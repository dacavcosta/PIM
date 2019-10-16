using ControleFrotas.Domain.Enums;
using System;

namespace ControleFrotas.Domain.Model
{
    public class Abastecimento : BaseEntity
    {
        public DateTime Data { get; set; }
        public int Kilometragem { get; set; }
        public DateTime Responsavel { get; set; }
        public EnumTipoCombustivel Combustivel { get; set; }
        public double Litros { get; set; }
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
